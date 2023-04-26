namespace PII_Roleplay
{
    public class Wisardz
    {
        string name;
        int health;
        int defence;
        int mana;
       

        
        public Wisardz(string name1,int health1,int defence1,int mana)
        {
            this.name=name1;
            this.health=health1;
            this.defence=defence1;
            this.mana=mana;
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