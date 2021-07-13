using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB4
{
    public partial class SaveLoadForm : Form
    {
        MainForm mainForm;
        public SaveLoadForm(MainForm mf, string mode)
        {
            InitializeComponent();
            labelSaveInfo.Text = mode;
            DoubleBuffered = true;
            mainForm = mf;
        }

        private void buttonXMLSave_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Dict));

            if (mainForm.mode == "s")
            {
                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("dictionary.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, mainForm.dict);
                    labelSaveInfo.Text = "Saved to xml";
                }
            }
            if (mainForm.mode == "l")
            {
                using (FileStream fs = new FileStream("dictionary.xml", FileMode.OpenOrCreate))
                {
                   mainForm.dict = (Dict)formatter.Deserialize(fs);
                   labelSaveInfo.Text = "Dictionary was loaded";
                }

                

            }
        }

        private void buttonBINSave_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            if (mainForm.mode == "s")
            {
                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("dictionary.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, mainForm.dict);
                    labelSaveInfo.Text = "Saved to binary file";
                }
            }
            if (mainForm.mode == "l")
            {
                using (FileStream fs = new FileStream("dictionary.dat", FileMode.OpenOrCreate))
                {
                    mainForm.dict = (Dict)formatter.Deserialize(fs);
                    labelSaveInfo.Text = "Dictionary was loaded";
                }



            }
        }
    }
}
