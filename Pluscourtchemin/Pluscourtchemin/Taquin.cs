using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Pluscourtchemin
{
    public partial class formTaquin : Form
    { 
        public Color checkedColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
        readonly private Color uncheckedColor = Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));

        private Button case1 = new System.Windows.Forms.Button();
        private Button case2 = new System.Windows.Forms.Button();
        private Button case3 = new System.Windows.Forms.Button();
        private Button case4 = new System.Windows.Forms.Button();
        private Button case5 = new System.Windows.Forms.Button();
        private Button case6 = new System.Windows.Forms.Button();
        private Button case7 = new System.Windows.Forms.Button();
        private Button case8 = new System.Windows.Forms.Button();
        private Button case9 = new System.Windows.Forms.Button();
        private Button case10 = new System.Windows.Forms.Button();
        private Button case11 = new System.Windows.Forms.Button();
        private Button case12 = new System.Windows.Forms.Button();
        private Button case13 = new System.Windows.Forms.Button();
        private Button case14 = new System.Windows.Forms.Button();
        private Button case15 = new System.Windows.Forms.Button();
        private Button case16 = new System.Windows.Forms.Button();
        private Button case17 = new System.Windows.Forms.Button();
        private Button case18 = new System.Windows.Forms.Button();
        private Button case19 = new System.Windows.Forms.Button();
        private Button case20 = new System.Windows.Forms.Button();
        private Button case21 = new System.Windows.Forms.Button();
        private Button case22 = new System.Windows.Forms.Button();
        private Button case23 = new System.Windows.Forms.Button();
        private Button case24 = new System.Windows.Forms.Button();
        private Button case25 = new System.Windows.Forms.Button();
        
        private int _chosenSize = 0;
        private int _chosenHeuristic = 0;

        private Button[] tab;
        private Button[] tab2;
        private List<GenericNode> solutionNodes;

        public formTaquin()
        {
            InitializeComponent();

            tab = new System.Windows.Forms.Button[] { case1, case2, case3, case4, case5, case6, case7, case8, case9 };
            tab2 = new System.Windows.Forms.Button[] { case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19, case20, case21, case22, case23, case24, case25 };
        }

        private void enableButtons()
        {
            buttonEasyTaquin.Enabled = true;
            buttonMiddleTaquin.Enabled = true;
            buttonHardTaquin.Enabled = true;
            buttonRandomTaquin.Enabled = true;
            buttonSolve.Enabled = true;
        }

        private void buttonSize3_Click(object sender, EventArgs e)
        {
            _chosenSize = 3;
            buttonSize3.BackColor = checkedColor;
            buttonSize5.BackColor = uncheckedColor;
            enableButtons();

            for (int i = 0; i < 25; i++)
                Controls.Remove(tab2[i]);

            int y = 150;
            int x = 275;
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    x = 375;
                    y += 100;
                }
                else
                    x += 100;

                tab[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tab[i].Location = new System.Drawing.Point(x, y);
                tab[i].Name = "" + (i + 1);
                tab[i].Size = new System.Drawing.Size(100, 100);
                tab[i].TabIndex = 26;
                tab[i].Text = (i < _chosenSize * _chosenSize - 2) ? "" + (i + 1) : "";
                tab[i].ForeColor = Color.White;
                tab[i].BackColor = uncheckedColor;

                Controls.Add(tab[i]);
            }
        }

        private void buttonSize5_Click(object sender, EventArgs e)
        {
            _chosenSize = 5;
            buttonSize5.BackColor = checkedColor;
            buttonSize3.BackColor = uncheckedColor;
            enableButtons();

            for (int i = 0; i < 9; i++)
                Controls.Remove(tab[i]);

            int y = 100;
            int x = 275;
            for (int i = 0; i < 25; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    y += 75;
                    x = 350;
                }
                else
                    x += 75;

                tab2[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tab2[i].Location = new System.Drawing.Point(x, y);
                tab2[i].Name = "" + (i + 1);
                tab2[i].Size = new System.Drawing.Size(75, 75);
                tab2[i].TabIndex = 26;
                tab2[i].Text = (i<  _chosenSize*_chosenSize - 2) ? "" + (i + 1) : "";
                tab2[i].ForeColor = Color.White;
                tab2[i].BackColor = uncheckedColor;

                Controls.Add(tab2[i]);
            }
        }

        private void buttonNoHeuristic_Click(object sender, EventArgs e)
        {
            uncheckHeuristicButtons();
            checkHeuristicButton(buttonNoHeuristic, 1);
        }

        private void buttonHumanlyResolution_Click(object sender, EventArgs e)
        {
            uncheckHeuristicButtons();
            checkHeuristicButton(buttonHumanlyResolution, 2);
        }

        private void buttonManhattanHeuristic_Click(object sender, EventArgs e)
        {
            uncheckHeuristicButtons();
            checkHeuristicButton(buttonManhattanHeuristic, 3);
        }

        private void buttonOptimisedManhattanHeuristic_Click(object sender, EventArgs e)
        {
            uncheckHeuristicButtons();
            checkHeuristicButton(buttonOptimisedManhattanHeuristic, 4);
        }

        private void checkHeuristicButton(Button button, int chosenHeuristic)
        {
            button.BackColor = checkedColor;
            _chosenHeuristic = chosenHeuristic;
        }

        private void uncheckHeuristicButtons()
        {
            buttonNoHeuristic.BackColor = uncheckedColor;
            buttonHumanlyResolution.BackColor = uncheckedColor;
            buttonManhattanHeuristic.BackColor = uncheckedColor;
            buttonOptimisedManhattanHeuristic.BackColor = uncheckedColor;
        }

        private void buttonEasyTaquin_Click(object sender, EventArgs e)
        {
            if (_chosenSize == 3)
            {
                tab[0].Text = "1";
                tab[1].Text = "";
                tab[2].Text = "3";
                tab[3].Text = "4";
                tab[4].Text = "2";
                tab[5].Text = "";
                tab[6].Text = "6";
                tab[7].Text = "7";
                tab[8].Text = "5";
            }
            else
            {
                tab2[0].Text = "1";
                tab2[1].Text = "2";
                tab2[2].Text = "3";
                tab2[3].Text = "4";
                tab2[4].Text = "5";
                tab2[5].Text = "";
                tab2[6].Text = "6";
                tab2[7].Text = "7";
                tab2[8].Text = "8";
                tab2[9].Text = "9";
                tab2[10].Text = "11";
                tab2[11].Text = "12";
                tab2[12].Text = "13";
                tab2[13].Text = "10";
                tab2[14].Text = "";
                tab2[15].Text = "16";
                tab2[16].Text = "17";
                tab2[17].Text = "18";
                tab2[18].Text = "14";
                tab2[19].Text = "15";
                tab2[20].Text = "21";
                tab2[21].Text = "22";
                tab2[22].Text = "23";
                tab2[23].Text = "20";
                tab2[24].Text = "19";
            }
        }

        private void buttonMiddleTaquin_Click(object sender, EventArgs e)
        {
            {
                if (_chosenSize == 3)
                {
                    tab[0].Text = "";
                    tab[1].Text = "1";
                    tab[2].Text = "2";
                    tab[3].Text = "";
                    tab[4].Text = "4";
                    tab[5].Text = "3";
                    tab[6].Text = "6";
                    tab[7].Text = "7";
                    tab[8].Text = "5";
                }
                else
                {
                    tab2[0].Text = "8";
                    tab2[1].Text = "1";
                    tab2[2].Text = "9";
                    tab2[3].Text = "10";
                    tab2[4].Text = "2";
                    tab2[5].Text = "18";
                    tab2[6].Text = "15";
                    tab2[7].Text = "21";
                    tab2[8].Text = "22";
                    tab2[9].Text = "17";
                    tab2[10].Text = "12";
                    tab2[11].Text = "13";
                    tab2[12].Text = "";
                    tab2[13].Text = "";
                    tab2[14].Text = "23";
                    tab2[15].Text = "19";
                    tab2[16].Text = "4";
                    tab2[17].Text = "20";
                    tab2[18].Text = "16";
                    tab2[19].Text = "3";
                    tab2[20].Text = "6";
                    tab2[21].Text = "7";
                    tab2[22].Text = "11";
                    tab2[23].Text = "14";
                    tab2[24].Text = "5";

                }
            }
        }

        private void buttonHardTaquin_Click(object sender, EventArgs e)
        {
            {
                if (_chosenSize == 3)
                {
                    tab[0].Text = "7";
                    tab[1].Text = "1";
                    tab[2].Text = "4";
                    tab[3].Text = "5";
                    tab[4].Text = "6";
                    tab[5].Text = "3";
                    tab[6].Text = "2";
                    tab[7].Text = "";
                    tab[8].Text = "";
                }
                else
                {
                    tab2[0].Text = "7";
                    tab2[1].Text = "1";
                    tab2[2].Text = "20";
                    tab2[3].Text = "13";
                    tab2[4].Text = "4";
                    tab2[5].Text = "12";
                    tab2[6].Text = "21";
                    tab2[7].Text = "3";
                    tab2[8].Text = "22";
                    tab2[9].Text = "10";
                    tab2[10].Text = "23";
                    tab2[11].Text = "16";
                    tab2[12].Text = "18";
                    tab2[13].Text = "15";
                    tab2[14].Text = "5";
                    tab2[15].Text = "9";
                    tab2[16].Text = "6";
                    tab2[17].Text = "11";
                    tab2[18].Text = "8";
                    tab2[19].Text = "19";
                    tab2[20].Text = "2";
                    tab2[21].Text = "17";
                    tab2[22].Text = "14";
                    tab2[23].Text = "";
                    tab2[24].Text = "";

                }
            }
        }

        private void buttonRandomTaquin_Click(object sender, EventArgs e)
        {
            GenericNode node = new GenericNode(_chosenSize);
            for (int i = 0; i < _chosenSize; i++)
                for (int j = 0; j < _chosenSize; j++)
                    if (_chosenSize == 3)
                        tab[i * _chosenSize + j].Text = (node.taquin[i, j]!= 0) ? node.taquin[i, j].ToString() : "";
                    else
                        tab2[i * _chosenSize + j].Text = (node.taquin[i, j] != 0) ? node.taquin[i, j].ToString() : "";
        }

        private bool IsResolvable(Button[] buttons)
        {
            List<int> numberList = Enumerable.Range(1, buttons.Length - 2).ToList();

            foreach (Button button in buttons)
            {
                if(button.Text != "")
                {
                    if (numberList.Contains(Convert.ToInt32(button.Text)))
                            numberList.Remove(Convert.ToInt32(button.Text));
                    else
                        return false;
                }
            }
            return (numberList.Count() == 0);

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if (!IsResolvable((_chosenSize == 3) ? tab : tab2) || _chosenSize == 0 || _chosenHeuristic == 0)
                return;

            buttonDisplaySolution.Enabled = true;
            DateTime t0 = DateTime.Now;
            SearchTree searchTree = new SearchTree();
            listBoxSolutionTree.Items.Clear();
            
            GenericNode node0 = new GenericNode(Enumerable.Range(0,(_chosenSize* _chosenSize)).Select(x=>(_chosenSize==3) ? tab[x].Text :tab2[x].Text).ToList(), _chosenHeuristic);
            
            solutionNodes = searchTree.findSolution(node0,_chosenHeuristic==2,_chosenSize);

            if (solutionNodes.Count == 0)
                labelSolution.Text = "Pas de solution";
            else
            {
                buttonDisplaySolution.Enabled = true;

                foreach (GenericNode node in solutionNodes)
                    listBoxSolutionTree.Items.Add(node);

                labelCountOpened.Text = "Nb noeuds des ouverts : " + searchTree.opened.ToString();
                labelCountClosed.Text = "Nb noeuds des fermés : " + searchTree.closed.ToString();
            }

            double seconds = Math.Round((double)(DateTime.Now.Ticks - t0.Ticks) / 10000000, 2);
            labelSolution.Text = seconds.ToString() + " secondes";
        }

        private void buttonDisplaySolution_Click(object sender, EventArgs e)
        {
            foreach (GenericNode node in solutionNodes)
            {
                for (int i = 0; i < _chosenSize; i++)
                    for (int j = 0; j < _chosenSize; j++)
                    {
                        if (node.taquin[i, j] != 0)
                        {
                            if (_chosenSize == 3)
                                tab[i * _chosenSize + j].Text = node.taquin[i, j].ToString();
                            else
                                tab2[i * _chosenSize + j].Text = node.taquin[i, j].ToString();
                        }
                        else
                        {
                            if (_chosenSize == 3)
                                tab[i * _chosenSize + j].Text = "";
                            else
                                tab2[i * _chosenSize + j].Text = "";
                        }
                    }

                this.Refresh();
                Thread.Sleep(500);
            }
        }
    }
}