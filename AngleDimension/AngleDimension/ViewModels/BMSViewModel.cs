using AngleDimension.Models;
using AngleDimension.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AngleDimension.ViewModels
{
    class BMSViewModel: BaseViewModel
    {
        public BMSViewModel()
        {
            BServices = new List<BService>
            {
                new BService()
                {
                    Title ="WhatsApp",
                    Description = "Get direct access to Official APIs and build your own custom solutions using WhatsApp Business APIs and get more benefits.",
                    Icon = "wa.jpg"
                },
                new BService()
                {
                    Title ="Bulk SMS",
                    Description = "Our SMS gateway service can help you turbo charge your customer engagement..",
                    Icon = "sms.jpg"
                },
                new BService()
                {
                    Title ="Bulk Email",
                    Description = "Bulk Email service built with scalability in mind to deliver the message on time.",
                    Icon = "email.jpg"
                },
                new BService()
                {
                    Title ="USSD",
                    Description = "USSD remains the most powerful tool in Africa, let us help you reach your numbers.",
                    Icon = "ussd.jpg"
                },
            };
        }
        public List<BService> BServices { get; set; }
    }
}
