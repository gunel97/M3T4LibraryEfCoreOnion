using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTestExample
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public List<OptionJson> Options { get; set; } = new();
    }
    public class OptionJson
    {
        public string Value { get; set; } = null!;
        public bool IsCorrect { get; set; }
    }
}
