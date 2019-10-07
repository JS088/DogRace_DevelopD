using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace_DevelopD
{
   public    class game
    {
        Random rd = new Random();
        public int moveUp() {
            return rd.Next(1, rd.Next(1, 30));
        }
    }
}
