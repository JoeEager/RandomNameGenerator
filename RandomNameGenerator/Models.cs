using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RandomNameGenerator
{
    public class Name
    {
        [Key]
        public string name { get; set; }
        public int rank { get; set; }
        public float percentFrequency { get; set; }
        public float cumPercentFrequency { get; set; }

    }

    public class LastName:Name
    {
        
    }

    public class FemaleFirstName : Name
    {
        
    }

    public class MaleFirstName : Name
    {

    }

    
}
