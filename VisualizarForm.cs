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
    public partial class VisualizarForm : Form
    {
        public Usuario Uglobal = new Usuario();
        bool modif = false;
        bool elim = false;
        public VisualizarForm()
        {
            InitializeComponent();
            var data = Uglobal.listar();
            this.dataGridView1.DataSource = data;
        }

        public VisualizarForm(bool modif, bool elim)
        {
            InitializeComponent();
            var data = Uglobal.listar();
            this.dataGridView1.DataSource = data;
            this.modif = modif;
            this.elim = elim;
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var select = dataGridView1.CurrentRow.Index;
            if (select >= 0)
            {
                try
                {

                    var u = new Usuario
                    {
                        Id = dataGridView1.Rows[select].Cells[0].Value.ToString(),
                        Name = dataGridView1.Rows[select].Cells[1].Value.ToString(),
                        Lastname = dataGridView1.Rows[select].Cells[2].Value.ToString(),
                        Age = Convert.ToInt32(dataGridView1.Rows[select].Cells[3].Value),
                        Sexo = dataGridView1.Rows[select].Cells[4].Value.ToString(),
                        Fecnac = dataGridView1.Rows[select].Cells[5].Value.ToString(),
                        Peso = Convert.ToDecimal(dataGridView1.Rows[select].Cells[6].Value),
                        Altura = Convert.ToDecimal(dataGridView1.Rows[select].Cells[7].Value),
                        Hermanos = Convert.ToInt32(dataGridView1.Rows[select].Cells[8].Value),
                        Instruccion = dataGridView1.Rows[select].Cells[9].Value.ToString(),
                        Provincia = dataGridView1.Rows[select].Cells[10].Value.ToString(),
                        Canton = dataGridView1.Rows[select].Cells[11].Value.ToString(),
                        Barrio = dataGridView1.Rows[select].Cells[12].Value.ToString(),
                        CPostal = dataGridView1.Rows[select].Cells[13].Value.ToString(),
                        Etnia = dataGridView1.Rows[select].Cells[14].Value.ToString()

                    };
                    Uglobal = u;

                    if (this.modif == true)
                    {
                        this.Hide();
                        new InsertarForm(modif: true, u: Uglobal).Show();
                    }
                    else if (this.elim == true)
                    {
                        Uglobal.eliminar(Uglobal);
                        var data = Uglobal.listar();
                        this.dataGridView1.DataSource = data;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Principal().Show();
        }
    }
}
