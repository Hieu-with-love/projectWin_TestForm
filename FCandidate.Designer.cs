﻿namespace Test_Form_Project
{
    partial class frmInfoCand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoCand));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.ptbLink = new System.Windows.Forms.PictureBox();
            this.ptbHouse = new System.Windows.Forms.PictureBox();
            this.ptbEmail = new System.Windows.Forms.PictureBox();
            this.ptbTel = new System.Windows.Forms.PictureBox();
            this.ptbBirthday = new System.Windows.Forms.PictureBox();
            this.ptbPerson = new System.Windows.Forms.PictureBox();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.txtTitleAndAward = new System.Windows.Forms.TextBox();
            this.txtCertificate = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.txtDecription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerson)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.ptbPerson);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 113);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtDecription);
            this.panel7.Location = new System.Drawing.Point(425, 319);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(545, 422);
            this.panel7.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 13);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(520, 34);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJob.Location = new System.Drawing.Point(230, 65);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.ReadOnly = true;
            this.txtJob.Size = new System.Drawing.Size(520, 34);
            this.txtJob.TabIndex = 2;
            this.txtJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.txtHouse);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(this.ptbLink);
            this.groupBox1.Controls.Add(this.ptbHouse);
            this.groupBox1.Controls.Add(this.ptbEmail);
            this.groupBox1.Controls.Add(this.ptbTel);
            this.groupBox1.Controls.Add(this.ptbBirthday);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSkill);
            this.groupBox2.Location = new System.Drawing.Point(18, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 158);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CÁC KỸ NĂNG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTitleAndAward);
            this.groupBox3.Location = new System.Drawing.Point(15, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 119);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH HIỆU VÀ GIẢI THƯỞNG";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCertificate);
            this.groupBox4.Location = new System.Drawing.Point(15, 622);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 119);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHỨNG CHỈ";
            // 
            // txtBirthday
            // 
            this.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthday.Location = new System.Drawing.Point(57, 21);
            this.txtBirthday.Multiline = true;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ReadOnly = true;
            this.txtBirthday.Size = new System.Drawing.Size(344, 27);
            this.txtBirthday.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(57, 56);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(344, 27);
            this.txtTel.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(57, 90);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(344, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtHouse
            // 
            this.txtHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouse.Location = new System.Drawing.Point(57, 121);
            this.txtHouse.Multiline = true;
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.ReadOnly = true;
            this.txtHouse.Size = new System.Drawing.Size(344, 27);
            this.txtHouse.TabIndex = 8;
            // 
            // txtLink
            // 
            this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLink.Location = new System.Drawing.Point(57, 154);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(344, 27);
            this.txtLink.TabIndex = 9;
            // 
            // ptbLink
            // 
            this.ptbLink.Image = global::Test_Form_Project.Properties.Resources.Natural_Link_icon;
            this.ptbLink.Location = new System.Drawing.Point(6, 155);
            this.ptbLink.Name = "ptbLink";
            this.ptbLink.Size = new System.Drawing.Size(32, 28);
            this.ptbLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLink.TabIndex = 4;
            this.ptbLink.TabStop = false;
            // 
            // ptbHouse
            // 
            this.ptbHouse.Image = global::Test_Form_Project.Properties.Resources.Actions_home_icon;
            this.ptbHouse.Location = new System.Drawing.Point(6, 121);
            this.ptbHouse.Name = "ptbHouse";
            this.ptbHouse.Size = new System.Drawing.Size(32, 28);
            this.ptbHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHouse.TabIndex = 3;
            this.ptbHouse.TabStop = false;
            // 
            // ptbEmail
            // 
            this.ptbEmail.Image = global::Test_Form_Project.Properties.Resources.email_icon;
            this.ptbEmail.Location = new System.Drawing.Point(6, 89);
            this.ptbEmail.Name = "ptbEmail";
            this.ptbEmail.Size = new System.Drawing.Size(32, 28);
            this.ptbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEmail.TabIndex = 2;
            this.ptbEmail.TabStop = false;
            // 
            // ptbTel
            // 
            this.ptbTel.Image = global::Test_Form_Project.Properties.Resources.phone_icon;
            this.ptbTel.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbTel.InitialImage")));
            this.ptbTel.Location = new System.Drawing.Point(6, 55);
            this.ptbTel.Name = "ptbTel";
            this.ptbTel.Size = new System.Drawing.Size(32, 28);
            this.ptbTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTel.TabIndex = 1;
            this.ptbTel.TabStop = false;
            // 
            // ptbBirthday
            // 
            this.ptbBirthday.Image = global::Test_Form_Project.Properties.Resources.calendar_icon;
            this.ptbBirthday.Location = new System.Drawing.Point(6, 21);
            this.ptbBirthday.Name = "ptbBirthday";
            this.ptbBirthday.Size = new System.Drawing.Size(32, 28);
            this.ptbBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBirthday.TabIndex = 0;
            this.ptbBirthday.TabStop = false;
            // 
            // ptbPerson
            // 
            this.ptbPerson.Image = global::Test_Form_Project.Properties.Resources._1144760;
            this.ptbPerson.Location = new System.Drawing.Point(3, 3);
            this.ptbPerson.Name = "ptbPerson";
            this.ptbPerson.Size = new System.Drawing.Size(125, 107);
            this.ptbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPerson.TabIndex = 0;
            this.ptbPerson.TabStop = false;
            // 
            // txtSkill
            // 
            this.txtSkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkill.Location = new System.Drawing.Point(6, 21);
            this.txtSkill.Multiline = true;
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.ReadOnly = true;
            this.txtSkill.Size = new System.Drawing.Size(389, 131);
            this.txtSkill.TabIndex = 10;
            // 
            // txtTitleAndAward
            // 
            this.txtTitleAndAward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitleAndAward.Location = new System.Drawing.Point(6, 21);
            this.txtTitleAndAward.Multiline = true;
            this.txtTitleAndAward.Name = "txtTitleAndAward";
            this.txtTitleAndAward.ReadOnly = true;
            this.txtTitleAndAward.Size = new System.Drawing.Size(389, 92);
            this.txtTitleAndAward.TabIndex = 11;
            // 
            // txtCertificate
            // 
            this.txtCertificate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCertificate.Location = new System.Drawing.Point(9, 21);
            this.txtCertificate.Multiline = true;
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.ReadOnly = true;
            this.txtCertificate.Size = new System.Drawing.Size(386, 92);
            this.txtCertificate.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtGoal);
            this.groupBox5.Location = new System.Drawing.Point(425, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(545, 181);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MỤC TIÊU NGHỀ NGHIỆP";
            // 
            // txtGoal
            // 
            this.txtGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoal.Location = new System.Drawing.Point(6, 17);
            this.txtGoal.Multiline = true;
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.ReadOnly = true;
            this.txtGoal.Size = new System.Drawing.Size(533, 158);
            this.txtGoal.TabIndex = 11;
            // 
            // txtDecription
            // 
            this.txtDecription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecription.Location = new System.Drawing.Point(6, 3);
            this.txtDecription.Multiline = true;
            this.txtDecription.Name = "txtDecription";
            this.txtDecription.ReadOnly = true;
            this.txtDecription.Size = new System.Drawing.Size(533, 413);
            this.txtDecription.TabIndex = 11;
            // 
            // frmInfoCand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfoCand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate Information";
            this.Load += new System.EventHandler(this.frmInfoCand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerson)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox ptbPerson;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.PictureBox ptbLink;
        private System.Windows.Forms.PictureBox ptbHouse;
        private System.Windows.Forms.PictureBox ptbEmail;
        private System.Windows.Forms.PictureBox ptbTel;
        private System.Windows.Forms.PictureBox ptbBirthday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDecription;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.TextBox txtTitleAndAward;
        private System.Windows.Forms.TextBox txtCertificate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGoal;
    }
}

