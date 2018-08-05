using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class UsuariosBLL
    {
        public static Usuarios UsuarioLogueado { get; set; }
        public static bool Guardar(Usuarios usuarios)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.usuario.Add(usuarios) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Guardar");
            }
            return paso;
        }

        public static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(usuarios).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Usuarios usuarios = contexto.usuario.Find(id);

                contexto.usuario.Remove(usuarios);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("error al eliminar");
            }
            return paso;
        }
        public static bool InicialSeccion(string user,string password)
        {
            Contexto db = new Contexto();
            var usuario = from usuarion in db.usuario
                      where usuarion.NombreUsuario == user && usuarion.PassUsuario == password
                      select usuarion;
            
            if(usuario.ToList().Count>0)
            {
                foreach (var item in usuario)
                {
                    UsuarioLogueado = item;

                }
                
                return true;
            }
            
            MessageBox.Show("Usuario o contraseña invalidad ");
            

            return false;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios= new Usuarios();
            try
            {
                usuarios = contexto.usuario.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("error de busqueda");
            }
            return usuarios;
        }


        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            Contexto contexto = new Contexto();
            try
            {
                usuarios = contexto.usuario.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran vehiculos registrados"); 
            }
            return usuarios;
        }
    }
}
