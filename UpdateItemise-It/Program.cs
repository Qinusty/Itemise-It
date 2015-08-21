using System.Configuration;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApiDAL.Contexts;
using RiotApiDAL;
using System;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using RiotApi.Net.RestClient.Dto.LolStaticData.Item;
using System.Data.SqlClient;
using RiotApiDAL.Static;
using System.Collections.Generic;
using RiotApiDAL.Static.Item;


namespace RiotApiDAL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string apiKey = ConfigurationManager.AppSettings.Get("apiKey");
            StartProcessing(apiKey);
          
            
        }
        static void BackLog(string apiKey)
        {
            var riotClient = RiotApiLoader.CreateHttpClient(apiKey);
            var versions = riotClient.LolStaticData.GetVersionData(RiotApiConfig.Regions.EUW);
            foreach (var version in versions)
            {
                if (version.StartsWith("4."))
                {
                    break;
                }
                StartProcessing(apiKey, riotClient, version);

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Your Riot API Key</param>
        /// <param name="version">The version to process, This can be left null to check the latest version.</param>
        static void StartProcessing(string apiKey, RiotClient riotClient = null, string version = null)
        {
            if (riotClient == null)
            {
                riotClient = RiotApiLoader.CreateHttpClient(apiKey);
            }
            
            ChampionListDto champData = null;
            int tryCount = 0;
            bool gotData = false;
            do
            {
                try
                {
                    champData = riotClient.LolStaticData.GetChampionList(RiotApiConfig.Regions.EUW, null, null, version, null);
                    gotData = true;
                }

                catch (Exception ex)
                {
                    tryCount += 1;
                    if (tryCount % 3 == 0)
                    {
                        System.Threading.Thread.Sleep(60000);
                    }
                }
            } while (gotData == false);
            version = champData.Version;
            if (isNewVersion(version))
            {
                AddData(riotClient, version);
            }
        }
        static bool isNewVersion(string version)
        {
            return (!PatchContext.PatchExists(version));
        }
        static void AddData(RiotClient riotClient, string version = null)
        {
            int tryCount = 0;
            bool gotData = false;
            ChampionListDto champData = null;
            ItemListDto itemData = null;
            do
            {
                try
                {
                    champData = riotClient.LolStaticData.GetChampionList(RiotApiConfig.Regions.EUW, null, null, version, "all");
                    gotData = true;
                }

                catch (Exception ex)
                {
                    tryCount += 1;
                    if (tryCount % 3 == 0)
                    {
                        System.Threading.Thread.Sleep(60000);
                    }
                }
            } while (gotData == false);

            version = champData.Version;
            // reset loop variables
            gotData = false;
            tryCount = 0;
            // ---------------------
            do
            {
                try
                {
                    itemData = riotClient.LolStaticData.GetItemList(RiotApiConfig.Regions.EUW, null, version, "all");
                    gotData = true;
                }
                catch
                {
                    tryCount += 1;
                    if (tryCount % 3 == 0)
                    {
                        System.Threading.Thread.Sleep(60000);
                    }
                }
            } while (gotData == false);

            if (itemData != null && champData != null)
            {
                PatchContext context = new PatchContext();
                context.PatchList.Add(new Patch(champData, itemData));
                context.SaveChanges();
                MailControl.SendMail("Added Patch", $"Patch {version} was successfully added to the database at {DateTime.Now}.");
            }
        }
    }
}
