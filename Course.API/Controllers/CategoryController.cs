using Course.Infrastructure.CourseDBC;
using Microsoft.AspNetCore.Mvc;

namespace Course.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CourseDbContext _dbcontext;

        public CategoryController(CourseDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = _dbcontext.Categories.ToList();
            return Ok(categories);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _dbcontext.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Course.Domain.Models.Category category)
        {
            if (category == null)
            {
                return BadRequest();
            }
            _dbcontext.Categories.Add(category);
            await _dbcontext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
        }
    }
}
