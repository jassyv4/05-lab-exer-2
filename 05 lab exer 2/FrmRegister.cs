using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_lab_exer_2
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecord = new FrmStudentRecord();
            studentRecord.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text.Trim();
            string program = txtProgram.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleInitial = txtMI.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = cmbGender.SelectedItem?.ToString();
            string birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            string contactNo = txtContactNo.Text.Trim();

            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(basePath, "RegistrationFiles");
            Directory.CreateDirectory(folderPath);

            string fileName = studentNo + ".txt";
            string fullPath = Path.Combine(folderPath, fileName);

            string[] info = {
                $"Student No.: {studentNo}",
                $"Full Name: {lastName}, {firstName}, {middleInitial}.",
                $"Program: {program}",
                $"Gender: {gender}",
                $"Age: {age}",
                $"Birthday: {birthday}",
                $"Contact No.: {contactNo}"
            };
            using (StreamWriter outputFile = new StreamWriter(fullPath))
            {
                foreach (string line in info)
                {
                    outputFile.WriteLine(line);
                }
            }

            MessageBox.Show("Registration saved successfully!");
        }
    }
    }

