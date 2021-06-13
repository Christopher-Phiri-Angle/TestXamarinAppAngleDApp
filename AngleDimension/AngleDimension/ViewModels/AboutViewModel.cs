using AngleDimension.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngleDimension.ViewModels
{
    class AboutViewModel: BaseViewModel
    {
        public AboutViewModel()
        {
            People = GetPeople();
        }
        public List<Person> People { get; set; }

        private List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person() {
                    Name = "Sokwani Munthali",
                    Title = "CEO/CO-FOUNDER",
                    Description = "Our Chief Executive Officer captains the ship and ensures that we are heading in the right direction.",
                    Image = "sokwani.png"
                },
                new Person() {
                    Name = "Bram Fudzulani",
                    Title = "CCO/CO-FOUNDER",
                    Description = "Our Chief Commercial Officer oversees our commercial strategy and ensures that our client’s get quality products and services, as well as support, at all times.",
                    Image = "bram.png"
                },
                new Person() {
                    Name = "Henry Sauzande",
                    Title = "CTO/CO-FOUNDER",
                    Description = "Our Chief Technology Officer governs the heart of our business and oversees the technical teams within the company.",
                    Image = "henry.png"
                },
                new Person() {
                    Name = "Dr. Kondwani Kamoto",
                    Title = "CRD/CO-FOUNDER",
                    Description = "Our Chief of Research and Development is in charge of research and development (R&D) activities that support current and future business goals.",
                    Image = "kmkamoto.jpg"
                },
            };
        }
    }
}
