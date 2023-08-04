namespace Interaz7
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void btinsertar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InsertarForm().ShowDialog();
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VisualizarForm(modif: true,elim:false).Show();
        }

        private void btleer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VisualizarForm().Show();
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VisualizarForm(modif: false, elim: true).Show();
        }
    }
}