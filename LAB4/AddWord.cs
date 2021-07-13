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
    public partial class AddWord : Form
    {
        MainForm mainForm;

        public AddWord()
        {
            InitializeComponent();
        }

        public AddWord(MainForm mf)
        {
            InitializeComponent();
            DoubleBuffered = true;
            mainForm = mf;
        }
               
        private void buttonAddToDictionary_Click(object sender, EventArgs e)
        {
            if (comboBoxPartOfSpeech.Text.Length == 0)
            {
                MessageBox.Show("Specify part of speech!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                infoLabel.Text = "Specify part of speech!";

                return;
            }
            Card tempCard = new Card(textBoxNewWord.Text, textBoxMeanings.Text, comboBoxPartOfSpeech.Text);
            mainForm.dict.AddCard(tempCard);
            infoLabel.Text = mainForm.dict.Output;

        }


    }
}
