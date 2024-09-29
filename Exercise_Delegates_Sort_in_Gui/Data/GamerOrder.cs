using Exercise_Delegates_Sort_in_Gui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Delegates_Sort_in_Gui.Data
{
    /*
     * CREDIT: The following code is made by a teacher at UCN
     */
    public class GamerOrder
    {
        static bool currentHighScoreOrderIsAscending = false;
        static bool currentNameOrderIsAscending = false;

        // Toggles to opposite order
        public static void ToogleCurrentNameOrderIsAscending()
        {
            currentNameOrderIsAscending = !currentNameOrderIsAscending;
        }
        public static void ToogleCurrentHighScoreOrderIsAscending()
        {
            currentHighScoreOrderIsAscending = !currentHighScoreOrderIsAscending;
        }

        public static int OrderByName(Gamer x1, Gamer x2)
        {
            int compInt = 0;
            if (x2 == null)
            {
                compInt = -1;
            }
            else
            {
                if (x1.NickName.CompareTo(x2.NickName) > 0) compInt = -1;
                if (x1.NickName.CompareTo(x2.NickName) < 0) compInt = 1;
            }
            if (currentNameOrderIsAscending)
            {
                compInt *= -1;
            }
            return compInt;
        }

        public static int OrderByHighScore(Gamer x1, Gamer x2)
        {
            int compInt = 0;
            if (x2 == null)
            {
                compInt = -1;
            }
            else
            {
                if (x1.HighScore.CompareTo(x2.HighScore) > 0) compInt = -1;
                if (x1.HighScore.CompareTo(x2.HighScore) < 0) compInt = 1;
            }
            if (currentHighScoreOrderIsAscending)
            {
                compInt *= -1;
            }
            return compInt;
        }
    }
}
