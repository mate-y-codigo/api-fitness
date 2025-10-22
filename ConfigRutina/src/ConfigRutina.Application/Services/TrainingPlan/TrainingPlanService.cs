using ConfigRutina.Application.DTOs.Response;
using ConfigRutina.Application.Interfaces.TrainingPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigRutina.Application.Services.TrainingPlan
{
    public class TrainingPlanService : ITrainingPlanService
    {
        public TrainingPlanStatusResponse ChangeStateTrainingPlan(string id, bool status)
        {
            throw new NotImplementedException();
        }

        public TrainingPlanResponse CreateTrainingPLan(string IdTrainer, string name, string description, bool plantilla)
        {
            throw new NotImplementedException();
        }

        public List<TrainingPlanResponse> GetFilterTrainingPlan(string? name, bool? plantilla, string? IdEntrenador, bool? active, DateTime? date)
        {
            throw new NotImplementedException();
        }

        public TrainingPlanResponse GetTrainingPlanById(string id)
        {
            throw new NotImplementedException();
        }

        public TrainingPlanResponse UpdateTrainingPlan()
        {
            throw new NotImplementedException();
        }
    }
}
