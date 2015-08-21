using RiotApiDAL.Contexts;
using RiotApiDAL.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itemise_It.Helpers
{
    public static class Helper
    {
        public static Patch GetPatch(string version)
        {
            return PatchContext.GetPatch(version);
        }
        public static List<Patch> GetPatches(string[] versions)
        {
            var patches = new List<Patch>();
            foreach (var ver in versions)
            {
                patches.Add(PatchContext.GetPatch(ver));
            }
            return patches;
        }
    }
}