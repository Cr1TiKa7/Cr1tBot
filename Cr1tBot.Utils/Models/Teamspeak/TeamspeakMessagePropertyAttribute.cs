using System;
namespace Cr1tBot.Utils.Models.Teamspeak
{
    public class TeamspeakMessagePropertyAttribute : Attribute
    {
        public string PropertyName { get; set; }

        public TeamspeakMessagePropertyAttribute(string propertyName = "")
        {
            PropertyName = propertyName;
        }
    }
}
