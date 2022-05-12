using crudpractisesqlserver.Data;
using crudpractisesqlserver.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crudpractisesqlserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeletePersonController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public DeletePersonController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {


            var personToDelete = await _dataContext.Persons.FindAsync(id);

            if (personToDelete == null)
            {

                return NotFound();


            }


            _dataContext.Persons.Remove(personToDelete);

            await _dataContext.SaveChangesAsync();

            return NoContent();


        }
    }
}
