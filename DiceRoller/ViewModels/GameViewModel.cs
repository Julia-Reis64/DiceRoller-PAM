using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string diceImage;

        [ObservableProperty]
        private string nomeUsuario;

        public GameViewModel(){
            diceImage = "";
            nomeUsuario = "Eu";
        }
    }
}
