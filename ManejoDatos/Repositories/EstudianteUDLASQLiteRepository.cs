using ManejoDatos.Interfaces;
using ManejoDatos.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatos.Repositories
{
    public class EstudianteUDLASQLiteRepository : IEstudianteUDLARepository
    {
        private static string NombreBD = "EstudianteUDLA.db3";
        private SQLiteConnection _connection;
        public EstudianteUDLASQLiteRepository()
        {
            Init();
        }
        public void Init()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, NombreBD);
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<EstudianteUDLA>();
        }
        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try 
            {
                int insert = _connection.Insert(estudiante);
                if (insert > 0)
                {
                    return true;
                }
                return false;
            }
            catch 
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<EstudianteUDLA> DevuelveEstadoEstudiantes()
        {
            var listadoEstudiantes = _connection.Table<EstudianteUDLA>().ToList();
            return listadoEstudiantes;
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            int eliminar = _connection.Delete(id);
            if (eliminar > 0)
            {
                return true;
            }
            return false;
        }

        public EstudianteUDLA DevuelveEstudianteUDLA(int id)
        {
            var estudiantes = DevuelveListadoEstudiantes().ToList();
            if (estudiantes.Any(item => item.Id == id)) 
            {
                return estudiantes.Find(item => item.Id == id);
            }

            return new EstudianteUDLA();
        }

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes()
        {
            throw new NotImplementedException();
        }
    }
}
