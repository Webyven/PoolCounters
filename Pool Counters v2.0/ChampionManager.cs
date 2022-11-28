using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    public static class ChampionManager
    {
        static List<Champion> champions = new List<Champion>();

        public static void AddChamp(Champion champ)
        {
            champions.Add(champ);
        }

        public static List<Champion> GetChampions()
        {
            return champions;
        }

        public static List<string> GetChampionsNames()
        {
            List<string> res = new List<string>();
            foreach (var item in champions)
                res.Add(item.GetName());

            return res;
        }

        public static Champion UniversalFindChamp(string name)
        {
            Champion result;
            result = FindChamp(Modules.Internal.UppercaseFirst(name));

            if (result == null)
                FindChamp(Modules.Internal.UppercaseFirstMinusAnothers(name));

            return result;
        }

        private static Champion FindChamp(string name)
        {
            Champion result;
            result = FindChampByName(name);

            if (result == null)
                result = FindChampByAlias(name);

            return result;
        }

        private static Champion FindChampByAlias(string name)
        {
            foreach(Champion champ in champions)
            {
                if (champ.GetAlias() != null)
                {
                    foreach(string alias in champ.GetAlias())
                    {
                        if (alias.ToLower() == name.ToLower())
                            return champ;
                    }
                }
            }

            return null;
        }

        private static Champion FindChampByName(string name)
        {
            foreach(Champion champ in champions)
            {
                if (champ.GetName().ToLower() == name.ToLower())
                    return champ;
            }

            return null;
        }
    }
}
