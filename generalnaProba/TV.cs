using System;
using System.Collections.Generic;
using System.Text;

namespace generalnaProba
{
    public class TV
    {
        string brand;
        string model;
        //List<string> supportedRemotes;
        public List<string> SupportedRemotes { get; set; }//kao properti

        public TV(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
            SupportedRemotes = new List<string>();
            //supportedRemotes = new List<string>();
        }

        public TV() : this("toshiba", "TV1")
        { }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get; set; }     //properti objedinjuje atribut geter i seter
        public string ShowPicture() { return "---picturee----"; }
        public override string ToString()
        {
            return $"{Brand} {Model}";
        }

    }
}
