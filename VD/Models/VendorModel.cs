using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VD.Models
{
    public class VendorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }

    public class VendorViewmodel
    {
        public List<VendorModel> VendorList = new List<VendorModel>()
        {
           new VendorModel {FirstName="Mari", LastName="Uplinger", PhoneNumber="123456789",City="Springfield",State="Alabama",ZipCode="465123",Email="mari@gmail.com",Website="www.mari.com"},
            new VendorModel {FirstName="Stuart", LastName="Lorenzo", PhoneNumber="465131654",City="Franklin",State="Alaska",ZipCode="789456",Email="Stuart@gmail.com",Website="www.Stuart.com"},
            new VendorModel {FirstName="Madlyn", LastName="Eichman", PhoneNumber="5465131251",City="Clinton",State="California",ZipCode="123456",Email="Madlyn@gmail.com",Website="www.Madlyn.com"},
            new VendorModel {FirstName="Ludie", LastName="Nutter", PhoneNumber="1324564654",City="Fairview",State="Connecticut",ZipCode="159624",Email="Ludie@gmail.com",Website="www.Ludie.com"},
            new VendorModel {FirstName="Ligia", LastName="Buchanon", PhoneNumber="13121321",City="Salem",State="Louisiana",ZipCode="102365",Email="Buchanon@gmail.com",Website="www.Buchanon.com"},
            new VendorModel {FirstName="Niki", LastName="Casarez", PhoneNumber="321231561",City="Madison",State="Georgia",ZipCode="147852",Email="Casarez@gmail.com",Website="www.Casarez.com"},
            new VendorModel {FirstName="Jolyn", LastName="Chard", PhoneNumber="2122132132",City="Georgetown	",State="Indiana",ZipCode="852369",Email="Chard@gmail.com",Website="www.Chard.com"},
            new VendorModel {FirstName="Marquerite", LastName="Sulik",PhoneNumber="21561564312",City="Washington",State="Maryland",ZipCode="456789",Email="Marquerite@gmail.com",Website="www.Marquerite.com"},
            new VendorModel {FirstName="Sandy", LastName="Vanderslice", PhoneNumber="132165456",City="Madison",State="Massachusetts",ZipCode="263487",Email="Sandy@gmail.com",Website="www.Sandy.com"},
            new VendorModel {FirstName="Jacob", LastName="Dunkle", PhoneNumber="1354564132",City="Georgetown",State="Montana",ZipCode="485965",Email="Jacob@gmail.com",Website="www.Jacob.com"},
            new VendorModel {FirstName="Vilma", LastName="Umberger", PhoneNumber="212316512",City="Clinton",State="Tennessee",ZipCode="563241",Email="Vilma@gmail.com",Website="www.Vilma.com"},
            new VendorModel {FirstName="Klara", LastName="Bello", PhoneNumber="212313213",City="Springfield",State="North Carolina",ZipCode="123456",Email="Klara@gmail.com",Website="www.Klara.com"},
            new VendorModel {FirstName="Daphine", LastName="Eckley", PhoneNumber="21465431",City="Salem",State="Oklahoma",ZipCode="789123",Email="Daphine@gmail.com",Website="www.Daphine.com"}

        };
    }
}