using ConfigRutina.Application.CustomExceptions;
using ConfigRutina.Application.DTOs.Response;
using ConfigRutina.Application.Services.TrainingPlan;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConfigRutina.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingPlanController : ControllerBase
    {
        private readonly TrainingPlanService _trainingPlanService;
        public TrainingPlanController(TrainingPlanService trainingPlanService)
        {
            _trainingPlanService = trainingPlanService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TrainingPlanResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 400)]

        public async Task<IActionResult> GetTrainingPlanById(string id)
        {
            try
            {
                return new JsonResult(_trainingPlanService.GetTrainingPlanById(id));
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new ApiError { message = ex.Message });
            }

            catch (NotFoundException ex)
            {
                return NotFound(new ApiError { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiError { message = "Ocurrio un error inesperado." + " " + ex.Message });
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TrainingPlanStatusResponse), 201)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 409)]
        public async Task<IActionResult> ChangeTrainingPlanStatus(string id, [FromBody] bool status) {
            try
            {
                return new JsonResult(_trainingPlanService.ChangeStateTrainingPlan(id, status));
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new ApiError { message = ex.Message });
            }

            catch (NotFoundException ex)
            {
                return NotFound(new ApiError { message = ex.Message });
            }

            catch (ConflictException ex) {
                return Conflict(new ApiError { message = ex.Message });
            }

            catch (Exception ex)
            {
                return StatusCode(500, new ApiError { message = "Ocurrio un error inesperado." + " " + ex.Message });
            }

        }

        [HttpGet]
        [ProducesResponseType(typeof(TrainingPlanResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]

        public async Task<IActionResult> GetTrainingPlanFilter([FromQuery] string? name, bool? plantilla, string? IdEntrenador, bool? active, DateTime? date)
        {
            try
            {
                return new JsonResult(_trainingPlanService.GetFilterTrainingPlan(name, plantilla, IdEntrenador, active, date));
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new ApiError { message = ex.Message });
            }

            catch (Exception ex)
            {
                return StatusCode(500, new ApiError { message = "Ocurrio un error inesperado." + " " + ex.Message });
            }

        }

        [HttpPost]
        [ProducesResponseType(typeof(TrainingPlanResponse), 201)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]


        //preguntar si se espera del body las sesiones o se asignan en service
        public async Task<IActionResult> CreateTrainingPlan([FromBody]string IdTrainer,string name,string description,bool plantilla)
        {
            try
            {
                return new JsonResult(_trainingPlanService.CreateTrainingPLan(IdTrainer,name,description,plantilla));
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new ApiError { message = ex.Message });
            }
            catch (NotFoundException ex)
            {
                return BadRequest(new ApiError { message = ex.Message });
            }

            catch (Exception ex)
            {
                return StatusCode(500, new ApiError { message = "Ocurrio un error inesperado." + " " + ex.Message });
            }

        }

    }
}
