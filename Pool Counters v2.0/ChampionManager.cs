using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    class ChampionManager
    {
        List<Champion> champions;

        public ChampionManager()
        {
            champions = new List<Champion>();
        }

        public void AddChamp(Champion champ)
        {
            this.champions.Add(champ);
        }

        public List<Champion> GetChampions()
        {
            return this.champions;
        }

        public Champion UniversalFindChamp(string name)
        {
            Champion result;
            result = FindChamp(Modules.Internal.UppercaseFirst(name));

            if (result == null)
                FindChamp(Modules.Internal.UppercaseFirstMinusAnothers(name));

            return result;
        }

        private Champion FindChamp(string name)
        {
            Champion result;
            result = FindChampByName(name);

            if (result == null)
                result = FindChampByAlias(name);

            return result;
        }

        private Champion FindChampByAlias(string name)
        {
            foreach(Champion champ in champions)
            {
                if (champ.GetAlias() != null)
                {
                    foreach(string alias in champ.GetAlias())
                    {
                        if (alias == name)
                            return champ;
                    }
                }
            }

            return null;
        }

        private Champion FindChampByName(string name)
        {
            foreach(Champion champ in champions)
            {
                if (champ.GetName() == name)
                    return champ;
            }

            return null;
        }
    }
}
