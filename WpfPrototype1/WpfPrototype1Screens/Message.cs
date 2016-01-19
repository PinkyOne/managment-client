using System;
using System.Text;
namespace WpfPrototype1Screens
{
    class Message
    {
        StringBuilder json;
        public Message()
        {
            json = new StringBuilder("{}");

        }
        public void AddProperty(string property, string value) { 
            json.Insert(1, "\"" + property + "\":" + value + ","); 
        }

        public String GetAsString() { 
            return json.Remove(json.Length - 2, 1).ToString();
        }
    }
}
