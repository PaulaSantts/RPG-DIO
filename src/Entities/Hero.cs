namespace RPG-DIO.SRC.Entities
{
    public class Hero
    {
        public string name;
        public int level;
        public string heroType;
        public string skill;        
        public int strength;
        public int dexterity;
        public int intelligence;
        public int constitution;
        public int hp;
        public int mp;

        public Hero(string name, int level, string heroType, string skill, int strength, int dexterity, int intelligence, int constitution, int hp, int mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.skill = skill;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;
            this.hp = hp;
            this.mp = mp;
        }

        public Hero()
        {

        }
        public string description()
        {
            return this.name + " " + this.heroType + " " + "Lvl: " + this.level;        
        }

           public string attack()
        {
            return this.name + " " + "attacked with" + " " + this.skill;
        }
    }
}