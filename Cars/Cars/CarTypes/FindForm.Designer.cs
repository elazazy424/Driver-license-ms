namespace CarTypes
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblID = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnPerson = new System.Windows.Forms.Button();
            this.btnPicCar = new System.Windows.Forms.Button();
            this.AdressTxt = new System.Windows.Forms.TextBox();
            this.AgeTXT = new System.Windows.Forms.TextBox();
            this.CarTypeTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblAdress = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblCarType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.PicPerson = new System.Windows.Forms.PictureBox();
            this.PicCar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBackMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCar)).BeginInit();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.White;
            this.LblID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Black;
            this.LblID.Location = new System.Drawing.Point(320, 6);
            this.LblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(82, 36);
            this.LblID.TabIndex = 35;
            this.LblID.Text = "ID : ";
            // 
            // IDTxt
            // 
            this.IDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTxt.Location = new System.Drawing.Point(438, 10);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(159, 32);
            this.IDTxt.TabIndex = 34;
            this.toolTip1.SetToolTip(this.IDTxt, "Enter Your ID for search");
            // 
            // BtnPerson
            // 
            this.BtnPerson.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPerson.Location = new System.Drawing.Point(756, 333);
            this.BtnPerson.Name = "BtnPerson";
            this.BtnPerson.Size = new System.Drawing.Size(212, 43);
            this.BtnPerson.TabIndex = 52;
            this.BtnPerson.Text = "Person\'s Photo";
            this.toolTip1.SetToolTip(this.BtnPerson, "Person\'s photo");
            this.BtnPerson.UseVisualStyleBackColor = false;
            // 
            // btnPicCar
            // 
            this.btnPicCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPicCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPicCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPicCar.Location = new System.Drawing.Point(520, 333);
            this.btnPicCar.Name = "btnPicCar";
            this.btnPicCar.Size = new System.Drawing.Size(216, 43);
            this.btnPicCar.TabIndex = 51;
            this.btnPicCar.Text = "Car\'s photo";
            this.toolTip1.SetToolTip(this.btnPicCar, "Car\'s photo");
            this.btnPicCar.UseVisualStyleBackColor = false;
            // 
            // AdressTxt
            // 
            this.AdressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTxt.Location = new System.Drawing.Point(146, 269);
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.Size = new System.Drawing.Size(353, 32);
            this.AdressTxt.TabIndex = 43;
            this.toolTip1.SetToolTip(this.AdressTxt, "Enter your adress");
            // 
            // AgeTXT
            // 
            this.AgeTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTXT.Location = new System.Drawing.Point(146, 221);
            this.AgeTXT.Name = "AgeTXT";
            this.AgeTXT.Size = new System.Drawing.Size(353, 32);
            this.AgeTXT.TabIndex = 42;
            this.toolTip1.SetToolTip(this.AgeTXT, "Enter your age");
            // 
            // CarTypeTxt
            // 
            this.CarTypeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarTypeTxt.Location = new System.Drawing.Point(146, 175);
            this.CarTypeTxt.Name = "CarTypeTxt";
            this.CarTypeTxt.Size = new System.Drawing.Size(353, 32);
            this.CarTypeTxt.TabIndex = 41;
            this.toolTip1.SetToolTip(this.CarTypeTxt, "Enter your car type");
            // 
            // NameTxt
            // 
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Location = new System.Drawing.Point(146, 131);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(353, 32);
            this.NameTxt.TabIndex = 40;
            this.toolTip1.SetToolTip(this.NameTxt, "Enter your name");
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Black;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(419, 57);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(128, 29);
            this.BtnSearch.TabIndex = 36;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblAdress
            // 
            this.LblAdress.AutoSize = true;
            this.LblAdress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblAdress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblAdress.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdress.Location = new System.Drawing.Point(-132, 275);
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(145, 36);
            this.LblAdress.TabIndex = 50;
            this.LblAdress.Text = "Adress : ";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblAge.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.Location = new System.Drawing.Point(-98, 227);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(102, 36);
            this.LblAge.TabIndex = 49;
            this.LblAge.Text = "Age : ";
            // 
            // LblCarType
            // 
            this.LblCarType.AutoSize = true;
            this.LblCarType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblCarType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblCarType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarType.Location = new System.Drawing.Point(-158, 179);
            this.LblCarType.Name = "LblCarType";
            this.LblCarType.Size = new System.Drawing.Size(176, 36);
            this.LblCarType.TabIndex = 48;
            this.LblCarType.Text = "Car Type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-83, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID : ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(-123, 137);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(132, 36);
            this.LblName.TabIndex = 46;
            this.LblName.Text = "Name : ";
            // 
            // PicPerson
            // 
            this.PicPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicPerson.Location = new System.Drawing.Point(756, 103);
            this.PicPerson.Name = "PicPerson";
            this.PicPerson.Size = new System.Drawing.Size(212, 224);
            this.PicPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPerson.TabIndex = 45;
            this.PicPerson.TabStop = false;
            // 
            // PicCar
            // 
            this.PicCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCar.Location = new System.Drawing.Point(520, 103);
            this.PicCar.Name = "PicCar";
            this.PicCar.Size = new System.Drawing.Size(212, 224);
            this.PicCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCar.TabIndex = 44;
            this.PicCar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 36);
            this.label2.TabIndex = 57;
            this.label2.Text = "Adress : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 56;
            this.label3.Text = "Age : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Car Type : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 36);
            this.label6.TabIndex = 53;
            this.label6.Text = "Name : ";
            // 
            // BtnBackMain
            // 
            this.BtnBackMain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBackMain.Location = new System.Drawing.Point(8, 379);
            this.BtnBackMain.Name = "BtnBackMain";
            this.BtnBackMain.Size = new System.Drawing.Size(157, 34);
            this.BtnBackMain.TabIndex = 58;
            this.BtnBackMain.Text = "Back To Main";
            this.BtnBackMain.UseVisualStyleBackColor = false;
            this.BtnBackMain.Click += new System.EventHandler(this.BtnBackMain_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 416);
            this.Controls.Add(this.BtnBackMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnPerson);
            this.Controls.Add(this.btnPicCar);
            this.Controls.Add(this.LblAdress);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblCarType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.PicPerson);
            this.Controls.Add(this.PicCar);
            this.Controls.Add(this.AdressTxt);
            this.Controls.Add(this.AgeTXT);
            this.Controls.Add(this.CarTypeTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.IDTxt);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindForm";
            this.Move += new System.EventHandler(this.FindForm_Move);
            this.Resize += new System.EventHandler(this.FindForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PicPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnPerson;
        private System.Windows.Forms.Button btnPicCar;
        private System.Windows.Forms.Label LblAdress;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblCarType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox PicPerson;
        private System.Windows.Forms.PictureBox PicCar;
        private System.Windows.Forms.TextBox AdressTxt;
        private System.Windows.Forms.TextBox AgeTXT;
        private System.Windows.Forms.TextBox CarTypeTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBackMain;
    }
}