using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShopAPI;

namespace RepairShopUpdate.Controllers
{
    [Route("instrument")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        // GET /Instrument/{id} - get one

        [HttpGet]
		public List<Instrument> GetAllInstrument()
        {
			return Instrument.GetAll();
        }

		[HttpGet("{id}")]
		public Instrument GetOne(int id)
		{
			return Instrument.GetOne(id);
		}

		// POST /Instrument - create one

		[HttpPost]
		public Instrument Add(Instrument order)
		{
			return Instrument.Add(order);
		}

		// DELETE /Instrument/{id} - delete one
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			Instrument.Delete(id);
		}

		// PUT /Instrument - update one
		[HttpPut]
		public void Update(Instrument order)
		{
			Instrument.Update(order);
		}
	}
}
