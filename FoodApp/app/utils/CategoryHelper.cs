using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.app.utils
{
    public static class Category
    {
        public const string MainCourse = "Main Course";
        public const string Seafood = "Seafood";
        public const string Beverages = "Beverages";
        public const string Grocery = "Grocery";
        public const string Desserts = "Desserts";
        public const string FastFood = "Fast Food";
        public const string Breakfast = "Breakfast";
        public const string Appetizers = "Appetizers";
        public const string Noodles = "Noodles";
    }

    class CategoryHelper
    {
        // Initialize a list with all category strings from the Category class
        static List<string> categories = new List<string>
    {
        Category.MainCourse,
        Category.Seafood,
        Category.Beverages,
        Category.Grocery,
        Category.Desserts,
        Category.FastFood,
        Category.Breakfast,
        Category.Appetizers,
        Category.Noodles
    };

        // Optionally, you can add a method to get the categories list
        public static List<string> GetCategories()
        {
            return categories;
        }
    }

}
