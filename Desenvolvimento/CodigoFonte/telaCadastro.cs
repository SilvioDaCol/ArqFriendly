﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLearning
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void gameLearningLogoMenor_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

          

            if((((campoRaMatricula.Text == "")||(campoNome.Text == "")||(campoCampus.Text == "")||(campoSenha.Text == ""))))
            {
                MessageBox.Show("Existem campos não preenchidos!!!");
               

            }

            if ((((campoRaMatricula.Text != "")&&(campoNome.Text != "")&&(campoCampus.Text != "")&&(campoSenha.Text != ""))))
            {
                
                MessageBox.Show("Dados Enviados com Sucesso!");
                this.Hide();
                telaInicial voltarInicio = new telaInicial();
                voltarInicio.Closed += (s, args) => this.Close();
                voltarInicio.Show();
                
                
            }  

        }
    }
}