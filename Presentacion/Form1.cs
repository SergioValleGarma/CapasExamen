using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        NRegion negocio = new NRegion();
        Entidad.Region region = new Entidad.Region();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            region.RegionName = txtBuscar.Text;
            dgvRegion.DataSource = negocio.Listar(region);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            region.RegionName = txtBuscar.Text;
            dgvRegion.DataSource = negocio.Listar(region);
        }
    }
}
