using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calificaciones.leliv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNota1.Text);
            double n2 = double.Parse(txtNota2.Text);
            double n3 = double.Parse(txtNota3.Text);
            double n4 = double.Parse(txtNota4.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;

            lblPromedio.Text = promedio.ToString("0.00");

            if (promedio <= 69)
            {
                txtCompletivo.Visible = true;
                btnCompletivo.Visible = true;
            }

        }

        private void btnCompletivo_Click(object sender, EventArgs e)
        {
            double promedio = double.Parse(lblPromedio.Text);
            double notaCompletivo = double.Parse(txtCompletivo.Text);

            double resultadoCompletivo = (promedio * 0.50) + (notaCompletivo * 0.50);

            if (resultadoCompletivo <= 69)
            {
                txtExtraordinario.Visible = true;
                btnExtraordinario.Visible = true;
            }
            else
            {
                MessageBox.Show("Aprobado en Completivo con: " + resultadoCompletivo);
            }

        }

        private void btnExtraordinario_Click(object sender, EventArgs e)
        {
            double promedio = double.Parse(lblPromedio.Text);
            double notaExtra = double.Parse(txtExtraordinario.Text);

            double resultadoExtra = (promedio * 0.30) + (notaExtra * 0.70);

            if (resultadoExtra <= 69)
            {
                MessageBox.Show("Resultado final: REPROBADOR");
            }
            else
            {
                MessageBox.Show("Aprobado en Extraordinario con: " + resultadoExtra);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCompletivo.Visible = false;
            btnCompletivo.Visible = false;

            txtExtraordinario.Visible = false;
            btnExtraordinario.Visible = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtCompletivo.Clear();
            txtExtraordinario.Clear();

            lblPromedio.Text = "";

            txtCompletivo.Visible = false;
            btnCompletivo.Visible = false;

            txtExtraordinario.Visible = false;
            btnExtraordinario.Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
