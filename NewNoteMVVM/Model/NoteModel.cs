using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNoteMVVM.Model
{
    class NoteModel
    {
        private static int _count;

        public int No { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }

        public NoteModel(string text, string subject)
        {
            _count++;
            No = _count;
            Text = text;
            Subject = subject;
            Date = DateTime.Now;
            
        }

        public override string ToString()
        {
            return $"{nameof(No)}: {No}, {nameof(Text)}: {Text}, {nameof(Subject)}: {Subject}, {nameof(Date)}: {Date}";
        }
    }
}
