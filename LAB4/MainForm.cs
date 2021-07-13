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
    public partial class MainForm : Form
    {

        internal Dict dict;
        internal string mode;
        

        public MainForm()
        {
            InitializeComponent();
            dict = new Dict("");
            
        }
        

        private void AddWord(object sender, EventArgs e)
        {
            AddWord formAddWord = new AddWord(this);
            formAddWord.Owner = this;
            formAddWord.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DeleteCard formDeleteCard = new DeleteCard(this);
            formDeleteCard.Owner = this;
            formDeleteCard.ShowDialog();
        }

        private void buttonSpectate_Click(object sender, EventArgs e)
        {
            SpectCards formSpectCards = new SpectCards(this);
            formSpectCards.Owner = this;
            formSpectCards.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            mode = "s";
            SaveLoadForm SF = new SaveLoadForm(this, "Save");
            SF.Owner = this;
            SF.ShowDialog();
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            mode = "l";
            SaveLoadForm SF = new SaveLoadForm(this, "Load");
            SF.Owner = this;
            SF.ShowDialog();
            
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            Statistics SF = new Statistics(this);
            SF.Owner = this;
            SF.ShowDialog();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Test TF = new Test(this);
            TF.Owner = this;
            TF.ShowDialog();
        }
    }
}
