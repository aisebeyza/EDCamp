using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AutoLoanManager: ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
