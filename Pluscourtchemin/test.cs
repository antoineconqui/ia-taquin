public override List<NoeudGenerique> ListeSuccesseurs()
        {

            // PREMIER TROU

            // On mémorise la position des 2 trous
            int posx = -1; int posy = -1;
            int posx2 = -1; int posy2 = -1;

            for (int i = 0; i < TaillePlateau; i++)
            {
                for (int j = 0; j < TaillePlateau; j++)
                {
                    if (ConfigurationJeu[i, j] == 0)
                    {
                        posx = i;
                        posy = j;
                    }
                    if (ConfigurationJeu[i, j] == -1)
                    {
                        posx2 = i;
                        posy2 = j;
                    }

                }
            }

            List<NoeudGenerique> lsucc = new List<NoeudGenerique>();
            if (posx > 0)
            {
                // Successeur à gauche
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx, posy];
                tab2[posx, posy] = tab2[posx - 1, posy];
                tab2[posx - 1, posy] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }
            if (posx < TaillePlateau - 1)
            {
                // Successeur à droite
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx, posy];
                tab2[posx, posy] = tab2[posx + 1, posy];
                tab2[posx + 1, posy] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }

            if (posy > 0)
            {
                // Successeur en haut
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx, posy];
                tab2[posx, posy] = tab2[posx, posy - 1];
                tab2[posx, posy - 1] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }
            if (posy < TaillePlateau - 1)
            {
                // Successeur en bas
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx, posy];
                tab2[posx, posy] = tab2[posx, posy + 1];
                tab2[posx, posy + 1] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }

            // DEUXIEME TROU

            if (posx2 > 0)
            {
                // Successeur à gauche
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx2, posy2];
                tab2[posx2, posy2] = tab2[posx2 - 1, posy2];
                tab2[posx2 - 1, posy2] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }
            if (posx2 < TaillePlateau - 1)
            {
                // Successeur à droite
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx2, posy2];
                tab2[posx2, posy2] = tab2[posx2 + 1, posy2];
                tab2[posx2 + 1, posy2] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }

            if (posy2 > 0)
            {
                // Successeur en haut
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx2, posy2];
                tab2[posx2, posy2] = tab2[posx2, posy2 - 1];
                tab2[posx2, posy2 - 1] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }
            if (posy2 < TaillePlateau - 1)
            {
                // Successeur en bas
                // recopie du tableau
                int[,] tab2 = new int[TaillePlateau, TaillePlateau];
                for (int j = 0; j <= TaillePlateau - 1; j++)
                    for (int i = 0; i <= TaillePlateau - 1; i++)
                    {
                        tab2[i, j] = ConfigurationJeu[i, j];
                    }
                // MAJ de la position du ?
                int temp = tab2[posx2, posy2];
                tab2[posx2, posy2] = tab2[posx2, posy2 + 1];
                tab2[posx2, posy2 + 1] = temp;
                // Ajout à listsucc
                lsucc.Add(new NoeudTaquin(tab2));
            }

            return lsucc;

        }