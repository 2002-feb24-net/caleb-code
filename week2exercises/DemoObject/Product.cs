using System;

namespace DemoObject
{
    class Product
    {
        string ProductID;
        int Stock;
        double StarRating;

        public void SetDefaultValues()
        {
            ProductID = "l";
            Stock = 0;
            StarRating = 5;
        }

        public void SetValues(string id, int quantity, double rating)
        {
            ProductID = id;
            Stock = quantity;
            StarRating = rating;
        }

        public override string ToString()
        {
            return "Product - " + ProductID + ", Stock - " + Stock + " Star Rating - " + StarRating;
        }
    }
}
