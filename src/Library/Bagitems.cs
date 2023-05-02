using System.Collections.Generic;
namespace PII_Roleplay
{
    public class Bagitems
    {
        List<object> bag = new List<object>();
        public void addItem(object item){
            bag.Add(item);
        }
        public void removeItem(object item){
            bag.Remove(item);
        }
        public object getItem(string name){
            foreach (var item in bag)
            {
                if(item.ToString() == name){
                    return item;
                }
            }
            System.Console.WriteLine($"The item {name} is not in the bag");
            return null;
        }
    }
}