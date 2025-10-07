using System;
using System.Collections.Generic;

namespace Gaming {
    class HeroManager<T> where T : Hero {
        Dictionary<string, Hero> _heroes = new Dictionary<string, Hero>();

        public HeroManager(IEnumerable<T> heroes){
            foreach(var hero in heroes){
                _heroes.Add(hero.Name, hero);
            }
        }

        public void AddHero(T hero){
            _heroes.Add(hero.Name, hero);
        }

        public void UseHeroAbility(string name){
            if(!_heroes.ContainsKey(name)){
                throw new KeyNotFoundException("No hero found");
            }

            _heroes[name].UseAbility();
        }

        public void LevelUpHero(string name){
            if(!_heroes.ContainsKey(name)){
                throw new KeyNotFoundException("No hero found");
            }

            _heroes[name].LevelUp();
        }

        public void DisplayHeroes(){
            foreach(var kvp in _heroes){
                Console.WriteLine($"{kvp.Value.GetType().Name} (имя: {kvp.Key}, уровень: {kvp.Value.Level})");
            }
        }
    }
}