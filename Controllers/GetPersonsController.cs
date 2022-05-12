using crudpractisesqlserver.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crudpractisesqlserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPersonsController : ControllerBase
    {

        private readonly DataContext _dataContext;


        public GetPersonsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }



        [HttpGet]

        public async Task<IActionResult> GetAsync(int id)
        {


            if (id is 0)
            {

                var persons = await _dataContext.Persons.ToListAsync();
                return Ok(persons);
            }

            else
            {
                var persons = await _dataContext.Persons.FindAsync(id);
                return Ok(persons);

            }

        }

    }

    
}
