using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        //method injection
        public void ApplyNow(ILoanManager loanManager,List<ILoggerService> loggerServices)//hepsinin referansını tutuyor
        {
            //başvuran bilgilerini değerlendirme
            //bütün başvuruları konut kredisine bağımlı hale getirmiş olursun
            // MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            // mortgageLoanManager.Calculate();

            //başvuruyu kredi bağımsız hale getirme:
            loanManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        //requiredLoan
        public void LoanPrequalificaiton(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
//interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız