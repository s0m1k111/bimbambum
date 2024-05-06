using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimbambum
{
    internal class Game 
    {
        private string[] symbols = ["X", "0"];
        private int steps = 0;
        private Player[] player = [ new Player("X"),new Player("0")];
        public void Click(Button button,int n,Label label)
        {
            if (button.Text != "") 
                return; 
            int step = steps%symbols.Length;
            label.Text = player[step].setcombo(n);
            steps++;
            button.Text = symbols[step];
            
        }
        
    }
}
