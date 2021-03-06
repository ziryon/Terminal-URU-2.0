﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaTerminal:ILogicaTerminal
    {
        //singleton
        public static LogicaTerminal _instancia = null;
        public LogicaTerminal() { }
        public static LogicaTerminal GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaTerminal();
            return _instancia;
        }

        public void Agregar(Terminal t) 
        {
            if (t._Facilidades.Length == 0)
                throw new Exception("Debe seleccionar al menos una facilidad");
            FabricaPersistencia.GetPersistenciaTerminal().Agregar(t);
        }
        public void Modificar(Terminal t)
        {
            if (t._Facilidades.Length == 0)
                throw new Exception("Debe seleccionar al menos una facilidad");
            FabricaPersistencia.GetPersistenciaTerminal().Modificar(t);
        }
        public void Eliminar(Terminal t)
        {
            FabricaPersistencia.GetPersistenciaTerminal().Eliminar(t);
        }
        public Terminal Buscar(string pCodigo)
        {
            return FabricaPersistencia.GetPersistenciaTerminal().Buscar(pCodigo);
        }

        public List<Terminal> Listar()
        {
            return FabricaPersistencia.GetPersistenciaTerminal().Listar();
        }

        public List<Terminal> ListarNoBajas()
        {
            return FabricaPersistencia.GetPersistenciaTerminal().ListarNoBajas();
        }

    }
}
