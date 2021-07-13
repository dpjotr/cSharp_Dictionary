using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    [Serializable]
    public class Dict
    {
        public List<Card> dictionary;

        public string Output { get; set; }


        public Dict() { }
        internal Dict(string o) { dictionary = new List<Card>(); Output = ""; }
        internal void AddCard(Card c)
        {
            bool add = false;
            foreach (var x in dictionary)
            {
                if (x.word == c.word && x.partOfSpeech == c.partOfSpeech)
                {
                    x.AddMeaning(c.meanings.First(), x.partOfSpeech);
                    x.meanings = x.meanings.Distinct().ToList();
                    Output = "This word is alredy in the dictionary, meaning list was updated";
                    add = true;
                }
            }
            if (!add)
            {
                dictionary.Add(c);
                Output = "The word was added succesfully";
                dictionary.Sort();
            }
                
        }

        internal void DeleteCard(string s, string ps)
        {
            int initialSize = dictionary.Count;
            if (dictionary.RemoveAll(item => (item.word == s.ToLower() && item.partOfSpeech == ps)) == 0)
                Output = "The word was not found in the dictionary";
            else
            {
                Output = "The word was deleted succesfully";
                dictionary.Sort();
            }
        }
    }
}
