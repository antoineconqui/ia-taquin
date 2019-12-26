namespace Pluscourtchemin
{
    partial class formTaquin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonSize3 = new System.Windows.Forms.Button();
            this.buttonNoHeuristic = new System.Windows.Forms.Button();
            this.buttonOptimisedManhattanHeuristic = new System.Windows.Forms.Button();
            this.buttonSize5 = new System.Windows.Forms.Button();
            this.buttonRandomTaquin = new System.Windows.Forms.Button();
            this.buttonManhattanHeuristic = new System.Windows.Forms.Button();
            this.buttonHumanlyResolution = new System.Windows.Forms.Button();
            this.buttonHardTaquin = new System.Windows.Forms.Button();
            this.buttonMiddleTaquin = new System.Windows.Forms.Button();
            this.buttonEasyTaquin = new System.Windows.Forms.Button();
            this.labelTaquin = new System.Windows.Forms.Label();
            this.labelHeuristic = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            this.listBoxSolutionTree = new System.Windows.Forms.ListBox();
            this.labelCountClosed = new System.Windows.Forms.Label();
            this.labelCountOpened = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.buttonDisplaySolution = new System.Windows.Forms.Button();
            this.labelTree = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.panelSettings.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(375, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(508, 69);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "The Magic Taquin";
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.panelSettings.Controls.Add(this.buttonSize3);
            this.panelSettings.Controls.Add(this.buttonNoHeuristic);
            this.panelSettings.Controls.Add(this.buttonOptimisedManhattanHeuristic);
            this.panelSettings.Controls.Add(this.buttonSize5);
            this.panelSettings.Controls.Add(this.buttonRandomTaquin);
            this.panelSettings.Controls.Add(this.buttonManhattanHeuristic);
            this.panelSettings.Controls.Add(this.buttonHumanlyResolution);
            this.panelSettings.Controls.Add(this.buttonHardTaquin);
            this.panelSettings.Controls.Add(this.buttonMiddleTaquin);
            this.panelSettings.Controls.Add(this.buttonEasyTaquin);
            this.panelSettings.Controls.Add(this.labelTaquin);
            this.panelSettings.Controls.Add(this.labelHeuristic);
            this.panelSettings.Controls.Add(this.labelSize);
            this.panelSettings.ForeColor = System.Drawing.Color.Black;
            this.panelSettings.Location = new System.Drawing.Point(0, -22);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(352, 764);
            this.panelSettings.TabIndex = 4;
            // 
            // buttonSize3
            // 
            this.buttonSize3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonSize3.Font = new System.Drawing.Font("Roboto Condensed", 16.2F);
            this.buttonSize3.ForeColor = System.Drawing.Color.Black;
            this.buttonSize3.Location = new System.Drawing.Point(26, 97);
            this.buttonSize3.Name = "buttonSize3";
            this.buttonSize3.Size = new System.Drawing.Size(145, 79);
            this.buttonSize3.TabIndex = 30;
            this.buttonSize3.Text = "Taquin 3x3";
            this.buttonSize3.UseVisualStyleBackColor = false;
            this.buttonSize3.Click += new System.EventHandler(this.buttonSize3_Click);
            // 
            // buttonNoHeuristic
            // 
            this.buttonNoHeuristic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonNoHeuristic.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.buttonNoHeuristic.ForeColor = System.Drawing.Color.Black;
            this.buttonNoHeuristic.Location = new System.Drawing.Point(26, 243);
            this.buttonNoHeuristic.Name = "buttonNoHeuristic";
            this.buttonNoHeuristic.Size = new System.Drawing.Size(145, 79);
            this.buttonNoHeuristic.TabIndex = 26;
            this.buttonNoHeuristic.Text = "Pas d\'heuristique";
            this.buttonNoHeuristic.UseVisualStyleBackColor = false;
            this.buttonNoHeuristic.Click += new System.EventHandler(this.buttonNoHeuristic_Click);
            // 
            // buttonOptimisedManhattanHeuristic
            // 
            this.buttonOptimisedManhattanHeuristic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonOptimisedManhattanHeuristic.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.buttonOptimisedManhattanHeuristic.ForeColor = System.Drawing.Color.Black;
            this.buttonOptimisedManhattanHeuristic.Location = new System.Drawing.Point(177, 328);
            this.buttonOptimisedManhattanHeuristic.Name = "buttonOptimisedManhattanHeuristic";
            this.buttonOptimisedManhattanHeuristic.Size = new System.Drawing.Size(145, 79);
            this.buttonOptimisedManhattanHeuristic.TabIndex = 29;
            this.buttonOptimisedManhattanHeuristic.Text = "Heuristique de Manhattan optimisée";
            this.buttonOptimisedManhattanHeuristic.UseVisualStyleBackColor = false;
            this.buttonOptimisedManhattanHeuristic.Click += new System.EventHandler(this.buttonOptimisedManhattanHeuristic_Click);
            // 
            // buttonSize5
            // 
            this.buttonSize5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonSize5.Font = new System.Drawing.Font("Roboto Condensed", 16.2F);
            this.buttonSize5.ForeColor = System.Drawing.Color.Black;
            this.buttonSize5.Location = new System.Drawing.Point(177, 97);
            this.buttonSize5.Name = "buttonSize5";
            this.buttonSize5.Size = new System.Drawing.Size(145, 79);
            this.buttonSize5.TabIndex = 31;
            this.buttonSize5.Text = "Taquin 5x5";
            this.buttonSize5.UseVisualStyleBackColor = false;
            this.buttonSize5.Click += new System.EventHandler(this.buttonSize5_Click);
            // 
            // buttonRandomTaquin
            // 
            this.buttonRandomTaquin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonRandomTaquin.Enabled = false;
            this.buttonRandomTaquin.Font = new System.Drawing.Font("Roboto Condensed", 16.2F);
            this.buttonRandomTaquin.ForeColor = System.Drawing.Color.Black;
            this.buttonRandomTaquin.Location = new System.Drawing.Point(12, 579);
            this.buttonRandomTaquin.Name = "buttonRandomTaquin";
            this.buttonRandomTaquin.Size = new System.Drawing.Size(330, 79);
            this.buttonRandomTaquin.TabIndex = 24;
            this.buttonRandomTaquin.Text = "Aléatoire";
            this.buttonRandomTaquin.UseVisualStyleBackColor = false;
            this.buttonRandomTaquin.Click += new System.EventHandler(this.buttonRandomTaquin_Click);
            // 
            // buttonManhattanHeuristic
            // 
            this.buttonManhattanHeuristic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonManhattanHeuristic.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.buttonManhattanHeuristic.ForeColor = System.Drawing.Color.Black;
            this.buttonManhattanHeuristic.Location = new System.Drawing.Point(26, 328);
            this.buttonManhattanHeuristic.Name = "buttonManhattanHeuristic";
            this.buttonManhattanHeuristic.Size = new System.Drawing.Size(145, 79);
            this.buttonManhattanHeuristic.TabIndex = 28;
            this.buttonManhattanHeuristic.Text = "Heuristique de Manhattan";
            this.buttonManhattanHeuristic.UseVisualStyleBackColor = false;
            this.buttonManhattanHeuristic.Click += new System.EventHandler(this.buttonManhattanHeuristic_Click);
            // 
            // buttonHumanlyResolution
            // 
            this.buttonHumanlyResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonHumanlyResolution.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.buttonHumanlyResolution.ForeColor = System.Drawing.Color.Black;
            this.buttonHumanlyResolution.Location = new System.Drawing.Point(177, 243);
            this.buttonHumanlyResolution.Name = "buttonHumanlyResolution";
            this.buttonHumanlyResolution.Size = new System.Drawing.Size(145, 79);
            this.buttonHumanlyResolution.TabIndex = 27;
            this.buttonHumanlyResolution.Text = "Résolution Humaine";
            this.buttonHumanlyResolution.UseVisualStyleBackColor = false;
            this.buttonHumanlyResolution.Click += new System.EventHandler(this.buttonHumanlyResolution_Click);
            // 
            // buttonHardTaquin
            // 
            this.buttonHardTaquin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonHardTaquin.Enabled = false;
            this.buttonHardTaquin.Font = new System.Drawing.Font("Roboto Condensed", 15F);
            this.buttonHardTaquin.ForeColor = System.Drawing.Color.Black;
            this.buttonHardTaquin.Location = new System.Drawing.Point(236, 482);
            this.buttonHardTaquin.Name = "buttonHardTaquin";
            this.buttonHardTaquin.Size = new System.Drawing.Size(106, 79);
            this.buttonHardTaquin.TabIndex = 23;
            this.buttonHardTaquin.Text = "Difficile";
            this.buttonHardTaquin.UseVisualStyleBackColor = false;
            this.buttonHardTaquin.Click += new System.EventHandler(this.buttonHardTaquin_Click);
            // 
            // buttonMiddleTaquin
            // 
            this.buttonMiddleTaquin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonMiddleTaquin.Enabled = false;
            this.buttonMiddleTaquin.Font = new System.Drawing.Font("Roboto Condensed", 15F);
            this.buttonMiddleTaquin.ForeColor = System.Drawing.Color.Black;
            this.buttonMiddleTaquin.Location = new System.Drawing.Point(124, 482);
            this.buttonMiddleTaquin.Name = "buttonMiddleTaquin";
            this.buttonMiddleTaquin.Size = new System.Drawing.Size(106, 79);
            this.buttonMiddleTaquin.TabIndex = 22;
            this.buttonMiddleTaquin.Text = "Moyen";
            this.buttonMiddleTaquin.UseVisualStyleBackColor = false;
            this.buttonMiddleTaquin.Click += new System.EventHandler(this.buttonMiddleTaquin_Click);
            // 
            // buttonEasyTaquin
            // 
            this.buttonEasyTaquin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonEasyTaquin.Enabled = false;
            this.buttonEasyTaquin.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEasyTaquin.ForeColor = System.Drawing.Color.Black;
            this.buttonEasyTaquin.Location = new System.Drawing.Point(12, 482);
            this.buttonEasyTaquin.Name = "buttonEasyTaquin";
            this.buttonEasyTaquin.Size = new System.Drawing.Size(106, 79);
            this.buttonEasyTaquin.TabIndex = 21;
            this.buttonEasyTaquin.Text = "Facile";
            this.buttonEasyTaquin.UseVisualStyleBackColor = false;
            this.buttonEasyTaquin.Click += new System.EventHandler(this.buttonEasyTaquin_Click);
            // 
            // labelTaquin
            // 
            this.labelTaquin.AutoSize = true;
            this.labelTaquin.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaquin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.labelTaquin.Location = new System.Drawing.Point(72, 431);
            this.labelTaquin.Name = "labelTaquin";
            this.labelTaquin.Size = new System.Drawing.Size(190, 29);
            this.labelTaquin.TabIndex = 17;
            this.labelTaquin.Text = "Taquins prédéfinis";
            // 
            // labelHeuristic
            // 
            this.labelHeuristic.AutoSize = true;
            this.labelHeuristic.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeuristic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.labelHeuristic.Location = new System.Drawing.Point(104, 202);
            this.labelHeuristic.Name = "labelHeuristic";
            this.labelHeuristic.Size = new System.Drawing.Size(123, 29);
            this.labelHeuristic.TabIndex = 6;
            this.labelHeuristic.Text = "Heuristique";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.labelSize.Location = new System.Drawing.Point(127, 53);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(66, 29);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Taille";
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.panelResults.Controls.Add(this.listBoxSolutionTree);
            this.panelResults.Controls.Add(this.labelCountClosed);
            this.panelResults.Controls.Add(this.labelCountOpened);
            this.panelResults.Controls.Add(this.labelSolution);
            this.panelResults.Controls.Add(this.buttonDisplaySolution);
            this.panelResults.Controls.Add(this.labelTree);
            this.panelResults.ForeColor = System.Drawing.Color.Black;
            this.panelResults.Location = new System.Drawing.Point(1061, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(329, 742);
            this.panelResults.TabIndex = 21;
            // 
            // listBoxSolutionTree
            // 
            this.listBoxSolutionTree.ForeColor = System.Drawing.Color.Black;
            this.listBoxSolutionTree.FormattingEnabled = true;
            this.listBoxSolutionTree.ItemHeight = 16;
            this.listBoxSolutionTree.Location = new System.Drawing.Point(9, 98);
            this.listBoxSolutionTree.Name = "listBoxSolutionTree";
            this.listBoxSolutionTree.Size = new System.Drawing.Size(308, 340);
            this.listBoxSolutionTree.TabIndex = 30;
            // 
            // labelCountClosed
            // 
            this.labelCountClosed.AutoSize = true;
            this.labelCountClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.labelCountClosed.Location = new System.Drawing.Point(30, 496);
            this.labelCountClosed.Name = "labelCountClosed";
            this.labelCountClosed.Size = new System.Drawing.Size(184, 17);
            this.labelCountClosed.TabIndex = 29;
            this.labelCountClosed.Text = "Nombre de noeuds fermés :";
            // 
            // labelCountOpened
            // 
            this.labelCountOpened.AutoSize = true;
            this.labelCountOpened.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.labelCountOpened.Location = new System.Drawing.Point(30, 460);
            this.labelCountOpened.Name = "labelCountOpened";
            this.labelCountOpened.Size = new System.Drawing.Size(188, 17);
            this.labelCountOpened.TabIndex = 28;
            this.labelCountOpened.Text = "Nombre de noeuds ouverts :";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.ForeColor = System.Drawing.Color.Black;
            this.labelSolution.Location = new System.Drawing.Point(30, 580);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(0, 17);
            this.labelSolution.TabIndex = 27;
            // 
            // buttonDisplaySolution
            // 
            this.buttonDisplaySolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonDisplaySolution.Enabled = false;
            this.buttonDisplaySolution.Font = new System.Drawing.Font("Roboto Condensed", 16.2F);
            this.buttonDisplaySolution.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplaySolution.Location = new System.Drawing.Point(67, 621);
            this.buttonDisplaySolution.Name = "buttonDisplaySolution";
            this.buttonDisplaySolution.Size = new System.Drawing.Size(227, 79);
            this.buttonDisplaySolution.TabIndex = 24;
            this.buttonDisplaySolution.Text = "Afficher solution";
            this.buttonDisplaySolution.UseVisualStyleBackColor = false;
            this.buttonDisplaySolution.Click += new System.EventHandler(this.buttonDisplaySolution_Click);
            // 
            // labelTree
            // 
            this.labelTree.AutoSize = true;
            this.labelTree.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.labelTree.Location = new System.Drawing.Point(132, 52);
            this.labelTree.Name = "labelTree";
            this.labelTree.Size = new System.Drawing.Size(64, 29);
            this.labelTree.TabIndex = 5;
            this.labelTree.Text = "Arbre";
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.buttonSolve.Enabled = false;
            this.buttonSolve.Font = new System.Drawing.Font("Roboto Condensed", 16.2F);
            this.buttonSolve.ForeColor = System.Drawing.Color.Black;
            this.buttonSolve.Location = new System.Drawing.Point(598, 621);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(227, 79);
            this.buttonSolve.TabIndex = 25;
            this.buttonSolve.Text = "Résoudre";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // formTaquin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1390, 733);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.labelTitle);
            this.Name = "formTaquin";
            this.Text = "Taquin";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void afficheTaquin()
        {
            this.TB1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.TB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TB1.Location = new System.Drawing.Point(539, 180);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(50, 50);
            this.TB1.TabIndex = 26;
            this.TB1.Text = "1";
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelHeuristic;
        private System.Windows.Forms.Label labelTaquin;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label labelTree;
        private System.Windows.Forms.Button buttonEasyTaquin;
        private System.Windows.Forms.Button buttonMiddleTaquin;
        private System.Windows.Forms.Button buttonHardTaquin;
        private System.Windows.Forms.Button buttonRandomTaquin;
        private System.Windows.Forms.Button buttonDisplaySolution;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button TB1;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label labelCountOpened;
        private System.Windows.Forms.Label labelCountClosed;
        private System.Windows.Forms.ListBox listBoxSolutionTree;
        private System.Windows.Forms.Button buttonNoHeuristic;
        private System.Windows.Forms.Button buttonOptimisedManhattanHeuristic;
        private System.Windows.Forms.Button buttonManhattanHeuristic;
        private System.Windows.Forms.Button buttonHumanlyResolution;
        private System.Windows.Forms.Button buttonSize3;
        private System.Windows.Forms.Button buttonSize5;
    }
}