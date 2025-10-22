using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigRutina.Application.DTOs.Response
{
    public class TrainingSessionResponse
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Orden { get; set; }
    }
}
