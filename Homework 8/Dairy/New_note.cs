using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading;





namespace Dairy
{
    public partial class New_note : Form
    {
        public New_note()
        {
            InitializeComponent();
            lblResult.Hide();
        }
        /// <summary>
        /// Добавление записи в дневник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //запоминаем введенные данные
            Note newNote = new Note() { date = txtDate.Text, place = txtPlace.Text, title = txtTitle.Text, note = txtNote.Text};
            //создаем список объектов, который будем сериаолизовывать
            List<Note> result = new List<Note>();
            //десериализация имеющегося файла. запускается при условии, что файл существует
            if (File.Exists("Notes.json"))
            {
                result = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText("Notes.json"));
                File.Delete("Notes.json");
            }
            //добавляем в список новую запись
            result.Add(newNote);
            //сериализация списка записей
            string json = JsonConvert.SerializeObject(result);
            File.WriteAllText("Notes.json", json);
            //показываем маркер об успешной записи, очищаем поля
            lblResult.Show();
            lblResult.Text = "Запись сохранена";
            txtDate.Clear();
            txtPlace.Clear();
            txtNote.Clear();
            txtTitle.Clear();
        }
        //при фокусе в какое-либо поле скрываем лейбл у спешной записи
        private void txtDate_Click(object sender, EventArgs e)
        {
            lblResult.Hide();
        }
        private void txtPlace_Click(object sender, EventArgs e)
        {
            lblResult.Hide();
        }
        private void txtTitle_Click(object sender, EventArgs e)
        {
            lblResult.Hide();
        }
        private void txtNote_Click(object sender, EventArgs e)
        {
            lblResult.Hide();
        }
        //вывод всех сделанных записей в отдельной форме
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            Form myNotes = new Notes();
            myNotes.ShowDialog();
        }
    }
}
