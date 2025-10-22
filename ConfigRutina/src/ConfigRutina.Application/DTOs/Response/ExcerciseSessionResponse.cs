﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigRutina.Application.DTOs.Response
{
    public class ExcerciseSessionResponse
    {
        public Guid id { get; set; }
        public int seriesObjetivo { get; set; }
        public int repeticionesObjetivo { get; set; }
        public float pesoObjetivo { get; set; }
        public int descanso { get; set; }
        public int orden { get; set; }
        public ExerciseResponse ejercicio { get; set;}


    }
}
