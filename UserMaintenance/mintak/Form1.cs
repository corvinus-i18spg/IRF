using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintak
{
    public partial class Form1 : Form
    {
        private List<Entities.Ball> _balls = new List<Entities.Ball>();

        private Entities.BallFactory _factory;
        public Entities.BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new Entities.BallFactory();
        }


    }
}
