using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy
{
    /// <summary>
    /// класс массива записей
    /// </summary>
    public class Notes
    {
        public Note[] myNotes;
    } 
    public class Note
    {
        public string date;
        public string place;
        public string header;
        public string text;
        /// <summary>
        /// Класс записи в дневнике
        /// </summary>
        /// <param name="date">Дата записи в формате мм/дд</param>
        /// <param name="place">Физическое место, где была сделана запись (домаб работа и т.д.)</param>
        /// <param name="header">Заголовок записи</param>
        /// <param name="text">Текст записи</param>
        //public Note(string date, string place, string header, string text)
        //{
        //    this.date = date;
        //    this.place = place;
        //    this.header = header;
        //    this.text = text;
        //}
    }
}
