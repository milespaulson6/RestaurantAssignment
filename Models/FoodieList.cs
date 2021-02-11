using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAssignment.Models
{//Here is my foodie list for each object with the getters and setters
    public class FoodieList
    {
        public FoodieList(int ranking)
        {
            Rank = ranking;
        }
        [Required(ErrorMessage = "Rank is required")]
        
        public int? Rank { get; }
        [Required(ErrorMessage = "Restaurant Name is required")]
        public string RestName { get; set; }

        public string FavDish { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Addy { get; set; }

        public string Phone { get; set; }
        #nullable enable
        public string? Website { get; set; } = "Coming Soon!";
        #nullable enable  
        //here is the get function that is called that puts it into an array
        public static FoodieList[] getFoodieList()
        {
            FoodieList f1 = new FoodieList(1)
            {
               
                RestName = "El Mexsal",
                FavDish = "Una pupusa revuelta",
                Addy = "325 South Freedom Boulevard, Provo UT 84601",
                Phone = "801-375-3468",
                


            };
            FoodieList f2 = new FoodieList(2)
            {
                
                RestName = "Hruskas Kolaches",
                FavDish = "Kolache",
                Addy = "434 W Center St, Provo, UT 84604",
                Phone = "801-623-3578",
                


            };
            FoodieList f3 = new FoodieList(3)
            {
                
                RestName = "BYU Creamery",
                FavDish = "Ice Cream",
                Addy = "1209 N 900 E, Provo, UT 84604",
                Phone = "801-422-2663",
                


            };
            FoodieList f4 = new FoodieList(4)
            {
                
                RestName = "Walmart",
                FavDish = "Frozen Taquitos",
                Addy = "1355 Sandhill Rd, Orem, UT 84058",
                Phone = "801-221-0600",
                Website = "walmart.com"


            };
            FoodieList f5 = new FoodieList(5)
            {
                
                RestName = "Itto Sushi",
                FavDish = "Firebird",
                Addy = "547 E University Pkwy, Orem, UT 84097",
                Phone = "385-497-7045",
                


            };
            //this returns the new array
            return new FoodieList[] { f1, f2, f3, f4, f5 };

        }


    }
}
