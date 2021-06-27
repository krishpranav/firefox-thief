using System;
using System.Text.RegularExpressions;

namespace Stealer.Helpers
{
    internal sealed class Json
    {
        public string Data;
        public Json(string Data)
        {
            this.Data = data;
        }
        public string GetValue(string value)
        {
            string result = String.Empty;
            Regex valueRegex = new Regex($"\"{value}\":\"([^\"]+)\"");
            Match valueMatch = valueRegex.Match(this.Data);
            if (!valueMatch.Success)
                return result;
            
            result = Regex.Split(valueMatch.Value, "\"")[3];
            return result;
        }
        public void Remove(string[] values)
        {
            foreach (string value in values)
                this.Data = this.Data.Replace(value, "");
        }
    }
}