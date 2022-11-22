﻿using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace RepairShopAPI
{
	[Table("shortrepairlist")]
	public class ShortRepairList
	{
		public int id { get; set; }
		public string instrument { get; set; }
		public string customer { get; set; }

		// static DAL methods

		public static List<ShortRepairList> getAll()
		{
			// Here's how we do it with just a query and not a view
			//return DAL.DB.Query<ShortRepairOrder>("select ro.id, ro.customer, ins.name as instrument from repairorder ro join instrument ins on ro.instrument_id = ins.id").ToList();
			// But some people argue that putting queries in C# code isn't the best idea.

			MySqlConnection db = new MySqlConnection(DAL.CS);
			db.Open();
			var result = db.GetAll<ShortRepairList>().ToList();
			db.Close();
			return result;
		}
	}
}