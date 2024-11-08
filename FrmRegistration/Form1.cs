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

namespace FrmRegistration
{
    public partial class FrmRegistration : Form
    {

        public FrmRegistration()
        {
            InitializeComponent();
            cmbProgram.Items.Add(" BS Computer Science");
            cmbProgram.Items.Add(" BS Information Technology");
            cmbProgram.Items.Add(" BS Software Engineering");

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
        }
        
        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text;
            string middleInitial = txtMiddleInitial.Text;
            string age = txtAge.Text; 
            string birthday = dtpBirthday.Value.ToShortDateString(); 
            string contactNumber = txtContactNumber.Text; 

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, studentNumber + ".txt")))
            {
                string[] content = {
            "Student Number: " + studentNumber,
            "Middle Initial: " + middleInitial,
            "Age: " + age,
            "Birthday: " + birthday,
            "Contact Number: " + contactNumber,
            "First Name: " + txtFirstName.Text,
            "Last Name: " + txtLastName.Text,
            "Program: " + cmbProgram.SelectedItem.ToString(),
            "Gender: " + cmbGender.SelectedItem.ToString()
        };

                foreach (string line in content)
                {
                    outputFile.WriteLine(line); 
                }
            }

            MessageBox.Show("Registration completed!"); 
        }


    }
}

