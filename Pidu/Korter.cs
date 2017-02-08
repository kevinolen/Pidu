﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Pidu
{
    class Korter
    {
        private int maksimumSuurus = 10;
        private List<string> inimesed = new List<String>();

        public void lisaInimene(string inimene)
        {
            if (kasMahubVeel()==true)
            {
                inimesed.Add(inimene);
            }
            else
            {
                var dialog = new MessageDialog("10 inimest on täis. Rohkem ei  mahu");
                dialog.ShowAsync();
            }
        }
        public void eemaldaInimene(string inimene)
        {
            inimesed.Remove(inimene);
        }

        public Boolean kasMahubVeel()
        {
            Boolean kontroll = false;

            if(inimesed.Count < maksimumSuurus)
            {
                kontroll = true;
            }
            else
            {
                kontroll = false;
            }

            return kontroll;
        }

        public string kuvaInimesed()
        {
            string rahvas = "";

            for (int i = 0; i < inimesed.Count; i++)
            {
                rahvas = rahvas + inimesed[i] + System.Environment.NewLine;
            }

            return rahvas;
        }

    }
}
