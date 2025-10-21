using ConfigRutina.Application.DTOs.Request;
using ConfigRutina.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigRutina.Application.Interfaces.Excercise
{
    public interface IExcerciseCommandService
    {
        Task<ExerciseResponse> Create(ExerciseCreateRequest request);
        Task<ExerciseResponse> Update(string id, ExerciseUpdateRequest request);
        Task<ExerciseResponse> Delete(string strId);
    }
}
