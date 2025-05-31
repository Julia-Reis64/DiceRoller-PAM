using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceRoller.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string diceImage;

        [ObservableProperty]
        private string nomeUsuario;

        [ObservableProperty]
        private int selectedValue;

        [ObservableProperty]
        private string resultado;

        public GameViewModel(){
            diceImage = "dado1.png";
            nomeUsuario = "Eu";
            JogarCommand = new Command(Jogar);
        }

        private ICommand JogarCommand { get; private set; }

        public void Jogar()
        {
            //sortear dado
            Dice dice = new Dice();
            dice.Roll();
            if (dice.FaceParaCima == SelectedValue){
                Resultado = "Vitória";
            }
            else {
                Resultado = "Derrota";
            }
            //verificar a face
            //verificar se escolheu certo
            //exibir uma imagem na tela (exemplo)
        }
    }
}
