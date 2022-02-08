using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CoffeeSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;

            do
            {
                Console.WriteLine("Please specify a report to run (rewards, comments, tasks, quit):");
                var selectedReport = Console.ReadLine();

                Console.WriteLine("Please specify which quarter of data: (q1,q2)");
                var selectedData = Console.ReadLine();

                var surveyResults = JsonConvert.DeserializeObject<SurveyResults>(File.ReadAllText($"data/{selectedData}.json"));


                switch (selectedReport)
                {
                    case "rewards":
                        GenerateWinnerEmails(surveyResults);
                        break;
                    case "comments":
                        GenerateTaskReport(surveyResults);
                        break;
                    case "tasks":
                        GenerateCommentsReport(surveyResults);
                        break;
                    case "quit":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, thats not a valid option.");
                        break;
                }
                Console.WriteLine();
            } while (!quitApp);
        }

        public static void GenerateWinnerEmails(SurveyResults results)
        {
            var selectedEmails = new List<string>();
            int counter = 0;

            Console.WriteLine(Environment.NewLine + "Selected Winners Output:");
            while (selectedEmails.Count < 2 && counter < results.Responses.Count)
            {
                var currentItem = results.Responses[counter];
                if (currentItem.FavoriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }
                counter++;
            }
            File.WriteAllLines("WinnersReport.csv", selectedEmails);
        }

        public static void GenerateCommentsReport(SurveyResults results)
        {
            var comments = new List<string>();
            Console.WriteLine(Environment.NewLine + "Comments Output:");
            for (var i = 0; i < results.Responses.Count; i++)
            {
                var currentResponse = results.Responses[i];

                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                    comments.Add(currentResponse.Comments);
                }
            }

            foreach (var response in results.Responses)
            {
                if (response.AreaToImprove == results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                    comments.Add(response.Comments);
                }
            }

            File.WriteAllLines("CommentsReport.csv", comments);
        }

        public static void GenerateTaskReport(SurveyResults results)
        {
            var tasks = new List<string>();

            //Calculated values
            double responseRate = results.NumberResponded / results.NumberSurveyed;
            double overallScore = (results.ServiceScore + results.CoffeeScore + results.FoodScore + results.PriceScore) / 4;

            //Logical Comparison
            if (results.CoffeeScore < results.FoodScore)
            {
                tasks.Add("Investigate coffee recipes and ingredients.");
            }

            tasks.Add(overallScore > 8.0 ? "Work with leadership" : "Work with employees for improvement ideas.";
);
            //var newTask = overallScore > 8.0 ? "Work with leadership" : "Work with employees for improvement ideas.";
            //tasks.Add(newTask);
            if (overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas.");
            }


            if (responseRate < .33)
            {
                tasks.Add("Research options to imporve response rate.");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Rewards participants with free coffee coupon.");
            }
            else
            {
                tasks.Add("Rewards participants with discount coffee coupon.");
            }
            //tasks.Add(responseRate switch
            //{
            //    var rate when rate < .33 => "Research options to imporve response rate.",
            //    var rate when rate > .33 && rate < .66 => "Rewards participants with free coffee coupon.",
            //    var rate when rate > .66 => "Rewards participants with discount coffee coupon."
            //});

            tasks.Add(results.AreaToImprove switch
            {
                "RewardsProgram" => "Revisit the rewards deals.",
                "Cleanliness" => "Contact the cleaning vendor",
                "MobileApp" => "Contact the consulting firm about the app.",
                _ => "Investigate individual comments for ideas."
            });

            //var improveTask = results.AreaToImprove switch
            //{
            //    "RewardsProgram" => "Revisit the rewards deals.",
            //    "Cleanliness" => "Contact the cleaning vendor",
            //    "MobileApp" => "Contact the consulting firm about the app.",
            //    _ => "Investigate individual comments for ideas."
            //};
            //tasks.Add(improveTask);

            //switch (results.AreaToImprove)
            //{
            //    case "RewardsProgram":
            //        tasks.Add("Revisit the rewards deals.");
            //        break;
            //    case "Cleanliness":
            //        tasks.Add("Contact the cleaning vendor.");
            //        break;
            //    case "MobileApp":
            //        tasks.Add("Contact cosulting firm about app.");
            //        break;
            //    default:
            //        tasks.Add("Investigate individual comments for idea.");
            //        break;
            //}

            Console.WriteLine(Environment.NewLine + "Tasks Output:");
            foreach(var task in tasks)
            {
                Console.WriteLine(task);
            }
            File.WriteAllLines("TasksReport.csv", tasks);
        }
    }
}
