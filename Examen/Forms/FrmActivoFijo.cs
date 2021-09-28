using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmActivoFijo : Form
    {

        public ActivoFijoModel AFModel { get; set; }
        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void FrmActivoFijo_Load(object sender, EventArgs e)
        {
            cmbTIpoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<object>().ToArray());
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo af = new ActivoFijo()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Codigo = txtCod.Text,
                ValorActivo = nudValor.Value,
                ValorResidual = nudValorR.Value,
                FechaAdquisicion = dtpFecha.Value,
                TipoActivo = (TipoActivo)cmbTIpoActivo.SelectedIndex,
                Id = AFModel.GetLastId() + 1,
                VidaUtil = cmbTIpoActivo.SelectedIndex
            };
            AFModel.Add(af);
            Dispose();
        }
        private void ValidarCampos(string nombre, string desc, string codigo)
        {
            if (cmbTIpoActivo.SelectedIndex==-1)
            {
                throw new ArgumentException("No ha seleccionado ningun tipo de activo");
            }
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(codigo))
            {
                throw new ArgumentException("Algunos campos estan vacios");
            }
            if (codigo.Length > 10)
            {
                throw new ArgumentException("Solo se permiten 10 digitos en el codigo");
            }
        }

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten numeros");
                e.Handled = true;
            }
        }
    }
}
