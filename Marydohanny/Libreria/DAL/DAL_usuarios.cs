using EL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILIDAD;

namespace DAL
{
    public static class DAL_usuarios
    {
        private static byte[] Key = Encoding.UTF8.GetBytes("S3Gur1d4d1nf0rm4t1c42o23");//24 Caracteres
        private static byte[] IV = Encoding.UTF8.GetBytes("Pr0y3ct03J3mpl00");//16 Caracteres
        public static usuario Insert(usuario Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Usuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(usuario Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var RegistroBD = bd.Usuarios.Find(Entidad.IdUsuario);
                RegistroBD.NombreCompleto = Entidad.NombreCompleto;
                RegistroBD.Correo = Entidad.Correo;
                RegistroBD.UserName = Entidad.UserName;
                if (Entidad.Password != null)
                {
                    RegistroBD.Password = Entidad.Password;
                }
                RegistroBD.IdRol = Entidad.IdRol;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool PasswordUpdate(usuario Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Consulta = bd.Usuarios.Find(Entidad.IdUsuario);
                Consulta.Password = Entidad.Password;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(usuario Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var RegistroBD = bd.Usuarios.Find(Entidad.IdUsuario);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<usuario> List(bool Activo = true)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.Activo == Activo).ToList();
            }
        }
        public static usuario Registro(int IdRegistro)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Find(IdRegistro);
            }
        }
        public static List<usuario> Buscar(string Palabra)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.
                      Where(a => a.NombreCompleto.Contains(Palabra)
                              || a.Correo.Contains(Palabra)
                              || a.UserName.Contains(Palabra)
                      ).ToList();
            }
        }
        public static usuario ExisteCorreo(string Email)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.Correo.ToLower() == Email.ToLower()).SingleOrDefault();
            }
        }
        public static bool SumarIntentosFallido(int IdRegistro)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.Usuarios.Find(IdRegistro);
                Registro.IntentosFallidos = Convert.ToByte(Registro.IntentosFallidos + 1);
                return bd.SaveChanges() > 0;
            }
        }
        public static bool RestablecerIntentosFallido(int IdRegistro, int IdUsuarioActualiza)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.Usuarios.Find(IdRegistro);
                Registro.IntentosFallidos = 0;
                Registro.IdUsuarioActualiza = IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool BloquearCuentaUsuario(int IdRegistro, bool Bloquear, int IdUsuarioActualiza)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.Usuarios.Find(IdRegistro);
                Registro.Bloqueado = Bloquear;
                if (!Bloquear) { Registro.IntentosFallidos = 0; }
                Registro.IdUsuarioActualiza = IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool ExisteUserName(string UserName)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.UserName.ToLower() == UserName.ToLower()).Count() > 0;
            }
        }
        public static usuario ExisteUsuario_x_UserName(string UserName)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.UserName.ToLower() == UserName.ToLower()).SingleOrDefault();
            }
        }
        public static bool ValidarCredenciales(string UserName, byte[] Password)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.UserName.ToLower() == UserName.ToLower() && a.Password == Password).Count() > 0;
            }
        }
        public static byte[] Encrypt(string FlatString)
        {
            return Encripty.Encrypt(FlatString, Key, IV);
        }


    }




}

