//using PayPal.Api;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using TrashPickup.Models;

//namespace TrashPickup.Services
//{
//    public class PayPalPaymentService
//    {
//        public static Payment CreatePayment(string baseUrl, string intent)
//        {
//            var apiContext = PayPalConfiguration.GetAPIContext();
//            // Payment Resource
//            var payment = new Payment()
//            {
//                intent = "sale",
//                payer = new Payer() { payment_method = "paypal" },
//                transactions = GetTransactionsList(),
//                redirect_urls = GetReturnUrls(baseUrl, intent)
//            };
//            // Create a payment using a valid APIContext
//            var createdPayment = payment.Create(apiContext);
//            return createdPayment;
//        }

//        private static List<Transaction> GetTransactionsList()
//        {
//            ApplicationDbContext db = new ApplicationDbContext();
//            var transactionList = new List<Transaction>();
//            transactionList.Add(new Transaction()
//            {
//                description = "Amount due for trash pickups.",
//                invoice_number = new Random().ToString(),
//                amount = new Amount()
//                {
//                    currency = "USD",
//                    total = "10",  
//                },
//            });
//            return transactionList;
//        }

//        private static RedirectUrls GetReturnUrls(string baseUrl, string intent)
//        {
//            var returnUrl = intent == "sale" ? "/Home/PaymentSuccessful" : "/Home/AuthorizeSuccessful";
//            return new RedirectUrls()
//            {
//                cancel_url = baseUrl + "/Home/PaymentCancelled",
//                return_url = baseUrl + returnUrl
//            };
//        }

//        public static Payment ExecutePayment(string paymentId, string payerId)
//        {
//            var apiContext = PayPalConfiguration.GetAPIContext();
//            var paymentExecution = new PaymentExecution() { payer_id = payerId };
//            var payment = new Payment() { id = paymentId };
//            var executedPayment = payment.Execute(apiContext, paymentExecution);
//            return executedPayment;
//        }
//    }
//}