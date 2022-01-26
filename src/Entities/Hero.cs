namespace ProjetoGFT.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public string Name;

        public  int Level;

        public string HeroType;


        public override string ToString()
        {
            return "Herói: " + this.Name + "\n" + "Level: " + this.Level + "\n" + "Hero Type: " + this.HeroType + "\n"; 
        }

        public virtual string Attack()
        {
            return this.Name + " " + "atacou com a sua espada!";
        }
    }
}