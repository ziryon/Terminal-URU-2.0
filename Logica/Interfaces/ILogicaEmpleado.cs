﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaEmpleado
    {
        Empleado Logueo(string pUsuario, string pPass);

        Empleado Buscar(string pCedula);

        void Agregar(Empleado pEmp);

        void Modificar(Empleado pEmp);

        void Borrar(Empleado pEmp);
    }
}
