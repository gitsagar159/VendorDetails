using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VD.Models
{
    public class ViewModel
    {
        public Customer objCustomer { get; set; }
        public Vendor objVendor { get; set; }

        public List<Customer> customertList = new List<Customer>()
        {
            new Customer{FirstName="Jhon",MiddleName="Tom",LastName="Matt",PhoneNumber1="1234567890",PhoneNumber2="456789123",
                Email ="jhon@hotmail.com",AddressLine1 ="Stree 3,victor park",AddressLine2="B/h Dental Hospital",Zipcode="123456",
                CountryName ="United State",StateName="Utha",CityName="City1"},
            new Customer{FirstName="Stephen",MiddleName="Jason",LastName="Hawlkins",PhoneNumber1="7894568520",PhoneNumber2="7898526540",
                Email ="stephan@hotmail.com",AddressLine1 ="st. shawn stree",AddressLine2="opp. amusment park",Zipcode="123789",
                CountryName ="United State",StateName="Philadelphia",CityName="City2"},
            new Customer{FirstName="Marry",MiddleName="andrew",LastName="Thopson",PhoneNumber1="7418520369",PhoneNumber2="9634567014",
                Email ="marry@hotmail.com",AddressLine1 ="D/5 Outer city township",AddressLine2="New town road",Zipcode="456753",
                CountryName ="United State",StateName="california",CityName="City3"},
        };

        public List<Vendor> vendorList = new List<Vendor>()
        {
            new Vendor{ FirstName="Maria",LastName="Gillespie",Email="MariaBGillespie@armyspy.com",
                PhoneNumber ="979-376-8692",Website="www.Maria.com",SiteUrl="www.Maria.com/about",
                LicenceNumber ="4485 8996 4977 5138",VendorCode="720",ShopNumber="7/2021"},

            new Vendor{ FirstName="Robert",LastName="Orth",Email="RobertDOrth@rhyta.com",
                PhoneNumber ="267-498-6603",Website="www.Robert.com",SiteUrl="www.Robert.com/about",
                LicenceNumber ="4929 2551 0056 7130",VendorCode="661",ShopNumber="3/2020"},

            new Vendor{ FirstName="John",LastName="Youngberg",Email="JohnBYoungberg@jourrapide.com",
                PhoneNumber ="530-216-0319",Website="www.Maria.com",SiteUrl="www.Maria.com/about",
                LicenceNumber ="4929 8689 2273 5394",VendorCode="045",ShopNumber="6/2022"},
        };
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Zipcode { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
    }

    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string SiteUrl { get; set; }
        public string LicenceNumber { get; set; }
        public string VendorCode { get; set; }
        public string ShopNumber { get; set; }
    }
}