using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    public class Champion
    {
        private string name;
        private Image square;
        private Image info;
        private List<string> alias;

        private List<Champion> allCounters;
        public List<Champion> veryGoodAgainst { get; private set; }
        public List<Champion> goodAgainst { get; private set; }
        public List<Champion> mediumAgainst { get; private set; }


        public Champion()
        {
            allCounters = new List<Champion>();
            veryGoodAgainst = new List<Champion>();
            goodAgainst = new List<Champion>();
            mediumAgainst = new List<Champion>();
            alias = new List<string>();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetSquare(Image square)
        {
            this.square = square;
        }

        public Image GetSquare()
        {
            return this.square;
        }

        public void AddAlias(string alias)
        {
            this.alias.Add(alias);
        }

        public List<string> GetAlias()
        {
            return this.alias;
        }

        public void AddCounter(Champion champion)
        {
            allCounters.Add(champion);
        }

        private void ClearCounters()
        {
            this.veryGoodAgainst.Clear();
            this.goodAgainst.Clear();
            this.mediumAgainst.Clear();
        }

        public void RedistributeCounters()
        {
            ClearCounters();

            for(int i = 0; i < allCounters.Count; i++)
            {
                if (i < allCounters.Count / 3)
                    this.veryGoodAgainst.Add(allCounters[i]);

                else if (i < (allCounters.Count * 2) / 3)
                    this.goodAgainst.Add(allCounters[i]);

                else
                    this.mediumAgainst.Add(allCounters[i]);
            }

            allCounters.Clear();
        }

        public List<Champion> GetCounters()
        {
            return allCounters;
        }

        public bool Counters(Champion champ, out int amount)
        {
            if (veryGoodAgainst.Contains(champ))
                amount = 3;

            else if (goodAgainst.Contains(champ))
                amount = 2;

            else if (mediumAgainst.Contains(champ))
                amount = 1;
            else
            {
                amount = 0;
                return false;
            }
                
            return true;
        }

        public void SetInfo(Image info)
        {
            this.info = info;
        }

        public Image GetInfo()
        {
            return this.info;
        }
    }
}
