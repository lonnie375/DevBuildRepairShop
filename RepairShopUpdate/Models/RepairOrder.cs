using Dapper.Contrib.Extensions;

namespace RepairShopAPI
{
    [Table("repairorder")]
    public class RepairOrder
    {
        [Key]
        public int id { get; set; }
        public string customer { get; set; }
        public int instrument_id { get; set; }
        public int status { get; set; }
        public decimal price { get; set; }
        public string notes { get; set; }
        public bool bookmark { get; set; }

        // Static DAL members

        // C(R)UD GetOne

        public static RepairOrder GetOne(int id)
        {
            return DAL.DB.Get<RepairOrder>(id);
        }

        // (C)RUD Create

        public static RepairOrder Add(RepairOrder order)
        {
            DAL.DB.Insert(order);
            return order;
        }

        // CRU(D) Delete
        public static void Delete(int id)
        {
            RepairOrder order = new RepairOrder();
            order.id = id;
            DAL.DB.Delete<RepairOrder>(order);

        }

        // CR(U)D Update

        public static void Update(RepairOrder order)
        {
            DAL.DB.Update(order);
        }
    }
}