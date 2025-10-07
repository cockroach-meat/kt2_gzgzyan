using System;

namespace Gaming {
    abstract class Hero {
        public abstract string Name { get; set; }
        public abstract int Level { get; }

        public abstract void UseAbility();
        public abstract void LevelUp();
    }

    interface IMagicUser {
        public void CastSpell(string spellName);
    }

    interface IPhysicalFighter {
        public void Attack(string weapon);
    }
}