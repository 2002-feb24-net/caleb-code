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

        public override string ToString()
        {
            return "Product " + ProductID + ", " + Stock + " left in stock, with a " + StarRating + " star rating.";
        }
    }
}
