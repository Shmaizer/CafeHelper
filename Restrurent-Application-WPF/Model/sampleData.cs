using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrurent_Application_WPF.Model
{

    public class sampleData : DropCreateDatabaseAlways<RestrurentDB>
    {
        enum bookingstatus { Booked, Reserved, Available };
        protected override void Seed(RestrurentDB context)
        {
            try
            {

                List<FoodItems> fooditems = new List<FoodItems>()
                {
                    new FoodItems { FoodName = "Чай", Description = "Чай", fPrice = 8 },
                     new FoodItems { FoodName = "Самса", Description = "Самса", fPrice = 12 },
                      new FoodItems { FoodName = "Вода", Description = "Вода", fPrice = 12 },
                       new FoodItems { FoodName = "Кола", Description = "Вола", fPrice = 20 }
                };

                List<TableList> tablelist = new List<TableList>()
                {
                    new TableList { TableName = "Стол 1", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Стол 2", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Стол 3", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Стол 4", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Стол 5", BookingStatus = bookingstatus.Booked.ToString() },
                    new TableList {  TableName = "Стол 6", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Стол 7", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Стол 8", BookingStatus = bookingstatus.Available.ToString() },
                     new TableList {  TableName = "Стол 9", BookingStatus = bookingstatus.Available.ToString() }
                };

                foreach (FoodItems f in fooditems)
                {
                    context.FoodItems.Add(f);
                }

                foreach (TableList t in tablelist)
                {
                    context.TableList.Add(t);
                }

                context.SaveChanges();
                base.Seed(context);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
