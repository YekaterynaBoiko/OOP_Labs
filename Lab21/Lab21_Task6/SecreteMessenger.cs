using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Task6
{
    public class SecreteMessenger
    {
        public string Message 
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error");
                field = value;
            }
        }
        //зробити приховування
        private string Encryption(string message)
        {
            char[] chars  = new char[message.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char) (message[i] + 1);
            }
            return new string(chars);
        }

        private string Decrypion(string message)
        {
            char[] chars = new char[message.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(message[i] - 1);
            }
            return new string(chars);
        }
        // метод розшифрування і отримання повідовлення розшифроване
        public void SendMessage(string text)
        {
            Message = Encryption(text);
        }

        public string ReceivingMessage()
        {
            return Decrypion(Message);
        }
    }
}
