using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace Week4C_
{
    public partial class AddForm : Form
    {
        private Form1 parentForm;
        private Studentlist formList;  // Add this field

        public AddForm(Form1 parentForm, Studentlist formList)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.formList = formList;  // Set the formList field
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            int score1Text = Convert.ToInt16(score1TextBox.Text);
            int score2Text = Convert.ToInt16(score2TextBox.Text);
            int score3Text = Convert.ToInt16(score3TextBox.Text);

            Student newStudent = new Student(studentName,score1Text,score2Text,score3Text);
            if (!isStudentNameExist(newStudent.Name))
            {
                if (0 < score1Text && score1Text <= 100 &&
                    0 < score2Text && score2Text <= 100 &&
                    0 < score3Text && score3Text <= 100)
                {
                    formList.Add(newStudent);
                    parentForm.RefreshList();
                    studentNameTextBox.Text = "";
                    score1TextBox.Text = "";
                    score2TextBox.Text = "";
                    score3TextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Add scores between 0 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Student name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool isStudentNameExist(string name)
        {
            //checking if the student name already exist
            foreach (Student tmpStudent in this.formList.ToArray())
            {
                if (tmpStudent.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

    }


}
