using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interaz7
{
    public partial class InsertarForm : Form
    {
        Usuario Uglobal = new Usuario();
        bool modif = false;
        public InsertarForm()
        {
            InitializeComponent();

        }

        public InsertarForm(bool modif, Usuario u)
        {
            InitializeComponent();
            this.textBox1.Text = u.Id;
            this.textBox2.Text = u.Name;
            this.textBox3.Text = u.Lastname;
            this.numericUpDown1.Value = u.Age;
            this.comboBox1.Text = u.Sexo;
            this.dateTimePicker1.Text = u.Fecnac;
            this.numericUpDown2.Value = u.Altura;
            this.numericUpDown3.Value = u.Peso;
            this.numericUpDown4.Value = u.Hermanos;
            this.comboBox2.Text = u.Instruccion;
            this.textBox4.Text = u.Provincia;
            this.textBox5.Text = u.Canton;
            this.textBox6.Text = u.Barrio;
            this.textBox7.Text = u.CPostal;
            this.comboBox3.Text = u.Etnia;
            this.modif = modif;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.modif == true)
            {
                new VisualizarForm().Show();
            }
            else
            {
                new Principal().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uglobal.Id = this.textBox1.Text;
            Uglobal.Name = this.textBox2.Text;
            Uglobal.Lastname = this.textBox3.Text;
            Uglobal.Age = Convert.ToInt32(this.numericUpDown1.Value);
            Uglobal.Sexo = this.comboBox1.Text;
            Uglobal.Fecnac = $"{dateTimePicker1.Value.Year}-{dateTimePicker1.Value.Month}-{dateTimePicker1.Value.Day}";
            Uglobal.Peso = this.numericUpDown2.Value;
            Uglobal.Altura = this.numericUpDown3.Value;
            Uglobal.Hermanos = Convert.ToInt32(this.numericUpDown4.Value);
            Uglobal.Instruccion = this.comboBox2.Text;
            Uglobal.Provincia = this.textBox4.Text;
            Uglobal.Canton = this.textBox5.Text;
            Uglobal.Barrio = this.textBox6.Text;
            Uglobal.CPostal = this.textBox7.Text;
            Uglobal.Etnia = this.comboBox3.Text;

            if (this.modif == true)
            {
                Uglobal.modificar(Uglobal);
                this.Hide();
                new VisualizarForm().Show();
            }
            else
            {
                Uglobal.insertar(Uglobal);
            }

        }
    }
}
