﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictamenesMedicos.Model
{
    public class CitaModel
    {
        public string Id { get; set; }
        public string Telefono { get; set; }
        public string correoElectronico { get; set; }
        public DateTime fechaCita { get; set; }
        public string IdTipoExamen { get; set; }
        public string IdPaciente { get; set; }
        public string resultado { get; set; }
        public string IdDoctor { get; set; } // Añadir esta propiedad

        public CitaModel()
        {
            resultado = "Pendiente"; // Valor por defecto
        }


    }
}
