using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalRApi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>,IDiscountDal
    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }

		public void ChangeStatusToFalse(int id)
		{
			using var contex = new SignalRContext();
			var value = contex.Discounts.Find(id);
			value.Status = false;
			contex.SaveChanges();
		}

		public void ChangeStatusToTrue(int id)
		{
			using var contex = new SignalRContext();
			var value = contex.Discounts.Find(id);
			value.Status = true;
			contex.SaveChanges();
		}

        public List<Discount> GetListByStatusTrue()
        {
            using var context = new SignalRContext();
			var value = context.Discounts.Where(x => x.Status == true).ToList();
			return value;
        }
    }
}
