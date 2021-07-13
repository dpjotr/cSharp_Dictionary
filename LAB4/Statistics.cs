using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB4
{
    public partial class Statistics : Form
    {

        MainForm mainForm;

        public Statistics(MainForm mf)
        {
            mainForm = mf;
            InitializeComponent();
            label1.Text = "Total amount of words in the dictionary______________" + mainForm.dict.dictionary.Count;
            label2.Text = "Verbs________________________________________" + mainForm.dict.dictionary.Where(x=>x.partOfSpeech=="verb").ToList().Count;
            label3.Text = "Adjectives____________________________________" + mainForm.dict.dictionary.Where(x => x.partOfSpeech == "adjective").ToList().Count;
            label4.Text = "Nouns_______________________________________" + mainForm.dict.dictionary.Where(x => x.partOfSpeech == "noun").ToList().Count;
            label5.Text = "Pronouns_____________________________________" + mainForm.dict.dictionary.Where(x => x.partOfSpeech == "pronoun").ToList().Count;
            label6.Text = "Adverbs______________________________________" + mainForm.dict.dictionary.Where(x => x.partOfSpeech == "adverb").ToList().Count;
            label7.Text = "Average length of words_________________________" + Math.Round(mainForm.dict.dictionary.Count<1?0:mainForm.dict.dictionary.Select(x=>x.word.Length).ToList().Average(), 2);
        }

    }
}
