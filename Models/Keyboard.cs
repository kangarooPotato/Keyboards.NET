using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Keyboards.Models

{
    public class Keyboard
    {
        
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        [Display(Name = "The type of the switch")]
        public string Type { get; set; }
        
        [Range(1,200)]
        public decimal Pressure { get; set; }
    
        // public string switchColor { get; set; } // this is and auto property
        // public string switchType { get; set; }
        // public int switchPressure { get; set; }
        // public int switchNoise { get; set; }    
        // public string tag { get; set; }
        // public string imgUrl { get; set; }

        // dotnet-aspnet-codegenerator razorpage -m KeyboardsKeyboard -dc KeyboardContext -udl -outDir Pages/KeySwitchs --referenceScriptLibraries -sqlite
    }
}