using System;
using System.ComponentModel.DataAnnotations;
namespace Keyboards.Modles

{
    public class Keyboard
    {
        
        public int ID { get; set; }
        public string Color { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public decimal Pressure { get; set; }
    
        // public string switchColor { get; set; } // this is and auto property
        // public string switchType { get; set; }
        // public int switchPressure { get; set; }
        // public int switchNoise { get; set; }    
        // public string tag { get; set; }
        // public string imgUrl { get; set; }
    }
}