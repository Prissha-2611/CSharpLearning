using System;
using System.Collections.Generic;

namespace CoffeeSurvey
{
    public class SurveyResults
    //public static class Q1Results
    {
        //Aggregate ratings
        public double ServiceScore { get; set; }
        public double CoffeeScore { get; set; }
        public double PriceScore { get; set; }
        public double FoodScore { get; set; }
        public double WouldRecommend { get; set; }
        public string FavoriteProduct { get; set; }
        public string LeastFavouriteProduct { get; set; }
        public string AreaToImprove { get; set; }
        //Aggregate counts
        public double NumberSurveyed { get; set; }
        public double NumberResponded { get; set; }
        public double NumberRewardsMembers { get; set; }

        ////Aggregate ratings
        //public static double ServiceScore { get; set; } = 8.0;
        //public static double CoffeeScore { get; set; } = 8.5;
        //public static double PriceScore { get; set; } = 6.0;
        //public static double FoodScore { get; set; } = 7.5;
        //public static double WouldRecommend { get; set; } = 6.5;
        //public static string FavoriteProduct { get; set; } = "Cappucino";
        //public static string LeastFavouriteProduct { get; set; } = "Granola";
        //public static string AreaToImporve { get; set; } = "MobileApp";
        ////Aggregate counts
        //public static double NumberSurveyed { get; set; } = 500;
        //public static double NumberResponded { get; set; } = 325;
        //public static double NumberRewardsMembers { get; set; } = 130;

        //Individual survey responses
        public List<SurveyReponse> Responses { get; set; }
        //public static List<SurveyReponse> Responses = new List<SurveyReponse>()
        //{
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test1@sample.com",
        //        CoffeeScore = 8.0,
        //        FoodScore = 9.0,
        //        PriceScore = 7.0,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "MobileApp",
        //        FavoriteProduct ="Latte",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 8.0,
        //        Comments = "Your mobile app is too slow."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test2@sample.com",
        //        CoffeeScore = 10.0,
        //        FoodScore = 6.0,
        //        PriceScore = 7.0,
        //        ServiceScore = 7.5,
        //        AreaToImprove = "MobileApp",
        //        FavoriteProduct ="Cappucino",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 8.0,
        //        Comments = "The mobile app looks bad on android devices."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test3@sample.com",
        //        CoffeeScore = 8.0,
        //        FoodScore = 7.0,
        //        PriceScore = 6.5,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "Cleanliness",
        //        FavoriteProduct ="Americano",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 8.0,
        //        Comments = "Overall I had a great experience, I like the store design."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test4@sample.com",
        //        CoffeeScore = 9.0,
        //        FoodScore = 5.0,
        //        PriceScore = 7.5,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "Pricing",
        //        FavoriteProduct ="Cappucino",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 4.0,
        //        Comments = "The pickup area should be by the door. Also Your prices are much higher."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test5@sample.com",
        //        CoffeeScore = 8.0,
        //        FoodScore = 7.0,
        //        PriceScore = 6.5,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "Other",
        //        FavoriteProduct ="Iced Coffee",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 6.0,
        //        Comments = "I like the stores but your coffee is too expensive."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test6@sample.com",
        //        CoffeeScore = 8.0,
        //        FoodScore = 7.0,
        //        PriceScore = 6.5,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "MobileApp",
        //        FavoriteProduct ="Green tea macha",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 7.5,
        //        Comments = "Your staff are very friendly but your mobile app is too slow."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test7@sample.com",
        //        CoffeeScore = 8.0,
        //        FoodScore = 7.0,
        //        PriceScore = 6.5,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "MobileApp",
        //        FavoriteProduct ="Green tea macha",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 7.5,
        //        Comments = "The mobile app doesnt work on tablets."
        //    },
        //    new SurveyReponse()
        //    {
        //        EmailAddress = "test8@sample.com",
        //        CoffeeScore = 8.0,
        //        FoodScore = 7.0,
        //        PriceScore = 6.5,
        //        ServiceScore = 8.5,
        //        AreaToImprove = "MobileApp",
        //        FavoriteProduct ="Green tea macha",
        //        LeastFavouriteProduct = "Fruit",
        //        WouldRecommend = 6.5,
        //        Comments = "So close to recommending but your prices are so high."
        //    }
        //};
    }

}
