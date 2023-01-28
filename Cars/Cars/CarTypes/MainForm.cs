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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            SetForm();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            SetForm();
        }
        public void SetForm()
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddNewForm a = new AddNewForm();
            a.Show();
            this.Hide();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            FindForm f = new FindForm();
            f.Show();
            this.Hide();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            Form frmshow = new Form();
            frmshow.StartPosition = FormStartPosition.CenterScreen;
            frmshow.Font = this.Font;
            frmshow.Icon = this.Icon;
            frmshow.Size = new Size(1032, 429);
            frmshow.Text = "All car's data";
            frmshow.Height += 300;
            int mytop = 10;
            frmshow.AutoScroll = true;
            frmshow.BackColor = this.BackColor;

            try
            {
                StreamReader sr = new StreamReader("Car'sData.TXT", true);
                string line = "";
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        TextBox txt = new TextBox();
                        PictureBox pic1 = new PictureBox();
                        PictureBox pic2 = new PictureBox();

                        txt.Width = 300;
                        txt.Top = mytop;
                        txt.Text = line;

                        pic1.BorderStyle = BorderStyle.FixedSingle;
                        pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic1.Top = mytop;
                        pic1.Left = 305;
                        pic1.Size = new Size(150, 150);

                        pic2.BorderStyle = BorderStyle.FixedSingle;
                        pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic2.Top = mytop;
                        pic2.Left = 470;
                        pic2.Size = new Size(150, 150);

                        string mypath1 = "img/" + line.Split(';')[0];
                        string mypath2 = "imgg/" + line.Split(';')[0];
                        if (File.Exists(mypath1) && File.Exists(mypath2))
                        {
                            pic1.Image = Image.FromFile(mypath1);
                            pic2.Image = Image.FromFile(mypath2);
                        }

                        frmshow.Controls.Add(txt);
                        frmshow.Controls.Add(pic1);
                        frmshow.Controls.Add(pic2);
                        mytop += 155;
                    }
                } while (line != null);
                sr.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmshow.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2.Text = DateTime.Now.ToString("h:mm:ss tt");
            LblDate.Text = DateTime.Now.ToString("MM-dd-yyyy");

        }
    }
}
