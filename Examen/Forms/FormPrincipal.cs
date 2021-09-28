using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class FormPrincipal : Form
    {
        public ActivoFijoModel ActFijoModel;
        public FormPrincipal()
        {
            ActFijoModel = new ActivoFijoModel();
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //cmbDepreciacion.Items.Add(Enum.GetValues(typeof());
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmActivoFijo frmAF = new FrmActivoFijo();
            frmAF.AFModel = ActFijoModel;
            frmAF.ShowDialog();
            richTextBox1.Text += ActFijoModel.GetActivoFijo(ActFijoModel.GetLastId());
        }
    }
}
