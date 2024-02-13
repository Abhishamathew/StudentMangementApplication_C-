using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4C_
{
    public partial class UpdateForm : Form
    {
        private Form1 parentForm;
        private Student existingStudent;
        public UpdateForm(Form1 parentForm,Student existingStudent)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.existingStudent = existingStudent;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            if (existingStudent != null)
            {
                studentNameTextBox.Text = existingStudent.Name;
                score1TextBox.Text = existingStudent.Score1.ToString();
                score2TextBox.Text = existingStudent.Score2.ToString();
                score3TextBox.Text = existingStudent.Score3.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            int score1Text = Convert.ToInt16(score1TextBox.Text);
            int score2Text = Convert.ToInt16(score2TextBox.Text);
            int score3Text = Convert.ToInt16(score3TextBox.Text);

            if (0 < score1Text && score1Text <= 100 &&
                    0 < score2Text && score2Text <= 100 &&
                    0 < score3Text && score3Text <= 100)
            {
                // Update the existing student information
                existingStudent.Name = studentName;
                existingStudent.Score1 = score1Text;
                existingStudent.Score2 = score2Text;
                existingStudent.Score3 = score3Text;
                parentForm.RefreshList();
                this.Close();
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Add scores between 0 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
