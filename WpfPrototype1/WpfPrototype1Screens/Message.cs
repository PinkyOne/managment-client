using System;
using System.Text;
using System.Text.RegularExpressions;

namespace WpfPrototype1Screens
{
    class Message
    {
        StringBuilder json;
        public Message(string response="")
        {
            json = response != null && response==""
                ?new StringBuilder("{}")
                :new StringBuilder(response);

        }

        public string GetProperty(string property)
        {
            Regex regex = 
                new Regex("\""+property+"\":(\"\\w+\"|{}|{[A-Za-z0-9\"{}:]+})");
            Match m = regex.Match(json.ToString());
            string value = null;
            if (m.Success)
            {
                value=m.Groups[1].Value;
            }
            
            return value;
        }

        public void AddProperty(string property, string value) { 
            json.Insert(1, "\"" + property + "\":\"" + value + "\","); 
        }

        public String GetAsString() { 
            return json.Remove(json.Length - 2, 1).ToString()+"\r\n";
        }
    }
}
