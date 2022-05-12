using crudpractisesqlserver.Data;
using crudpractisesqlserver.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crudpractisesqlserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatePersonController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UpdatePersonController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpPut]
        public async Task<IActionResult> PutAsync(int personId, Persons personToUpdate)
        {

            /*
                        if(personId == 0)
                        {
                            return NotFound();
                        }

                        else
                        {
                            Persons? person = await _dataContext.Persons.FindAsync(personId);



                            _dataContext.Persons.Update(personToUpdate);

                        }
            */


            _dataContext.Persons.Update(personToUpdate);
            await _dataContext.SaveChangesAsync();
            return Ok("Person Updated Successfully");
        }
    }
}
