namespace JsonTestExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new AppDbContext();

            var question = new Question
            {
                Text = "question1",
                Options = new List<OptionJson> {
                    new OptionJson {Value="opt1", IsCorrect=true},
                    new OptionJson {Value="opt2", IsCorrect=false} }
            };

            dbContext.Questions.Add(question);
            dbContext.SaveChanges();
        }
    }
}
