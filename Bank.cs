using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_Homework
{
    public class Bank
    {
        private int _money;
        public int Money
        {
            get => _money;
            set
            {
                _money = value;
                StartLoggingThread();
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                StartLoggingThread();
            }
        }

        private int _percent;

        public int Percent
        {
            get => _percent;
            set
            {
                _percent = value;
                StartLoggingThread();
            }
        }

        private void StartLoggingThread()
        {
            Thread thread = new Thread(LogToFile);
            thread.Start();
        }

        private void LogToFile()
        {
            string text = $"Name: {Name}, Money: {Money}, Percent: {Percent}{Environment.NewLine}";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            lock (typeof(Bank)) 
            {
                using (FileStream fs = new FileStream("bank_log.txt", FileMode.Append, FileAccess.Write))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Money: {Money}, Percent: {Percent}";
        }
    }
}
