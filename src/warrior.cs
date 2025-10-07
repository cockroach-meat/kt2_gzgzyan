using System;

namespace Gaming {
    class Warrior : Hero, IPhysicalFighter {
        public override string Name { get; set; }

        int _level;
        public override int Level {
            get {
                return _level;
            }
        }

        string _weapon;

        public Warrior(string name, int level, string weapon){
            Name = name;
            _level = level;
            _weapon = weapon;
        }

        public override void UseAbility(){
            Attack(_weapon);
        }

        public override void LevelUp(){
            if(!GameSettings.IsLevelValid(_level + 1)) throw new ArgumentException();
            _level++;
        }

        public void Attack(string weapon){
            Console.WriteLine($"Воин {Name} атакует с помощью {weapon}");
        }
    }
}