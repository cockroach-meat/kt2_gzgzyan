using System;

namespace Gaming {
    class Paladin : Hero, IMagicUser, IPhysicalFighter {
        public override string Name { get; set; }

        int _level;
        public override int Level {
            get {
                return _level;
            }
        }

        string _spellName;
        string _weapon;

        public Paladin(string name, int level, string spellName, string weapon){
            Name = name;
            _level = level;
            _weapon = weapon;
            _spellName = spellName;
        }

        public override void UseAbility(){
            CastSpell(_spellName);
            Attack(_weapon);
        }

        public override void LevelUp(){
            if(!GameSettings.IsLevelValid(_level + 1)) throw new ArgumentException();
            _level++;
        }

        public void Attack(string weapon){
            Console.WriteLine($"Паладин {Name} атакует с помощью {weapon}");
        }

        public void CastSpell(string spellName){
            Console.WriteLine($"Паладин {Name} кастует {spellName}");
        }
    }
}