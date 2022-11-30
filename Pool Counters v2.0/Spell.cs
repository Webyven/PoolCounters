using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    public class Spell
    {
        public string Name { get; set; }
        public Image Icon { get; set; }
        public TimeSpan DefaultCooldown { get; internal set; }
        public int[] Cooldowns = new int[4];

        public Spell() { }

        public Spell(string name, Image icon)
        {
            Name = name;
            Icon = icon;
            DefaultCooldown = new TimeSpan(0, 5, 0);
        }

        public void SetBaseCooldown(int cooldown)
        {
            this.Cooldowns[0] = cooldown;
        }

        public void SetIonianCooldown(int cooldown)
        {
            this.Cooldowns[1] = cooldown;
        }

        public void SetCosmicInsightCooldown(int cooldown)
        {
            this.Cooldowns[2] = cooldown;
        }

        public void SetFullCooldown(int cooldown)
        {
            this.Cooldowns[3] = cooldown;
        }
    }
}
