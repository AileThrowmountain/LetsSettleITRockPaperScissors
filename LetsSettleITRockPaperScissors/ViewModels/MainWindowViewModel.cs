using LetsSettleITRockPaperScissors.Base;
using LetsSettleITRockPaperScissors.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LetsSettleITRockPaperScissors.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand NewGameCommand { get; set; }
        public MainWindowViewModel()
        {
            NewGameCommand = new RelayCommand(EnterNewGame);
        }

        private void EnterNewGame()
        {
            Navigate.Content = new PlayerPage();
        }
    }
}
