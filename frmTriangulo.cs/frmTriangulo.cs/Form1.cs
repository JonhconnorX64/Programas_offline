using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTriangulo.cs
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            float A, B, C;
            A = float.Parse(txtLadoA.Text);
            B = float.Parse(txtLadoB.Text);
            C = float.Parse(txtLadoC.Text);

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C && A == C)
                    lblMostrar.Text = "Triângulo Equilátero";
                else if (A == B || A == C || C == B)
                    lblMostrar.Text = "Triângulo Isósceles";
                else
                    lblMostrar.Text = "Triângulo Escaleno";
            }
            else
                lblMostrar.Text = "Valores não formam um triângulo!";
        }
    }
}
