using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Some Formatting */
            string myString = "Go to your c:\\ drive";  // The backslash is used for escaping, so double \\ needed for \
            string doubleQuote = "My \"so called \" life";
            string newLine = "This is a\nnew line!";
            string replaceValue = String.Format("{0} to {1}!", "Bonzai", "Nordine");
            string symbols = String.Format("Dollars: {0:C}\nPercentage: {1:P}\nComma and Period: {2:N}", 230, 0.95, 1234567.89);
            string customFormat = String.Format("Phone Number: {0:(###) ###-####}", 4045796132);

            /* To Concatenate or operate on strings more efficiently, use StringBuilder */
            StringBuilder stringArray = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                stringArray.Append("--");
                stringArray.Append(i);
            }

            /* Operations on Strings */
            string originalString = "Wesh la famille mon poto!";
            string shortString = originalString.Substring(16, 8);       // Take a Sub-string of a String
            string upperCaseString = originalString.ToUpper();          // Upper Case all letters
            string replacedString = originalString.Replace("a", "@");   // Replace "a" with "@"
            
            /* Chaining Methods together */
            string originalPhrase = "  My name is Nordine  ";
            string chainedLength = String.Format("Original Length: {0} -- Trimmed Length: {1}" , 
                originalPhrase.Length , originalPhrase.Trim().Length);  // Trim removes leading/trailing whitespaces


            /* Display on Console */
            Console.WriteLine(chainedLength);
            Console.ReadLine();
        }
    }
}
