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

namespace Dairy
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            //десериализация файла с записями
            if (File.Exists("Notes.json"))
            {
                var result = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText("Notes.json"));
                foreach (var item in result)
                {
                    //выводим в форматированном виде записи
                    txtNotes.Text = txtNotes.Text + item.date + " " + item.place + " " + Environment.NewLine + item.title + " " + 
                        Environment.NewLine + item.note + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                }
            }
        }
    }
}
