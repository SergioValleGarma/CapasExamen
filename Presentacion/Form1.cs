using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        NRegion negocio = new NRegion();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            dgvRegion.DataSource = negocio.Listar(txtBuscar.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvRegion.DataSource = negocio.Listar(txtBuscar.Text);
        }
    }
}
