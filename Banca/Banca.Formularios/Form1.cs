using Banca.Entidades.Dominio;
using Banca.Entidades.Modelos;
using Banca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banca.Formularios
{
    public partial class Form1 : Form
    {
        private Operador _ctrlPrestamo;

        public Form1()
        {
            InitializeComponent();
            _ctrlPrestamo = new Operador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTiposPrestamos();
            ActualizarPrestamos();
        }

        private void ActualizarTiposPrestamos()
        {
            LstTipos.DataSource = null;
            LstTipos.DataSource = _ctrlPrestamo.TraerTiposPrestamos();
        }

        private void ActualizarPrestamos()
        {
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            LstPrestamos.DataSource = null;
            LstPrestamos.DataSource = _ctrlPrestamo.TraerPrestamos();

            TxtComisionTotal.Text = _ctrlPrestamo.Comision.ToString("0.00");
            Cursor = System.Windows.Forms.Cursors.Default;
        }


        private void LstTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo tipo = (TipoPrestamo) LstTipos.SelectedItem;
            if(tipo != null)
            {
                TxtLinea.Text = tipo.Linea;
                TxtTNA.Text = tipo.TNA.ToString("0.00")+"%";
            }
            else
            {
                TxtLinea.Text = string.Empty;
                TxtTNA.Text = string.Empty;
            }
        }

        private void BtnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarValores(out double monto, out int plazo))
                {
                    Cuota cuota = _ctrlPrestamo.CalcularCuotas(monto, plazo, ((TipoPrestamo)LstTipos.SelectedItem).TNA);
                    TxtCapital.Text = cuota.CuotaCapital.ToString("0.00");
                    TxtInteres.Text = cuota.CuotaInteres.ToString("0.00");
                    TxtCuotaTotal.Text = cuota.CuotaTotal.ToString("0.00");
                }
                else
                {
                    MostrarError("El monto y el plazo deben ser valores numéricos.\nEl plazo debe ser un número entero en días.");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            
        }

        private void MostrarError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarValores(out double monto, out int plazo))
            {
                try
                {
                    TipoPrestamo tipo = (TipoPrestamo)LstTipos.SelectedItem;
                    Prestamo prestamo = new Prestamo(tipo.Linea, tipo.TNA, plazo, monto);
                    _ctrlPrestamo.AltaPrestamo(prestamo, tipo);
                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                }
                
            }
            else
            {
                MostrarError("El monto y el plazo deben ser valores numéricos.\nEl plazo debe ser un número entero en días.");
            }

            ActualizarPrestamos();
        }

        private bool ValidarValores(out double monto, out int plazo)
        {
            bool montoOk = double.TryParse(TxtMonto.Text, out monto);
            bool plazoOk = int.TryParse(TxtPlazo.Text, out plazo);
            if (montoOk && plazoOk)
                return true;
            else
                return false;
        }
    }
}
