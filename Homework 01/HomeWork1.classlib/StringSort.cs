using System;
using System.Text;
using System.Linq;
namespace HomeWork1.classlib
{
    public class StringSort : ITextSorting
    {   
        public string SortByAlphabetical(string text)
        {
            var sb = new StringBuilder();
            var subString = text.Split(',');
            // Array.Sort(subString);
            // OrderBy มัน return ค่า ต้องมีตัวมารับค่า 
            var result = subString.OrderBy(it => it);
            var sortString = String.Join(",",result);
            return sb.Append(sortString).ToString();
        }
    } 
}
