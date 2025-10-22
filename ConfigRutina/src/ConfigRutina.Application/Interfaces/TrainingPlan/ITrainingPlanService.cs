using ConfigRutina.Application.DTOs.Response;
using ConfigRutina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigRutina.Application.Interfaces.TrainingPlan
{
    public interface ITrainingPlanService
    {
        public TrainingPlanResponse CreateTrainingPLan(string IdTrainer, string name, string description, bool plantilla);
        public TrainingPlanResponse UpdateTrainingPlan(); // preguntar si esta bien
        public TrainingPlanResponse GetTrainingPlanById(string id);
        public TrainingPlanStatusResponse ChangeStateTrainingPlan(string id, bool status);
        public List<TrainingPlanResponse> GetFilterTrainingPlan(string? name, bool? plantilla, string? IdEntrenador, bool? active, DateTime? date);
    }
}
