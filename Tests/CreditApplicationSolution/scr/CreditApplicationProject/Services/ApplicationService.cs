using CreditApplicationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProject.Services
{
    public class ApplicationService
    {
        public Decision GetDecision(Application application)
        {
            var decision = new Decision()
            {
                Answer = "",
                InterestRate = 0 

            };
            // this if looks complex
            if ((application.CreditAmount < 2000 || application.CreditAmount > 69000) && application.CreditAmount > 0)
            {

                decision.Answer = "No"; 
                return decision;
            }
            else if (application.CreditAmount < 0 || application.CurrentCreditAmount < 0) { throw new ArgumentException("Wrong input"); }

            decision.Answer = "Yes";
            int TotalFutureDebt = application.CreditAmount + application.CurrentCreditAmount;
            // maybe switch statement
            if (TotalFutureDebt < 20000)
            {
                decision.InterestRate = 3;
                return decision;
            }
            if (TotalFutureDebt > 20000 && TotalFutureDebt < 39000)
            {
                decision.InterestRate = 4;
                return decision;
            }
            if (TotalFutureDebt > 40000 && TotalFutureDebt < 59000)
            {
                decision.InterestRate = 5;
                return decision;
            }
            if (TotalFutureDebt > 60000)
            {
                decision.InterestRate = 6;
                return decision; //return object
            }
            else if (application.CreditAmount < 0 || application.CurrentCreditAmount < 0) { throw new ArgumentException("Wrong input"); }
            throw new ArgumentException("Wrong input");
             
        }
    }
}
