using System.Collections.Generic;
namespace PII_Roleplay
{
    public class Wizard
    {
        string name;
        int health;
        Bagitems bagItems;
        Spellbook spellbook;
        
        public Wizard(string name,int health)
        {
            this.name = name;
            this.health = health;
        }
        public static void Attack()
        {

        }
    }
}