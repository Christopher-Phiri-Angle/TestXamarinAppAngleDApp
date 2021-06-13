using AngleDimension.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngleDimension.ViewModels
{
    class HomeViewModel: BaseViewModel
    {
        public HomeViewModel()
        {
            Products = GetProducts();
        }
        public List<Product> Products { get; set; }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Title = "Khusa", Image = "khusa_logo.png",
                    Description = "Bring your Banki Mkhonde to Khusa and let us do the science." },
                new Product { Title = "SmartIdentity", Image = "logo.png",
                    Description = "Our centralised e-KYC solution for your business to combat identity fraud." },
                 new Product { Title = "Aspect Financials 360", Image = "af_logo.png",
                    Description = "Automate your SACCO, Micro-finance institution with our industry proven solution" }
            };
        }
    }
}
