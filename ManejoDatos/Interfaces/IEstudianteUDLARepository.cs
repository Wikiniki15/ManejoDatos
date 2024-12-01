using ManejoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatos.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        IEnumerable<EstudianteUDLA> DevuelveEstadoEstudiantes();
        EstudianteUDLA DevuelveEstudianteUDLA(int id);
        bool CrearEstudianteUDLA(EstudianteUDLA estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        bool EliminarEstudianteUDLA(int id);

    }
}
