using AngleDimension.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AngleDimension.ViewModels
{
    class WWDViewModel: BaseViewModel
    {
        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
        public WWDViewModel()
        {
            RightBMS = new List<Service>
            {
                new Service()
                {
                    Title = "Systems Integration",
                    SubTitle = "Payment systems and external systems",
                    Description = "We help you put together enterprise payment applications to achieve business process continuity, data integrity and barrier-free collaboration. By integrating enterprise solutions, we ensure that the entire software environment is flawless and secure. We realize that to achieve true financial inclusion there is a need to develop and integrate with payment systems that can reach the unbanked.",
                    Color = "#4800FF",
                    Icon = "link.png"
                },
                new Service()
                {
                    Title = "ICT Consultancy",
                    SubTitle = "Let us help you",
                    Description = "Our ICT consulting success is based on the key areas of engaging with our clients to understand what services are required and the ICT solutions they need to get the job done. This understanding of our clients' cultures and needs ensures that we provide the best person with the right skills, with the absolute focus being on the best outcome for our clients.Data Science",
                    Color = "#EA4C11",
                    Icon = "hammer.png"
                },
                new Service()
                {
                    Title = "Data Science",
                    SubTitle = "Big Data/ML Solution",
                    Description = "At Angle Dimension we help companies operating in the increasingly data-centric environment to derive strategic business value from data of multiple origins. We help you to turn data into actionable information, improve efficiency and gain competitive intelligence with our expertise of the AI/ML implementation, which can be locally hosted or hosted in the cloud while carefully understanding the data privacy issues.",
                    Color = "#17A2B8",
                    Icon = "file_code.png"
                },
            };
            LeftBMS = new List<Service>
            {
                new Service()
                {
                    Title = "Software Developemt",
                    SubTitle = "Custom Application Development Services",
                    Description = "Angle Dimension custom application development services cover third-party integration, mobile, desktop, web and Data Warehouse & BI. Once you have outlined your initial requirements, we will work with you to validate your product vision and assumptions, and then we will handle project implementation.",
                    Color = "#28A745",
                    Icon = "file.png"
                },
                new Service()
                {
                    Title = "Business Messaging",
                    SubTitle = "Messaging API Integration",
                    Description = "With our global messaging API, we help your business deliver on your customer's expectations by connecting your business directly with leading chat platforms. Customers expect to connect with businesses as easily and seamlessly as they do with their friends and family. Engage with your customers on the go by connecting your business systems to most of the world is leading chat platforms like WhatsApp, Facebook Messenger, Twitter, WeChat, Telegram and many more by integrating with our API.",
                    Color = "#FFD800",
                    Icon = "comment_alt.png"
                },
                new Service()
                {
                    Title = "SMS/IVR/USSD Services",
                    SubTitle = "Best for Feature Phones",
                    Description = "When it comes to building scalable systems in the areas of SMS, IVR and USSD Angle Dimension has a vast experience and knowledge to enable our customers integrate with our APIs to deliver services and communicate with their clients without worrying about scalability issues.",
                    Color = "#0094FF",
                    Icon = "comment_alt.png"
                }
            };
        }
        public List<Service> RightBMS { get; set; }
        public List<Service> LeftBMS { get; set; }
    }
}
