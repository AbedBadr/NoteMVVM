using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NewNoteMVVM.Annotations;
using NewNoteMVVM.Model;

namespace NewNoteMVVM.ViewModel
{
    class NoteViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<NoteModel> Notes { get; set; }

        public int No { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }

        public NoteViewModel()
        {
            Notes = new ObservableCollection<NoteModel>()
            {
                new NoteModel("This is a test note", "TestNote"),
                new NoteModel("This is another test", "TestNote2")
            };
        }

        public void Add()
        {
            Notes.Add(new NoteModel(Text, Subject));
            OnPropertyChanged();
        }

        public void Remove()
        {
            Notes.RemoveAt(No);
            OnPropertyChanged();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
