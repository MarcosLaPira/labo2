﻿using Bibliotca_parcial1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual2_parcial1
{
    public partial class FrmVisualizarEstadisticas : FormPadre
    {
        Viaje viaje;
        public FrmVisualizarEstadisticas(Viaje viaje)
        {
            InitializeComponent();

            this.viaje = viaje;
        }

        private void FrmVisualizarEstadisticas_Load(object sender, EventArgs e)
        {
            ActualizarListaCamarotesEstadisticas();

            int cantidadDePasajeros;
            string fechaDeSalida;
            bool estadoDeCrucero;
            int camarotesPremiumVacios;
            int camarotesTuristaVacios;

            cantidadDePasajeros = viaje.CantidadDePasajeros;
            fechaDeSalida = viaje.FechaInicioViaje.ToString();
            estadoDeCrucero = viaje.Barco.BarcoEnPuerto;//true si el barco esta en puerto
            camarotesPremiumVacios = viaje.Barco.CantidadCamarotesPremiumVacios;
            camarotesTuristaVacios = viaje.Barco.CantidadCamarotesTuristaVacios;

            this.txtCantidadPasajeros.Text = cantidadDePasajeros.ToString();
            this.txtFechaSalida.Text = fechaDeSalida.ToString();

            if (estadoDeCrucero)
            {
                this.txtEstadoCrucero.Text = "En puerto";
            }
            else
            {
                this.txtEstadoCrucero.Text = "En viaje";
            }

            this.txtCamarotesPremiumDisponibles.Text = camarotesPremiumVacios.ToString();
            this.txtCamarotesTuristaDispo.Text = camarotesTuristaVacios.ToString();
        }

        private void ActualizarListaCamarotesEstadisticas()
        {

            ///////////////////
            List<Camarote> aux = new List<Camarote>();//instancio lista de camarotes
            aux = this.viaje.Barco.ListCamarotes;//obtengo lisat de camarotes de la base de datos
            string claseCamarote;


            foreach (Camarote camarote in aux)
            {
                if (camarote.TipoDeClaseCamarote == true)//evaluo si el camarote es premium
                {
                    claseCamarote = "Premium";
                }
                else
                {
                    claseCamarote = "Turista";
                }
                dtgCamarotes.Rows.Add(camarote.IdCamarote.ToString(), claseCamarote.ToString(), camarote.ContadorDelCamarote.ToString());
            }
        }

        private void dtgCamarotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = dtgCamarotes.CurrentRow.Index;//obtengo indice selccionado del data grid
            Camarote auxCamarote = viaje.Barco.ListCamarotes.ElementAt(posicion);//obtengo el el camarote del indice seleccionado

            if (auxCamarote is not null)
            {
                FrmVisualizarCamarote visualizarCamarote = new FrmVisualizarCamarote(auxCamarote);
                this.Hide();
                if (visualizarCamarote.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
                /*
                FrmVisualizarCamarote visualizarCamarote = new FrmVisualizarCamarote(auxCamarote);      
                this.Hide();
                visualizarCamarote.Show();
                */

            }
        }

        private void btnListaPasajeros_Click(object sender, EventArgs e)
        {
            /*
            FrmVisualizarPasajeros listaPasajeros = new FrmVisualizarPasajeros(this.viaje);
            this.Hide();
            listaPasajeros.Show();
            */
            FrmVisualizarPasajeros listaPasajeros = new FrmVisualizarPasajeros(this.viaje);
            this.Hide();
            if (listaPasajeros.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}