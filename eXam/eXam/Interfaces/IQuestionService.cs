using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXam.Interfaces
{
    interface IQuestionService
    {

        Task<IEnumerable<QuizQuestion>> GetQuestionsAsync();
    }
}
