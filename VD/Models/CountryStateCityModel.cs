using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VD.Models
{
    public class CountryStateCityModel
    {
        //public List<Country> CountryList = new List<Country>()
        //{
        //    new Country {CountryName="Afghanistan" ,CountryValue = "Afghanistan"},
        //    new Country {CountryName="Aland Islands" ,CountryValue = "Aland Islands"},
        //    new Country {CountryName="Albania" ,CountryValue = "Albania"},
        //    new Country {CountryName="Algeria" ,CountryValue = "Algeria"},
        //    new Country {CountryName="American" ,CountryValue = "American"},
        //    new Country {CountryName="Andorra" ,CountryValue = "Andorra"},
        //    new Country {CountryName="Angola" ,CountryValue = "Angola"},
        //    new Country {CountryName="India" ,CountryValue = "India"},
        //    new Country {CountryName="United State" ,CountryValue = "United State"},
        //    new Country {CountryName="United Kindom" ,CountryValue = "United Kindom"},
        //};

        public List<SelectListItem> CountryList = new List<SelectListItem>()
        {
            new SelectListItem {Text="Afghanistan" ,Value = "Afghanistan"},
            new SelectListItem {Text="Aland Islands" ,Value = "Aland Islands"},
            new SelectListItem {Text="Albania" ,Value = "Albania"},
            new SelectListItem {Text="Algeria" ,Value = "Algeria"},
            new SelectListItem {Text="American" ,Value = "American"},
            new SelectListItem {Text="Andorra" ,Value = "Andorra"},
            new SelectListItem {Text="Angola" ,Value = "Angola"},
            new SelectListItem {Text="India" ,Value = "India"},
            new SelectListItem {Text="United State" ,Value = "United State"},
            new SelectListItem {Text="United Kindom" ,Value = "United Kindom"}
        };


        public List<SelectListItem> StateList = new List<SelectListItem>()
        {
            new SelectListItem {Text="California" ,Value = "California"},
            new SelectListItem {Text="Hawaii" ,Value = "Hawaii"},
            new SelectListItem {Text="Florida" ,Value = "Florida"},
            new SelectListItem {Text="Texas" ,Value = "Texas"},
            new SelectListItem {Text="Massachusetts" ,Value = "Massachusetts"},
            new SelectListItem {Text="Alabama" ,Value = "Alabama"},
            new SelectListItem {Text="Cantukye" ,Value = "Cantukye"},
            new SelectListItem {Text="Georgea" ,Value = "Georgea"},
            new SelectListItem {Text="Utah" ,Value = "Utah"},
        };
    }

    public class Country
    {
        public string CountryName { get; set; }
        public string CountryValue { get; set; }
    }

    public class State
    {
        public string StateName { get; set; }
        public string StateValue { get; set; }
    }

    public class City
    {
        public string CityName { get; set; }
        public string CityValue { get; set; }
    }

}