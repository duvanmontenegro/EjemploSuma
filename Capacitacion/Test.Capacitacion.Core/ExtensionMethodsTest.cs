using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core
{
    public class AnyClass
    {
        private readonly int _items;
        private readonly string _cathegory;

        public AnyClass(int items, string cathegory)
        {
            _items = items;
            _cathegory = cathegory;
        }

        public string GetMessage()
        {
            var response = $"{_cathegory}:{_items}";
            return response;
        }
    }


    public static class AnyClassExtension
    {
        public static (string, int) GetValues(this AnyClass instance) 
        {
            var values = instance.GetMessage().Split(':', StringSplitOptions.RemoveEmptyEntries);
            return (values[0], int.Parse(values[1]));
        }
    }

    public static class LoggerExtensions
    {
        public static string GetLogString(this string input)
        {
            var output = $"{DateTimeOffset.Now.ToString("dd-MM-yyyy HH:mm:ss")} >>> {input} <<<";
            return output;
        }
    }

    public class ExtensionMethodsTest
    {
        [Fact]
        [IntegrationTest]
        public async Task Use_GetValues_Extension_Method_Test()
        {
            var anyClass = new AnyClass(5, "Fresas");
            var description = anyClass.GetMessage();
            var tupleDescription = anyClass.GetValues();
        }

        [Fact]
        [IntegrationTest]
        public async Task Use_GetLogString_Extension_Method_Test()
        {
            var anyClass = new AnyClass(5, "Fresas");
            
            var description = anyClass.GetMessage();
            var logLine = description.GetLogString();
            Console.WriteLine(logLine);

            var tupleDescription = anyClass.GetValues();
        }
    }
}
