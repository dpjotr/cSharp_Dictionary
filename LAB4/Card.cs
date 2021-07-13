using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    [Serializable]
    public class Card: IComparable
    {
        public int CompareTo(object o)
        {
            Card c = o as Card;
            if (c != null)
                return this.word.CompareTo(c.word);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public string word;
        public string partOfSpeech;
        public int learned;
        
       
        public List<string> meanings;

        public Card(string w, string m, string ps) 
        { 
            meanings = new List<String>();
            partOfSpeech = ps;
            word = w.ToLower(); 
            meanings.Add(m.ToLower());
            learned = 0;
           
        }

        public Card()
        {
            meanings = new List<String>();
            partOfSpeech = "";
            word = "";
        }

        public void AddMeaning(string m, string ps) 
        {
            if (meanings.Contains(m.ToLower()) == false && ps==partOfSpeech)
            {
                meanings.Add(m.ToLower());                
            }
           
        }

        public override string ToString()
        {
            string s="";
            foreach (var x in meanings) s += x.ToUpper() + ", ";
            return word.ToUpper() + ", " + partOfSpeech + "- " + s.TrimEnd(new Char[] { ',' , ' '});
        }

    }
}
