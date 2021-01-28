using System;
using System.Collections.Generic;

namespace OOP3
{
    //yazılımda sürdürülebilirliği sağlar
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalLoanManager = new PersonalLoanManager();
            ILoanManager autoLoanManager = new AutoLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

           List<ILoggerService> loggers = new List<ILoggerService>
                {new SmsLoggerService(), new FileLoggerService()};

           ApplyManager applyManager = new ApplyManager();
           // applyManager.ApplyNow(personalLoanManager,fileLoggerService); //new DatabaseLoggerService() şeklinde de yazılabilir
           applyManager.ApplyNow(new TradesmenLoanManager(), loggers);
           // applyManager.ApplyNow(new TradesmenLoanManager(), new List<ILoggerService>(){new DatabaseLoggerService(),new SmsLoggerService()});

            List<ILoanManager> loans = new List<ILoanManager>() { personalLoanManager,autoLoanManager };
            //applyManager.LoanPrequalificaiton(loans);
        }
   }
}
