using System;
namespace PII_Roleplay
{
    public class Item
    {
        public string name {get; private set;}
        public int armor {get; private set;}
        public int damage {get; private set;}
        
        public string toString(){
            return name;
        }
    }
} 