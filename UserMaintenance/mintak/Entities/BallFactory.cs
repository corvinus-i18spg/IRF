using mintak.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mintak.Entities
{
    class BallFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

        public Color BallColor { get; set; }

    }

}
