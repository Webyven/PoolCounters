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
        public int Cooldown { get; internal set; }

        public Spell() { }

        public Spell(string name, int cooldown)
        {
            Name = name;
            Cooldown = cooldown;
        }

        public void SetIcon(Image icon) { this.Icon = icon; }

        public void SetBaseCooldown(int cooldown)
        {
            this.Cooldown = cooldown;
        }

        public int GetIonianCooldown()
        {
            return (this.Cooldown * 100 / 112);
        }

        public int GetCosmicInsightCooldown()
        {
            return (this.Cooldown * 100 / 118);
        }

        public int GetMaxReducedCooldown()
        {
            return (this.Cooldown * 100 / 130);
        }

        public int GetCooldown(bool Jonias, bool Cosmic)
        {
            if (Jonias && Cosmic)
                return GetMaxReducedCooldown();
            else if (Jonias)
                return GetIonianCooldown();
            else if (Cosmic)
                return GetCosmicInsightCooldown();
            else
                return Cooldown;
        }

        public static Spell UpgradedTeleport()
        {
            Spell tp = new Spell("Teleport", 240);
            tp.SetIcon(Properties.Resources.UpgradedTeleport);

            return tp;
        }
    }
}
