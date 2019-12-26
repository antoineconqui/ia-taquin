using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluscourtchemin
{
    public class GenericNode
    {
        public Random r = new Random();
        public int[,] taquin;
        public int[,] taquin3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 0, 0 } };
        public int[,] taquin5 = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 0, 0 } };
        public int[,] taquinFinal;
        public int[,] taquinFinal3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 0, 0 } };
        public int[,] taquinFinal5 = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 0, 0 } };
        public int size;
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public double initialCost;
        public double heuristicCost;
        public double totalCost;
        public static int chosenHeuristic;
        public GenericNode parent;
        public List<GenericNode> successors = new List<GenericNode>();
        public int piecePlaced;

        public List<int> Shuffle(List<int> liste)
        {
            int n = liste.Count;
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                int value = liste[k];
                liste[k] = liste[n];
                liste[n] = value;
            }
            return liste;
        }

        public GenericNode(int _size)
        {
            size = _size;
            piecePlaced = 1;
            taquin = (size == 3) ? taquin3 : taquin5;
            taquinFinal = (size == 3) ? taquinFinal3 : taquinFinal5;
            List<int> entiers = (size==3) ? new List<int> { 0, 0, 1, 2, 3, 4, 5, 6, 7 } : new List<int> { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }; ;
            entiers = Shuffle(entiers);
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    taquin[i, j] = entiers[i * size + j];
        }

        public GenericNode(List<string> textBoxes, int heuristicchoosen)
        {
            size = Convert.ToInt32(Math.Sqrt(textBoxes.Count));
            piecePlaced = 1;
            int[,] _taquin = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (textBoxes[i*size+j] == "")
                        _taquin[i, j] = 0;
                    else
                        _taquin[i, j] = Convert.ToInt32(textBoxes[i * size + j]);
                }
            taquin = _taquin;
            taquinFinal = (size == 3) ? taquinFinal3 : taquinFinal5;
            chosenHeuristic = heuristicchoosen;
            //initialCost = 0;
        }

        public GenericNode(int[,] _taquin)
        {
            //int[] integers = new int[_taquin.Length];
            //for (int i = 0; i < _taquin.Length; i++)
            //{
            //    foreach (int integer in integers)
            //        if (integer == _taquin[i])
            //        {
            //            taquin = (size == 3) ? taquin3 : taquin5;
            //            return;
            //        }
            //    integers[0] = num;
            //}
            taquin = _taquin;
            size = taquin.GetUpperBound(0) + 1;
            taquinFinal = (size == 3) ? taquinFinal3 : taquinFinal5;
            piecePlaced = 1;
            //initialCost = 0;
        }

        public GenericNode(int[,] _taquin, GenericNode _parent)
        {
            taquin = _taquin;
            parent = _parent;
            size = taquin.GetUpperBound(0) + 1;
            taquinFinal = (size == 3) ? taquinFinal3 : taquinFinal5;
            piecePlaced = 1;
        }

        public bool IsEqual(GenericNode node)
        {
            for (int i = 0; i <= taquin.GetUpperBound(0); i++)
                for (int j = 0; j <= taquin.GetUpperBound(0); j++)
                    if (taquin[i, j] != node.taquin[i, j])
                        return false;
            return true;
        }

        public bool isPartiallyFinal(int value)
        {
            int[] index = getIndex(value);
            int[] indexFinal = getFinalIndex(value);

            if (index[0] == indexFinal[0] && index[1] == indexFinal[1])
                return true;
            return false;
        }

        public bool EndState()
        {
            return IsEqual(new GenericNode((size==3) ? taquinFinal3 : taquinFinal5));
        }

        public void getHolePosition()
        {
            x1 = -1; y1 = -1; x2 = -1; y2 = -1;

            for (int i = 0; i <= taquin.GetUpperBound(0); i++)
                for (int j = 0; j <= taquin.GetUpperBound(0); j++)
                    if (taquin[i, j] == 0)
                    {
                        if (x1 == -1)
                        {
                            x1 = i;
                            y1 = j;
                        }
                        else
                        {
                            x2 = i;
                            y2 = j;
                        }
                    }
        }

        public bool Worst(int[,] tab)
        {
            for (int i = 0; i < size-2; i++)
            {
                for (int j = 0; j < size - 2; j++)
                    if (taquin[i, j] == i * size + j + 1 && tab[i, j] != i * size + j + 1)
                        return true;
                if (taquin[i, size - 2] == i* size + size - 1 && taquin[i, size - 1] == i * size + size && tab[i, size - 2] != i * size + size - 1 && tab[i, size - 1] != i * size + size)
                    return true;
            }
            for (int j = 0; j < size - 2; j++)
                if (taquin[size - 2, j] == size * (size-2) + j && taquin[size - 1, j] == size * (size - 1) + j && tab[size - 2, j] != size * (size - 2) + j && tab[size - 1, j] != size * (size - 1) + j)
                    return true;
            return false;
        }

        public void getSuccessor(bool x1y1, bool x, bool plus)
        { 
            int axe1 = (x1y1) ? x1 : x2;
            int axe2 = (x1y1) ? y1 : y2;
            int value = (x) ? axe1 : axe2;
            if ((plus) ? (value < size-1) : (value > 0))
            {
                int[,] tab = new int[size, size];

                for (int j = 0; j < size; j++)
                    for (int i = 0; i < size; i++)
                        tab[i, j] = taquin[i, j];

                tab[axe1, axe2] = tab[axe1 + ((x) ? ((plus) ? 1 : -1) : 0), axe2 + ((!x) ? ((plus) ? 1 : -1) : 0)];
                tab[axe1 + ((x) ? ((plus) ? 1 : -1) : 0), axe2 + ((!x) ? ((plus) ? 1 : -1) : 0)] = 0;

                if(!Worst(tab))
                    successors.Add(new GenericNode(tab, this));
            }
        }

        public void getPartialSuccessor(bool x1y1, bool x, bool plus, List<int> placedNumbers)
        {
            int axe1 = (x1y1) ? x1 : x2;
            int axe2 = (x1y1) ? y1 : y2;
            int value = (x) ? axe1 : axe2;

            if ((plus) ? (value < size - 1) : (value > 0))
            {
                int[,] tab = new int[size, size];

                if (taquin[axe1 + ((x) ? ((plus) ? 1 : -1) : 0), axe2 + ((!x) ? ((plus) ? 1 : -1) : 0)] != 0)
                {
                    if (!placedNumbers.Contains(taquin[axe1 + ((x) ? ((plus) ? 1 : -1) : 0), axe2 + ((!x) ? ((plus) ? 1 : -1) : 0)]))
                    {
                        for (int i = 0; i < size; i++)
                            for (int j = 0; j < size; j++)
                                tab[i, j] = taquin[i, j];

                        tab[axe1, axe2] = tab[axe1 + ((x) ? ((plus) ? 1 : -1) : 0), axe2 + ((!x) ? ((plus) ? 1 : -1) : 0)];
                        tab[axe1 + ((x) ? ((plus) ? 1 : -1) : 0), axe2 + ((!x) ? ((plus) ? 1 : -1) : 0)] = 0;

                        successors.Add(new GenericNode(tab, this));
                    }
                }
            }
        }

        public List<GenericNode> getSuccessors()
        {
            getHolePosition();
            getSuccessor(true, true, true);
            getSuccessor(true, true, false);
            getSuccessor(true, false, true);
            getSuccessor(true, false, false);
            getSuccessor(false, true, true);
            getSuccessor(false, true, false);
            getSuccessor(false, false, true);
            getSuccessor(false, false, false);
            return successors;  
        }

        public List<GenericNode> getPartialSuccessors(List<int> placedNumbers)
        {
            getHolePosition();
            getPartialSuccessor(true, true, true, placedNumbers);
            getPartialSuccessor(true, true, false, placedNumbers);
            getPartialSuccessor(true, false, true, placedNumbers);
            getPartialSuccessor(true, false, false, placedNumbers);
            getPartialSuccessor(false, true, true, placedNumbers);
            getPartialSuccessor(false, true, false, placedNumbers);
            getPartialSuccessor(false, false, true, placedNumbers);
            getPartialSuccessor(false, false, false, placedNumbers);
            return successors;
        }

        public int[] getIndex(int value)
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (taquin[i, j] == value)
                        return new int[] { i, j };
            return new int[] { -1, -1 };
        }

        public int[] getFinalIndex(int value)
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (taquinFinal[i, j] == value)
                        return new int[] { i, j };
            return new int[] { -1, -1 };
        }

        public int getDistance(int value)
        {
            int[] index = getIndex(value);
            int[] indexFinal = getFinalIndex(value);
            return Math.Abs(index[0] - indexFinal[0]) + Math.Abs(index[1] - indexFinal[1]);
        }

        public int getDistanceToHole(int value, bool firstHole, bool final)
        {
            int[] index = getIndex(value);
            int[] indexFinal = getFinalIndex(value);
            return Math.Abs(((firstHole) ? x1 : x2) - ((final) ? indexFinal[0] : index[0])) + Math.Abs(((firstHole) ? y1 : y2) - ((final) ? indexFinal[1] : index[1]));
        }

        public double getHeuristicCost()
        {
            double cost = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    {
                        if (chosenHeuristic == 3 || chosenHeuristic == 4)
                            cost += getDistance(i * size + j);
                        else
                            cost += 1;
                    }
            return cost;
        }

        public double getHumanHeuristicCost(int number)
        {
            double cost = 7 * getDistance(number);

            if (cost != 0)
            {
                getHolePosition();

                if (getDistanceToHole(number,true,false) < getDistanceToHole(number, false, false))
                    cost += 4 * getDistanceToHole(number, true, false) + 2 * getDistanceToHole(number, false, false);
                else
                    cost += 4 * getDistanceToHole(number, false, false) + 2 * getDistanceToHole(number, true, false);

                cost += 8 * getDistanceToHole(number, (getDistanceToHole(number, true, true) < getDistanceToHole(number, false, true)), true);
            }

            return cost;
        }

        public void getTotalCost()
        {
            heuristicCost = getHeuristicCost();
            if(chosenHeuristic != 4)
            {
                totalCost = initialCost + heuristicCost;
            }
            else
            {
                if(size==3)
                {
                    totalCost = 1 * initialCost + 8 * heuristicCost;
                }
                else
                {
                    totalCost = 4 * initialCost + 1 * heuristicCost;
                }
            }
        }

        public void getHumanTotalCost(int numero)
        {
            heuristicCost = getHumanHeuristicCost(numero);
            totalCost = initialCost + heuristicCost;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i <= taquin.GetUpperBound(0); i++)
                for (int j = 0; j <= taquin.GetUpperBound(0); j++)
                    s += taquin[i, j];
            return s;
        }

    }
}
