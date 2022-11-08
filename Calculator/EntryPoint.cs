using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces_grafiques.views; 


namespace Calculator.tests {
    class EntryPoint {
        public EntryPoint() {
            openWindow();
        }

        public void openWindow() {
            Application.Run(new Calculatrice());
        }
        public static void Main(String[] arg) {
            new EntryPoint();
        }

    }
}
