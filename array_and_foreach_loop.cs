using System;
namespace MyNamespace{
    public class array_foreach{
        static void Main(string[] args){
            var months = new string[12]{"01-Jan", "02-Feb", "03-Mar", "04-Apr", "05-May", "06-Jun", "07-Jul", "08-Aug", "09-Sep", "10-Oct", "11-Nov", "12-Dec"};
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }           

        }
    }
}