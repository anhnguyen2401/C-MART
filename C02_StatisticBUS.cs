using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cmart.BUS
{

    class C02_StatisticBUS
    {
        CMART1Entities1 db = new CMART1Entities1();

        public List<Bill> loadBillList()
        {
            return db.Bills.ToList();
        }

        public List<Bill> ViewDateRange(DateTime startDate, DateTime endDate)
        {
            var billList = from Bill in db.Bills
                           where Bill.BillDate >= startDate && Bill.BillDate <= endDate
                           select Bill;
            return billList.ToList();
        }

        public List<Bill> ViewMonthRange(DateTime startMonth, DateTime endMonth)
        {
            var billList = from Bill in db.Bills
                           where Bill.BillDate >= startMonth && Bill.BillDate <= endMonth
                           select Bill;
            return billList.ToList();
        }

        public List<Bill> ViewYearRange(DateTime startYear, DateTime endYear)
        {
            var billList = from Bill in db.Bills
                           where Bill.BillDate >= startYear && Bill.BillDate <= endYear
                           select Bill;
            return billList.ToList();
        }
    }
}