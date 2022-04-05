using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace sistemaAlmacen
{
    public partial class CrudOracle : Form
    {
        OracleConnection ora = new OracleConnection("Data source=DESPACHO; Password=serpost;user Id=system;");
        public CrudOracle()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Excel_Click(object sender, EventArgs e)
        {

        }
    }
}
