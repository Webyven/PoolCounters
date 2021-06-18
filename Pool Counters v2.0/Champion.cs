using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    class Champion
    {
        private string name;
        private string tip;
        private string[] cds;
        private int games;
        private int objGames;
        private Image square;
        private Image info;
        private List<string> alias;
        private List<Champion> veryGoodAgainst;
        private List<Champion> goodAgainst;
        private List<Champion> mediumAgainst;

        public Champion()
        {
            veryGoodAgainst = new List<Champion>();
            goodAgainst = new List<Champion>();
            mediumAgainst = new List<Champion>();
            alias = new List<string>();
            games = 0;
            objGames = 0;
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

        public void AddVeryCounter(Champion champ)
        {
            veryGoodAgainst.Add(champ);
        }

        public void AddGoodCounter(Champion champ)
        {
            goodAgainst.Add(champ);
        }

        public void AddMediumCounter(Champion champ)
        {
            mediumAgainst.Add(champ);
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

        public void SetTips(string tip)
        {
            this.tip = tip;
        }

        public string GetTips()
        {
            return this.tip;
        }

        public void SetInfo(Image info)
        {
            this.info = info;
        }

        public Image GetInfo()
        {
            return this.info;
        }

        public void SetCDs(string[] cds)
        {
            this.cds = cds;
        }

        public string[] GetCDs()
        {
            return this.cds;
        }

        public void SetGames(int games)
        {
            this.games = games;
        }

        public void AddGame()
        {
            this.games++;
        }

        public void SubGame()
        {
            this.games--;
        }

        public int GetGames()
        {
            return this.games;
        }

        public void SetObjGames(int games)
        {
            this.objGames = games;
        }

        public int GetObjGames()
        {
            return this.objGames;
        }
    }
}
