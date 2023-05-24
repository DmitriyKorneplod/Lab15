using Lab15_Pilipenko.Models;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace Lab15_Pilipenko.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Good> _goods;
        public ObservableCollection<Good> Goods
        {
            get => _goods;
            set => this.RaiseAndSetIfChanged(ref _goods,value);
        }
        public User user {get; set; }
        public MainWindowViewModel()
        {
            Is510Context dbContext = new Is510Context();
            dbContext.Users.Load();
            dbContext.Goods.Load();
            Goods = dbContext.Goods.Local.ToObservableCollection(); 
        }
        public MainWindowViewModel(User user):this()
        {
            this.user = user;
        }
    }
}