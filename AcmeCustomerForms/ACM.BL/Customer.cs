using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            // -- check for valid email -- 
            // If user requested a receipt,
            // get customer data
            // Ensure a valid email was provided
            // If not, 
            // Request a valid email from user

            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email Address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;
                //Insert code here that validates format of email
                //could use RegEx
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email address is not in the correct format");
                }
            }
            
            if(op.Success)
            {
                var isRealDomain = true;
                //Code here to check if the domain exists 
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }

            }

            return op;

        }

        public decimal CalculateGoalPercentage(string goalSteps, string actualSteps)
        {
           

            decimal actualStepCount = 0;
            decimal goalStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual steps must be entered", "actual steps");



            if(!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException ("Actual steps must be numeric");
            if(!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException ("Goal must be numeric");

            return CalculateGoalPercentage(goalStepCount, actualStepCount);
            
        }

        public decimal CalculateGoalPercentage (decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount / goalStepCount)*100, 2);
        }
    }
}
