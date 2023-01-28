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

namespace CarTypes
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (IDTxt.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("Car'sData.TXT", true);
                string line = "";
                bool found = false;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] arrLine = line.Split(';');
                        if (arrLine[0] == IDTxt.Text)
                        {
                         
                            IDTxt.Text = arrLine[0];
                            NameTxt.Text = arrLine[1];
                            CarTypeTxt.Text = arrLine[2];
                            AgeTXT.Text = arrLine[3];
                            AdressTxt.Text = arrLine[4];
                            string myPath = "img/" + IDTxt.Text;
                            string myPath1 = "imgg/" + IDTxt.Text;
                            if (File.Exists(myPath) && File.Exists(myPath1))
                            {
                                PicCar.Image = Image.FromFile(myPath);
                                PicPerson.Image = Image.FromFile(myPath1);
                            }
                            found = true;
                         
                            break;
                        }

                    }
                } while (line != null);
                sr.Close();
                if (!found)
                {
                    MessageBox.Show("not found");
                    IDTxt.Focus();
                    IDTxt.Text = "";
                    NameTxt.Text = "";
                    CarTypeTxt.Text = "";
                    AgeTXT.Text = "";
                    AdressTxt.Text = "";
                    PicCar.Image = new PictureBox().Image;
                    PicPerson.Image = new PictureBox().Image;
                }

            }
        }

        private void BtnBackMain_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void FindForm_Move(object sender, EventArgs e)
        {
            SetForm();
        }

        private void FindForm_Resize(object sender, EventArgs e)
        {
            SetForm();
        }
        public void SetForm()
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);

        }
    }
}
