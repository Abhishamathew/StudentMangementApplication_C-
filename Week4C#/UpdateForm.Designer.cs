﻿namespace Week4C_
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.score1TextBox = new System.Windows.Forms.TextBox();
            this.score2TextBox = new System.Windows.Forms.TextBox();
            this.score3TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lab:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assignment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(278, 52);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.ReadOnly = true;
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentNameTextBox.TabIndex = 4;
            // 
            // score1TextBox
            // 
            this.score1TextBox.Location = new System.Drawing.Point(278, 108);
            this.score1TextBox.Name = "score1TextBox";
            this.score1TextBox.Size = new System.Drawing.Size(100, 22);
            this.score1TextBox.TabIndex = 5;
            // 
            // score2TextBox
            // 
            this.score2TextBox.Location = new System.Drawing.Point(278, 178);
            this.score2TextBox.Name = "score2TextBox";
            this.score2TextBox.Size = new System.Drawing.Size(100, 22);
            this.score2TextBox.TabIndex = 6;
            // 
            // score3TextBox
            // 
            this.score3TextBox.Location = new System.Drawing.Point(278, 237);
            this.score3TextBox.Name = "score3TextBox";
            this.score3TextBox.Size = new System.Drawing.Size(100, 22);
            this.score3TextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score3TextBox);
            this.Controls.Add(this.score2TextBox);
            this.Controls.Add(this.score1TextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox score1TextBox;
        private System.Windows.Forms.TextBox score2TextBox;
        private System.Windows.Forms.TextBox score3TextBox;
        private System.Windows.Forms.Button button1;
    }
}