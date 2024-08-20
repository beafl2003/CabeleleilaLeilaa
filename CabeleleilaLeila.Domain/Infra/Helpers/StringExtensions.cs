using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Domain.Infra.Helpers
{
    public static class StringExtensions
    {

        public static bool IsNumeric(string input)
        {
            double teste;
            return double.TryParse(input, out teste);
        }

        public static bool HasUpperCase(string input) 
        
        {
            return input.Any(char.IsUpper);
        }
    }
}
