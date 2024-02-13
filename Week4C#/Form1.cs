using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Week4C_
{
    public partial class Form1 : Form
    {
        Studentlist formList = new Studentlist();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formList.Add(new Student("Abhisha", 100, 90, 50));
            formList.Add(new Student("Mathew", 100, 80, 70));
            formList.Add(new Student("Leo", 40, 50, 60));
            RefreshList();
        }

        public void RefreshList(int selectedIndex=0)
        {
            studentListBox.Items.Clear();

            foreach (var student in formList.GetStudents())
            {
                studentListBox.Items.Add(student.ToString());
            }

            if (studentListBox.Items.Count > 0)
            {
                studentListBox.SelectedIndex = selectedIndex;
            }
            else
            {
                ClearData();
            }
            studentListBox.Focus();
        }

        private void ClearData()
        {
            ScoreTotalTextBox.Text = "";
            ScoreCountTextBox.Text = "";
            AVGTEXTBOX.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(studentListBox.SelectedIndex != -1)
            {
                string student = studentListBox.SelectedItem.ToString();
                string[] scores = student.Split('|');

                int total = 0;
                for (int i = 1; i < scores.Length; i++)
                {
                    total += Convert.ToInt32(scores[i]);
                }
                ScoreTotalTextBox.Text = total.ToString();
                int count = scores.Length - 1;

                ScoreCountTextBox.Text = count.ToString();

                int avg = 0;
                if (total > 0)
                {
                     avg = total / count;
                }

                AVGTEXTBOX.Text = avg.ToString();

            }

        }

        private void ScoreTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScoreCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AVGTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addBtn.Checked)
            {
                AddForm newform = new AddForm(this, formList);
                newform.ShowDialog();
            }
            else if (deleteBtn.Checked)
            {
                DeleteSelectedStudent();
            }
            else if (updateBtn.Checked)
            {
                int selectedIndex = studentListBox.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Student selectedStudent = formList.GetStudents()[selectedIndex];
                    UpdateForm updateForm = new UpdateForm(this, selectedStudent);
                    updateForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("select student to update");
                }
            }
            else if (exitBtn.Checked)
            {
                this.Close();
            }
        }

        public void DeleteSelectedStudent()
        {
            int selectedIndex = studentListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                formList.GetStudents().RemoveAt(selectedIndex);
                RefreshList();
                MessageBox.Show("Deleted successfully");
            }
        }

    }
}
