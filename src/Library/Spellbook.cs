using System.Collections.Generic;

namespace PII_Roleplay
{
    public class Spellbook
    {
        List<Spell> spellbook = new List<Spell>();
        public void addSpell(Spell spell){
            spellbook.Add(spell);
        }
        public void removeSpell(Spell spell){
            spellbook.Remove(spell);
        }
        public Spell getSpell(string name){
            foreach (Spell spell in spellbook)
            {
                if(spell.ToString() == name){
                    return spell;
                }
            }
            System.Console.WriteLine($"The spell {name} is not in the spellbook");
            return null;
        }
    }
    
}