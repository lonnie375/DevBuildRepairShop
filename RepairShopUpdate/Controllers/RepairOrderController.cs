using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepairShopAPI.Controllers
{
	[Route("repairorder")]
	[ApiController]
	public class RepairOrderController : ControllerBase
	{
		// GET /repairorder/{id} - get one

		[HttpGet("{id}")]
		public RepairOrder GetOne(int id)
		{
			return RepairOrder.GetOne(id);
		}

		// POST /repairorder - create one

		[HttpPost]
		public RepairOrder Add(RepairOrder order)
		{
			return RepairOrder.Add(order);
		}

		// DELETE /repairorder/{id} - delete one
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			RepairOrder.Delete(id);
		}

		// PUT /repairorder - update one
		[HttpPut]
		public void Update(RepairOrder order)
		{
			RepairOrder.Update(order);
		}

		// GET /repairorder/short – get the short version of all the orders
		[HttpGet("short")]
		public List<ShortRepairList> GetAll()
		{
			return ShortRepairList.getAll();
		}

        // GET /repairorder/bookmarks
        [HttpGet("bookmarks")]		
		public List<RepairOrder> GetBookMarks()
        {
			return RepairOrder.GetBookMarks(); 
        }
	}
}