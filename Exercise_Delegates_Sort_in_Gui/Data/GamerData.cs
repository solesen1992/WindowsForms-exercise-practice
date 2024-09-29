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
    public class GamerData
    {
        readonly List<Gamer> _gamers;

        public GamerData()
        {
            _gamers = new List<Gamer>();
        }

        public List<Gamer> FetchGamers()
        {

            _gamers.Add(new Gamer(1, "SuperHero", 759120));
            _gamers.Add(new Gamer(2, "Xyp9x", 3947630));
            _gamers.Add(new Gamer(3, "dupreeh", 9959570));

            return _gamers;
        }
    }
}
