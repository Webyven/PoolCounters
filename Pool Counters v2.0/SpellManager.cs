using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    public static class SpellManager
    {
        private static List<Spell> Spells = new List<Spell>();

        public static List<Spell> GetSpells() { return Spells; }
        public static void AddSpell(Spell spell) { Spells.Add(spell); }

        public static Spell FindSpell(string text)
        {
            return Spells.Find(x => x.Name.ToLower() == text.ToLower());
        }

        public static Spell[,] DefaultSpells()
        {
            Spell flash = FindSpell("Flash");

            Spell[,] spells = new Spell[,]
            {
                { flash, FindSpell("Teleport") },
                { flash, FindSpell("Smite") },
                { flash, FindSpell("Ignite") },
                { flash, FindSpell("Exhaust") },
                { flash, FindSpell("Heal") }
            };

            return spells;
        }
    }
}
