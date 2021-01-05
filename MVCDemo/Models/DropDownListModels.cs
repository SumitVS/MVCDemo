using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{

    [Table("tblCountries")]
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<State> States { get; set; }
    }


    [Table("tblStates")]
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public Country Country { get; set; }
        public List<City> Cities { get; set; }
    }


    [Table("tblCities")]
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
    }
}