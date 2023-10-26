using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Notess
    {
        public string Name { get; set; } // Название
        public string Description { get; set; } // Описание
        public string Date { get; set; } // Дата
        public string Time { get; set; } //Время
        public Notess(string name, string description, string date, string time)
        {
            Name = name;
            Description = description;
            Date = date;
            Time = time;
        }


    }
}