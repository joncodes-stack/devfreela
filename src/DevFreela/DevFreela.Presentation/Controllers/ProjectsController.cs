using DevFreela.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevFreela.Presentation.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProject(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GeProjectById(int id)
        {
            return Ok();
        }

        [HttpPost()]
        public IActionResult AddProject([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GeProjectById), new { id = createProject.Id }, createProject);
        }

        [HttpPut()]
        public IActionResult UpdateProject(int id,[FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/commnets")]
        public IActionResult AddComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
