using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReusableListView
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Data> Data { get; set; }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            Data = new(Enumerable.Range(0, 100).Select(x => new Data() { Id = Guid.NewGuid() }));
            OnPropertyChanged(nameof(Data));
        }
    }

    public class Data
    {
        public Guid Id { get; set; }
    }
}
