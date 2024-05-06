﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimbambum
{
    internal class Player
    {
        bool[] combo = { false, false, false, false, false, false, false, false, false };
        private string name;
        public string setcombo(int n)
        {
            combo[n] = true;
            if (IsWin())
                return "Win" + name;
            return "Win ";
        }
        public Player(string name)
        {
            this.name = name;
            for(int i = 0;i<combo.Length;i++)
                combo[i] = false;
        }
        private bool IsWin()
        {
            if (combo[0] && combo[1] && combo[2])
                { return true; }
            if (combo[3] && combo[4] && combo[5])
                { return true; }
            if (combo[6] && combo[7] && combo[8])
                { return true; }
            if (combo[0] && combo[3] && combo[6])
                { return true; }
            if (combo[1] && combo[4] && combo[7])
                { return true; }
            if (combo[2] && combo[5] && combo[8])
                { return true; }
            if (combo[0] && combo[4] && combo[8])
                { return true; }
            if (combo[2] && combo[4] && combo[6])
                { return true; }
            return false;
        }
    }
}
