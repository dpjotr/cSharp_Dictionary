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
    public partial class Test : Form
    {
        int positionInList;
        List<Card> wordsToLearn;
        public Test()
        {
            InitializeComponent();
        }

        MainForm mainForm;
        public Test(MainForm mf)
        {
            mainForm = mf;
            InitializeComponent();
            DoubleBuffered = true;
            wordsToLearn = mainForm.dict.dictionary.Where(x => x.learned < 2).ToList();
            positionInList = 0;
            ShowCard();           
            
        }

        internal void ShowCard()
        {
                            
            if (wordsToLearn.Count > 0)
                label1.Text = wordsToLearn.ToArray()[positionInList].word.ToUpper()+", "
                                                        + wordsToLearn.ToArray()[positionInList].partOfSpeech;
            else
                label1.Text = "There are no new words";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if ( wordsToLearn[positionInList].meanings.Contains(textBox1.Text.ToLower()))
            {
                    ++wordsToLearn[positionInList].learned;
                    if (wordsToLearn.ToArray()[positionInList].learned<2)
                         MessageBox.Show("Correct!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    else
                        MessageBox.Show("Correct!\nYou have learned word "
                                                    +wordsToLearn.ToArray()[positionInList].word.ToUpper(),
                                                       "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wordsToLearn =wordsToLearn.Where(x => x.learned < 2).ToList();
                positionInList = ++positionInList < wordsToLearn.Count ? positionInList : 0;
                ShowCard();
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Not correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                --wordsToLearn.ToArray()[positionInList].learned;
                positionInList = ++positionInList < wordsToLearn.Count ? positionInList : 0;
                ShowCard();
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            positionInList = ++positionInList < wordsToLearn.Count ? positionInList : 0;
            ShowCard();
        }
    }
}
