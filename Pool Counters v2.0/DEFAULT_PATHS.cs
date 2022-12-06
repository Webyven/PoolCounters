using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public static class DEFAULT_PATHS
    {
        public static string RESOURCES = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
        public static string RESOURCES_CHAMPIONS = Path.Combine(RESOURCES, "Champions");
        public static string RESOURCES_POSITIONS = Path.Combine(RESOURCES, "Positions");
        public static string RESOURCES_BUILDS = Path.Combine(RESOURCES, "Builds");
        public const string countersFile = "counters.pc";
    }

    public static class DirectoriesManager
    {
        public static void Check()
        {
            Type type = typeof(DEFAULT_PATHS);

            foreach (FieldInfo info in type.GetFields())
            {
                if (info.Name.Contains("File"))
                    continue;

                if (!Directory.Exists(info.GetValue(null).ToString()))
                    Directory.CreateDirectory(info.GetValue(null).ToString());
            }
        }
    }

    public static class AutoCompleteSources
    {
        public static AutoCompleteStringCollection Champions 
        { 
            get
            {
                AutoCompleteStringCollection champCollection = new AutoCompleteStringCollection();
                foreach (string champion in ChampionManager.GetChampionsNames())
                    champCollection.Add(champion);

                return champCollection;
            } 
        }
    }
}
