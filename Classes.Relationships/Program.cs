namespace Classes.Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Арагорн", 7);

            Hero anotherHero = new Hero("Наруто", 5);

            Hero thirdHero = new Hero("Алёша Попович", 10, new Sword());

            Weapon sword = new Sword();
            Weapon fireAxe = new FireAxe();

            hero.EquipWeapon(sword);
            Console.WriteLine($"Герой {hero.Name} наносит {hero.Attack()} урона оружием {hero.Weapon}.");
            hero.EquipWeapon(fireAxe);
            Console.WriteLine($"Герой {hero.Name} наносит {hero.Attack()} урона оружием {hero.Weapon}.");
            Console.WriteLine();

            anotherHero.EquipWeapon(sword);
            Console.WriteLine($"Герой {anotherHero.Name} наносит {anotherHero.Attack()} урона оружием {anotherHero.Weapon}.");
            anotherHero.EquipWeapon(fireAxe);
            Console.WriteLine($"Герой {anotherHero.Name} наносит {anotherHero.Attack()} урона оружием {anotherHero.Weapon}.");
            Console.WriteLine();
        }
    }

    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public Weapon Weapon { get; set; } // Агрегация
        public Bag Inventory { get; private set; } // Композиция
        public Hero(string name, int strength)
        {
            Name = name;
            Strength = strength;
            Inventory = new Bag(16);
        }
        public Hero(string name, int strength, Weapon weapon)
        {
            Name = name;
            Strength = strength;
            Inventory = new Bag(16);
        }

        public void EquipWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }

        public double Attack()
        {
            if (Weapon == null)
            {
                Console.WriteLine("Не могу атаковать без оружия!");
                return 0;
            }
            return Strength * Weapon.DoDamage();
        }

        public void GetItem()
        {

        }

        public void DropItem()
        {
            
        }
    }

    class Bag
    {
        public int Capacity { get; set; }

        public Item[] Items { get; }

        private int _count;

        public Bag(int capacity)
        {
            Capacity = capacity;
            _count = 0;
            Items = new Item[Capacity];
        }

        public void AddItem(Item item)
        {
            Items[_count++] = item;
        }

        public Item DropItem()
        {
            return Items[_count--];
        }
    }

    abstract class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    abstract class Weapon : Item
    {
        public virtual double DoDamage()
        {
            return 10;
        }
    }

    class Sword : Weapon
    {
        public override double DoDamage()
        {
            return base.DoDamage() * 5;
        }

        public override string ToString()
        {
            return nameof(Sword);
        }
    }

    class FireAxe : Weapon
    {
        public override double DoDamage()
        {
            return base.DoDamage() * 12;
        }

        public override string ToString()
        {
            return nameof(FireAxe);
        }
    }
}