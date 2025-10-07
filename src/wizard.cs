using System;

namespace Gaming {
    class Wizard : Hero, IMagicUser {
        public override string Name { get; set; }

        int _level;
        public override int Level {
            get {
                return _level;
            }
        }

        string _spellName;

        public Wizard(string name, int level, string spellName){
            Name = name;
            _level = level;
            _spellName = spellName;
        }

        public override void UseAbility(){
            CastSpell(_spellName);
        }

        public override void LevelUp(){
            if(!GameSettings.IsLevelValid(_level + 1)) throw new ArgumentException();
            _level++;
        }

        public void CastSpell(string spellName){
            Console.WriteLine($"Маг {Name} кастует {spellName}");
        }
    }
}