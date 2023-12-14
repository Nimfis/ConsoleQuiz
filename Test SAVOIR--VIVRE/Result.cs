using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Test_SAVOIR__VIVRE
{
    internal class Result
    {
        [DataMember]
        public string PlayerName { get; init; }

        [DataMember]
        public int Score { get; init; }

        [DataMember]
        public int TotalQuestions { get; init; }

        [DataMember]
        public DateTime Date { get; init; }

        private const string ResultFileName = "quiz_results.json";

        private static List<Result> results;

        public Result(string playerName, int score, int totalQuestions, DateTime now)
        {
            PlayerName = playerName;
            Score = score;
            TotalQuestions = totalQuestions;
            Date = now;
        }

        public static void SaveResult(string playerName, int score, int totalQuestions)
        {
            List<Result> results = LoadResults();
            Result newResult = new Result(playerName, score, totalQuestions, DateTime.Now);
            results.Add(newResult);

            string json = JsonConvert.SerializeObject(results, Formatting.Indented);
            File.WriteAllText(ResultFileName, json);
        }
        private static List<Result> GetSortedResults()
        {
            return results.OrderByDescending(r => r.Score).ThenBy(r => r.Date).Take(10).ToList();
        }

        public static void DisplayResults()
        {
            results = LoadResults();

            int rank = 1;

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine();
            TextCenterer.PrintCenteredText(" - - - - - - - - - RANKING - - - - - - - - - ");
            Console.WriteLine();

            Console.ResetColor();

            foreach (var result in GetSortedResults())
            {
                TextCenterer.PrintCenteredText($"{rank}. {result.PlayerName} - Punkty: {result.Score}/{result.TotalQuestions} - Data: {result.Date}");
                rank++;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine();
            TextCenterer.PrintCenteredText(" - - - - - - - - - - - - - - - - - - - - - - ");

            Console.ResetColor();
        }

        private static List<Result> LoadResults()
        {
            List<Result> results;
            if (File.Exists(ResultFileName))
            {
                string json = File.ReadAllText(ResultFileName);
                var deserializedJson = JsonConvert.DeserializeObject<List<Result>>(json);
                if (deserializedJson is null)
                {
                    throw new Exception($"{nameof(deserializedJson)} is null.");
                }

                results = deserializedJson;
            }
            else
            {
                results = new List<Result>();
            }

            return results;
        }
    }
}