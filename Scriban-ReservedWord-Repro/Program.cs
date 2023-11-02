using Scriban;

namespace Scriban_ReservedWord_Repro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTemplate = Template.Parse("Hello this is a {{ headerComment }}, this is a name: {{ name }}");

            // headerComment doesn't get replaced, name does ---- why?
            var result = myTemplate.Render(new {headerComment = "header comment.", Name = "John Doe." });


            Console.WriteLine(result);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}