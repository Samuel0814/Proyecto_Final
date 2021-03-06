﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse_Pharmacy_System.UI.Registros
{
    public partial class RegistroCategorias : Form
    {
        public RegistroCategorias()
        {
            InitializeComponent();
        }

        private Categorias LlenaClase()
        {
            Categorias categorias = new Categorias();

            categorias.CategoriaId = Convert.ToInt32(CategoriaIDnumericUpDown.Value);
            categorias.NombreCategoria = DescripciontextBox.Text;
            return categorias;
        }

        private void Limpiar()
        {
            CategoriaIDnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            MYerrorProvider.Clear();
        }

        private bool HayErrores()
        {

            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MYerrorProvider.SetError(DescripciontextBox,
                    "No debes dejar la descripcion vacia");
                HayErrores = true;
            }
            return HayErrores;

        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CategoriaIDnumericUpDown.Value);
            Categorias categorias = BLL.CategoriasBLL.Buscar(id);

            if (CategoriaIDnumericUpDown.Value == 0)
            {
                MessageBox.Show("El ID debe ser mayor a 0");

            }
            else
            {
                if (categorias != null)
                {
                    DescripciontextBox.Text = categorias.NombreCategoria;
                }
                else
                {
                    MessageBox.Show("No se encuentran categorias registradas en el ID seleccionado");
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Categorias categorias;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {



                categorias = LlenaClase();


                if (CategoriaIDnumericUpDown.Value == 0)
                    Paso = BLL.CategoriasBLL.Guardar(categorias);
                else
                    Paso = BLL.CategoriasBLL.Modificar(LlenaClase());



                if (Paso)
                {
                    MessageBox.Show("Guardado", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CategoriaIDnumericUpDown.Value);

            if (CategoriaIDnumericUpDown.Value == 0)
            {
                MessageBox.Show("El ID debe ser mayor a 0");

            }
            else
            {
                if (BLL.CategoriasBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }


   


    private void RegistroCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
