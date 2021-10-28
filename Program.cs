using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string additionalData = "-000010816512020112520201216+00000000000+00000000000+00010850700-000010816510000000000000000+00000000+00020642844+00020000000-0000800000020200716+00000000000586  +00000000000 LIABILITY DEPTT                         FAYSAL BANKING SHOP # 7,8,9,10,17,18,19 SALEEM PLAZA FL-1 BLOCK C               BLOCK 16 GULSHAN E IQBAL                KARACHI                                           KARACHI                                                       20200318+0001324300000+0000000000000+00000000000MR NOMAN AIJAZ                                  ]";

            string additionalData = "-0000108165120201216+00000000000+00000000000+00010850700-000010816510000000000000000+00000000+00020642844+00020000000-0000800000020200716+00000000000586  +00000000000 LIABILITY DEPTT                         FAYSAL BANKING SHOP # 7,8,9,10,17,18,19 SALEEM PLAZA FL-1 BLOCK C               BLOCK 16 GULSHAN E IQBAL                KARACHI                                           KARACHI                                                       20200318+0001324300000+0000000000000+00000000000MR NOMAN AIJAZ                                  ";
            //additionalData = additionalData.Substring(0, 12) + additionalData.Substring(20);
            Console.Out.WriteLine(additionalData);


            string amountDue = additionalData.Substring(0, 12);
            string dueDate = additionalData.Substring(12, 8);
            string minPaymentDue = additionalData.Substring(20, 12);
            string totalCashAdvanceLimit = additionalData.Substring(32, 12);
            string availableCashAdvanceLimit = additionalData.Substring(44, 12);
            string outstandingBalance = additionalData.Substring(56, 12);
            string rewardsEarned = additionalData.Substring(68, 8);
            string rewardsRedeemed = additionalData.Substring(76, 8);
            string rewardsAvailable = additionalData.Substring(84, 9);
            string availableCreditLimit = additionalData.Substring(93, 12);
            string totalCreditLimit = additionalData.Substring(105, 12);
            string lastPaymentAmount = additionalData.Substring(117, 12);
            string lastPaymentDate = additionalData.Substring(129, 8);
            string totalCurrentSpending = additionalData.Substring(137, 12);
            string currencyCode = additionalData.Substring(149, 3);
            string cardstatusCode = additionalData.Substring(152, 1);
            string plasticCode = additionalData.Substring(153, 1);
            string feeWaiverSpending = additionalData.Substring(154, 12);



            Console.ReadKey();



        }
    }
}
