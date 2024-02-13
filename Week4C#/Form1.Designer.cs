namespace Week4C_
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.RadioButton();
            this.deleteBtn = new System.Windows.Forms.RadioButton();
            this.updateBtn = new System.Windows.Forms.RadioButton();
            this.addBtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.ScoreCountTextBox = new System.Windows.Forms.TextBox();
            this.AVGTEXTBOX = new System.Windows.Forms.TextBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(538, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Checked = true;
            this.exitBtn.Location = new System.Drawing.Point(29, 163);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(49, 20);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.Location = new System.Drawing.Point(29, 123);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(68, 20);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.CheckedChanged += new System.EventHandler(this.deleteBtn_CheckedChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSize = true;
            this.updateBtn.Location = new System.Drawing.Point(29, 81);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(73, 20);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "&Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.CheckedChanged += new System.EventHandler(this.updateBtn_CheckedChanged);
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.Location = new System.Drawing.Point(29, 38);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(53, 20);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Perform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score Total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average";
            // 
            // ScoreTotalTextBox
            // 
            this.ScoreTotalTextBox.Location = new System.Drawing.Point(380, 227);
            this.ScoreTotalTextBox.Name = "ScoreTotalTextBox";
            this.ScoreTotalTextBox.ReadOnly = true;
            this.ScoreTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.ScoreTotalTextBox.TabIndex = 5;
            this.ScoreTotalTextBox.TextChanged += new System.EventHandler(this.ScoreTotalTextBox_TextChanged);
            // 
            // ScoreCountTextBox
            // 
            this.ScoreCountTextBox.Location = new System.Drawing.Point(380, 282);
            this.ScoreCountTextBox.Name = "ScoreCountTextBox";
            this.ScoreCountTextBox.ReadOnly = true;
            this.ScoreCountTextBox.Size = new System.Drawing.Size(100, 22);
            this.ScoreCountTextBox.TabIndex = 6;
            this.ScoreCountTextBox.TextChanged += new System.EventHandler(this.ScoreCountTextBox_TextChanged);
            // 
            // AVGTEXTBOX
            // 
            this.AVGTEXTBOX.Location = new System.Drawing.Point(380, 351);
            this.AVGTEXTBOX.Name = "AVGTEXTBOX";
            this.AVGTEXTBOX.ReadOnly = true;
            this.AVGTEXTBOX.Size = new System.Drawing.Size(100, 22);
            this.AVGTEXTBOX.TabIndex = 7;
            this.AVGTEXTBOX.TextChanged += new System.EventHandler(this.AVGTEXTBOX_TextChanged);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(81, 67);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(399, 132);
            this.studentListBox.TabIndex = 8;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Students";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.AVGTEXTBOX);
            this.Controls.Add(this.ScoreCountTextBox);
            this.Controls.Add(this.ScoreTotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton addBtn;
        private System.Windows.Forms.RadioButton exitBtn;
        private System.Windows.Forms.RadioButton deleteBtn;
        private System.Windows.Forms.RadioButton updateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ScoreTotalTextBox;
        private System.Windows.Forms.TextBox ScoreCountTextBox;
        private System.Windows.Forms.TextBox AVGTEXTBOX;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label label4;
    }
}

