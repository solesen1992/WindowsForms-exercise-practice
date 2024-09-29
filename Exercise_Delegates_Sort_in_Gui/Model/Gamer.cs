using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Delegates_Sort_in_Gui.Model
{
    public class Gamer
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public int HighScore { get; set; }

        /*
         * Constructor
         */
        public Gamer(int id, string nickName, int highScore)
        {
            Id = id;
            NickName = nickName;
            HighScore = highScore;
        }

        // ToString
        public override string ToString()
        {
            return $"{Id} {NickName} {HighScore}";
        }
    }
}
