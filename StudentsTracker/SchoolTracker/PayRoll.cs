using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());

            Logger.Log("PayRoll started", "Payroll");
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }

            Logger.Log("PeyAll completed", "PayRoll", 2);
        }
    }
}
