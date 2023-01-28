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
    public partial class AddNewForm : Form
    {
        public AddNewForm()
        {
            InitializeComponent();
        }

        private void AddNewForm_Move(object sender, EventArgs e)
        {
            SetForm();
        }

        private void AddNewForm_Resize(object sender, EventArgs e)
        {
            SetForm();
        }
        public void SetForm()
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTxt.Text.Trim() == "" || AdressTxt.Text.Trim() == "" || NameTxt.Text.Trim() == "" || AgeTXT.Text.Trim() == "" || CarTypeTxt.Text.Trim() == "" || PicCar.Image==new PictureBox().Image || PicPerson.Image==new PictureBox().Image)
                {
                    MessageBox.Show("Please fill all Blanks");
                    return;
                }
                StreamReader srCheck = new StreamReader("Car'sData.TXT", true);
                string strCheck = srCheck.ReadToEnd();
                srCheck.Close();
                if (strCheck.Contains(IDTxt.Text + ";"))
                {
                    MessageBox.Show("This Car already exists");
                    IDTxt.SelectAll();
                }

                else
                {

                    StreamWriter sw = new StreamWriter("Car'sData.TXT", true);
                    string strCars = IDTxt.Text + ";" + NameTxt.Text + ";" + CarTypeTxt.Text + ";" + AgeTXT.Text + ";" + AdressTxt.Text;
                    sw.WriteLine(strCars);
                    sw.Close();
                    MessageBox.Show("Car's Data Is added successfully");
                    if (!Directory.Exists("img") && !Directory.Exists("imgg"))
                    {
                        Directory.CreateDirectory("img");
                        Directory.CreateDirectory("imgg");
                    }
                    PicCar.Image.Save("img/" + IDTxt.Text);
                    PicPerson.Image.Save("imgg/" + IDTxt.Text);


                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = " ";
                        }

                    }
                    PicCar.Image = new PictureBox().Image;
                    PicPerson.Image = new PictureBox().Image;
                    IDTxt.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPicCar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicCar.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void BtnPerson_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicPerson.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void BtnBackMain_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }


    }
}
