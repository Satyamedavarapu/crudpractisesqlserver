using crudpractisesqlserver.Data;
using crudpractisesqlserver.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crudpractisesqlserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPersonController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public AddPersonController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpPost]

        public async Task<IActionResult> PostAsync(Persons person)
        {


             _dataContext.Persons.Add(person);

            await _dataContext.SaveChangesAsync();

            return Created($"/GetPersons?id={person.Id}", person);




        }

      
    }
}
