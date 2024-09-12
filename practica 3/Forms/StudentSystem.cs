using StudentSystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3.Forms
{
    public partial class StudentSystem : Form
    {
        public StudentSystem()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Career career = new Career();
            Student student = new Student();

            career.Name = textBoxCareer.Text;
            student.FirtName = textBoxName.Text;
            student.LastName = textBoxLastName.Text;
            student.PhoneNumber = textBoxPhoneNumber.Text;
            student.Career = career;

            listBoxRegister.Items.Add(student);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRegister.SelectedItem is Student selectedStuden)
            {
                listBoxRegister.Items.Remove(selectedStuden);
                MessageBox.Show("Estudiante Eliminado con exito");
                ClearData();
            }
            else
            {
                MessageBox.Show("No se ha selecionado un estudiante");
            }
        }

        public void ClearData()
        {
            textBoxName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxCareer.Clear();
            textBoxName.Focus();
        }
    }
}
