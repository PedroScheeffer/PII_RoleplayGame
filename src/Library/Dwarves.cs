namespace PII_Roleplay
{
    public class Dwarves
    {
        string name;
        int health;
        int defence;
        

        public Dwarves(string name1,int health1,int defence1)
        {
            this.name=name1;
            this.health=health1;
            this.defence=defence1;
        }
  
        public int getdefence()
        {
            return(defence);
        }

        public bool curarse()
        {
            return(health==100);
        }
    }
}

