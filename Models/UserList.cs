using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{
    public class UserList
    {
        //this is the model for the userlist of their suggested restaurants
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Restaurant Name is required")]
        public string RestName { get; set; }
        [Required(ErrorMessage = "Favorite Food is required")]
        
        public string FavFood { get; set; }
        [RegularExpression(@"^[0-9]{3}([- /]?[0-9]{3}([- /])?[0-9]{4}([- /])?$)", ErrorMessage = "Phone Number is required")]
        public string PhoneNum { get; set; }
    }
}
