using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXam
{
    public class QuestionPageViewModel : INotifyPropertyChanged
    {
        private readonly Game game;
        public event PropertyChangedEventHandler PropertyChanged;

        public QuestionPageViewModel(Game game)
        {
            this.game = game;
            this.game.Restart();
        }

        public string Question
        {
            get { return game.CurrentQuestion.Question; }
        }
        public string Response
        {
            get
            {
                if (game.CurrentResponse == null){
                    return "";
                }
                return game.CurrentQuestion.Answer == game.CurrentResponse ? 
                    "Correct!" : "Incorrect";
            }
        }
    }
}
