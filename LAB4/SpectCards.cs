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
    public partial class SpectCards : Form
    {
        MainForm mainForm;
        int positionInList;
        

        public SpectCards()
        {
            InitializeComponent();
        }

        public SpectCards(MainForm mf)
        {
            InitializeComponent();
            DoubleBuffered = true;
            mainForm = mf;
            int positionInList = 0;
            ShowCard();
            
        }

        internal void ShowCard()
        {
            if (mainForm.dict.dictionary.Count > 0)
                richTextBoxOutputScreen.Text = mainForm.dict.dictionary.ToArray()[positionInList].ToString();
            else
                richTextBoxOutputScreen.Text = "The dictionary is empty";
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

            positionInList = --positionInList >= 0 ? positionInList : mainForm.dict.dictionary.Count - 1;
            ShowCard();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            positionInList = ++positionInList < mainForm.dict.dictionary.Count ? positionInList : 0;
            ShowCard();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int position = 0;
            foreach (var x in mainForm.dict.dictionary)
            {
                if (textBoxSearch.Text.ToLower() != mainForm.dict.dictionary.ToArray()[position].word) ++position;
                else positionInList = position;
            }
            if (position >= mainForm.dict.dictionary.Count)
                MessageBox.Show("The word "+ textBoxSearch.Text + " was not found in the dictionary", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else richTextBoxOutputScreen.Text = mainForm.dict.dictionary.ToArray()[positionInList].ToString();
        }
    }
}
