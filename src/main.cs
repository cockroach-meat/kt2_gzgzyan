using System;

namespace Gaming {
    class Program {
        public static void Main(){
            GameSettings.MaxLevel = 100;

            var manager = new HeroManager<Hero>(
                new Hero[]{
                    new Wizard("Евгений", 67, "Огненный шар"),
                    new Paladin("Андрей", 54, "Сосисочный бум", "АК-47")
                }
            );

            manager.AddHero(new Warrior("Петрович", 100, "Монтировка"));

            manager.DisplayHeroes();
            Console.WriteLine("\n=====\n");

            manager.UseHeroAbility("Андрей");
            manager.LevelUpHero("Евгений");
            Console.WriteLine("\n=====\n");

            manager.DisplayHeroes();
            Console.WriteLine("\n=====\n");

            try{
                manager.LevelUpHero("Петрович");
            }catch(Exception ex){
                Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
        }
    }
}