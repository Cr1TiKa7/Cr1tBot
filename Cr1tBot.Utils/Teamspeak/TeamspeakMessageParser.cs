using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Cr1tBot.Utils.Models.Teamspeak;

namespace Cr1tBot.Utils.Teamspeak
{
    internal class TeamspeakMessageParser
    {

        private Regex _msgRegex = new Regex("(\\b\\w+)=(.*?(?=\\s\\w+=|$))");
        public T Parse<T>(string message)
        {
            message = message.Split('\n')[0];
            var ret = Activator.CreateInstance<T>();
            var type = typeof(T);
            var properties = type.GetProperties();


            var matches = _msgRegex.Matches(message);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    foreach (var property in properties)
                    {
                        var attribute = (TeamspeakMessagePropertyAttribute)property.GetCustomAttributes(typeof(TeamspeakMessagePropertyAttribute),true).FirstOrDefault();
                        if (attribute != null)
                        {
                            if (attribute.PropertyName.Equals(match.Groups[1].Value))
                            {
                                property.SetValue(ret,match.Groups[2].Value.Replace("\\s"," "));
                            }
                        }
                    }
                }
            }

            return ret;
        }

        public List<T> ParseList<T>(string message)
        {
            var ret = Activator.CreateInstance<List<T>>();
            message = message.Split('\n')[0];

            var items = message.Split('|');

            foreach (var item in items)
            {
                var result = Parse<T>(item);
                if (result != null)
                    ret.Add(result);
            }

            return ret;
        }
    }
}
