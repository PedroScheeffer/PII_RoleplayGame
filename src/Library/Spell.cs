namespace PII_Roleplay
{
    public class Spell
    {
        public string name {get; private set;}
        public string descripcion{get; private set;}
        public string value{get; private set;}
        
        public void useSpell(){
            
        }
        public string toString(){
            return name;
        }
    }
} 