﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Chat:Félin
    {
        public Chat(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int nombresPattes)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique, nombresPattes)
        {
        }

        public new void Afficher()
        {
            base.Afficher();
        }
    }
}
