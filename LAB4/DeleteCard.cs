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
    public partial class DeleteCard : Form
    {

        MainForm mainForm;

        public DeleteCard()
        {
            InitializeComponent();
        }

        public DeleteCard(MainForm mf)
        {
            InitializeComponent();
            DoubleBuffered = true;
            mainForm = mf;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxPartOfSpeech.Text.Length == 0)
            {
                infoLabel.Text = "Specify part of speech!";
                MessageBox.Show("Specify part of speech!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mainForm.dict.DeleteCard(textBoxDelete.Text, comboBoxPartOfSpeech.Text);
            infoLabel.Text = mainForm.dict.Output;
        }
    }
}
