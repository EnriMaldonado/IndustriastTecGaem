﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndustriasTecGaem.BL;

namespace IndustriasTecGaem.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var listaDeProductos = productosBL.ObtenerProductos();

            listaDeProductosBindingSource.DataSource = listaDeProductos;
        }

        private void productosBLBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaDeProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contextoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productosBLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
