namespace CarTypes
{
    partial class MainForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Black;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.Location = new System.Drawing.Point(16, 72);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(124, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add New";
            this.toolTip1.SetToolTip(this.BtnAdd, "To add a new car");
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.Black;
            this.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFind.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFind.Location = new System.Drawing.Point(121, 134);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(124, 35);
            this.BtnFind.TabIndex = 1;
            this.BtnFind.Text = "Find";
            this.toolTip1.SetToolTip(this.BtnFind, "To find a car");
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.Black;
            this.BtnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowAll.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnShowAll.Location = new System.Drawing.Point(244, 191);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(124, 35);
            this.BtnShowAll.TabIndex = 2;
            this.BtnShowAll.Text = "ShowAll";
            this.toolTip1.SetToolTip(this.BtnShowAll, "To show all car\'s data");
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Black;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExit.Location = new System.Drawing.Point(388, 257);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 35);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.BtnExit, "To exit Program");
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.BackColor = System.Drawing.Color.Black;
            this.WelcomeLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WelcomeLbl.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeLbl.Location = new System.Drawing.Point(173, 9);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(180, 42);
            this.WelcomeLbl.TabIndex = 4;
            this.WelcomeLbl.Text = "Welcome";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.BackColor = System.Drawing.Color.White;
            this.LblDateTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateTime.Location = new System.Drawing.Point(0, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(0, 18);
            this.LblDateTime.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(384, 9);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(0, 23);
            this.LblDate.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(524, 320);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDateTime);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
    }
}

