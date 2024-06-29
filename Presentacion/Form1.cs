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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                region.RegionName = txtBuscar.Text;
                negocio.Crear(region);
                MessageBox.Show("Registro correcto");
                dgvRegion.DataSource = negocio.Listar(region);
            }
            catch (Exception)
            {

                MessageBox.Show("Comunicarse con el administrador");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                region.RegionName = txtBuscar.Text.Trim();
                region.RegionId = Convert.ToInt32(txtId.Text);
                negocio.Editar(region);
                MessageBox.Show("Editado correcto");
                dgvRegion.DataSource = negocio.Listar(region);
            }
            catch (Exception)
            {

                MessageBox.Show("Comunicarse con el administrador");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                region.RegionId = Convert.ToInt32(txtId.Text);
                negocio.Eliminar(region);
                MessageBox.Show("Editado correcto");
                dgvRegion.DataSource = negocio.Listar(region);
            }
            catch (Exception)
            {

                MessageBox.Show("Comunicarse con el administrador");
            }
        }
    }
}
