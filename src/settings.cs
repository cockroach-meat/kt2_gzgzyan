using System;

namespace Gaming {
    static class GameSettings {
        public static int MaxLevel { get; set; }

        public static bool IsLevelValid(int level){
            return level <= MaxLevel;
        }
    }
}