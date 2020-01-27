namespace Graph_Coloring
{
    partial class Menu
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AddVerticeButton = new System.Windows.Forms.Button();
            this.GreedyAlgorithmButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.LargestFirstButton = new System.Windows.Forms.Button();
            this.GreedyAlgorithmWithRelapsesButton = new System.Windows.Forms.Button();
            this.LargestNotColoredFirstButton = new System.Windows.Forms.Button();
            this.NeighboursColorCountColoringButton = new System.Windows.Forms.Button();
            this.ColorCountTextLabel = new System.Windows.Forms.Label();
            this.ColorCountLabel = new System.Windows.Forms.Label();
            this.StepByStepCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearEdgesButton = new System.Windows.Forms.Button();
            this.ColoringAlgorithmsOprionsLabel = new System.Windows.Forms.Label();
            this.StepByStepAdvencedInfoLabel = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBox.Location = new System.Drawing.Point(20, 121);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1150, 520);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // AddVerticeButton
            // 
            this.AddVerticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddVerticeButton.Location = new System.Drawing.Point(20, 23);
            this.AddVerticeButton.Name = "AddVerticeButton";
            this.AddVerticeButton.Size = new System.Drawing.Size(140, 80);
            this.AddVerticeButton.TabIndex = 1;
            this.AddVerticeButton.Text = "Add Vertice Enabled";
            this.AddVerticeButton.UseVisualStyleBackColor = true;
            this.AddVerticeButton.Click += new System.EventHandler(this.AddVerticeButton_Click);
            // 
            // GreedyAlgorithmButton
            // 
            this.GreedyAlgorithmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreedyAlgorithmButton.Location = new System.Drawing.Point(1191, 143);
            this.GreedyAlgorithmButton.Name = "GreedyAlgorithmButton";
            this.GreedyAlgorithmButton.Size = new System.Drawing.Size(140, 80);
            this.GreedyAlgorithmButton.TabIndex = 2;
            this.GreedyAlgorithmButton.Text = "Greedy Algorithm Graph Coloring";
            this.GreedyAlgorithmButton.UseVisualStyleBackColor = true;
            this.GreedyAlgorithmButton.Click += new System.EventHandler(this.GreedyAlgorithmButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearAllButton.Location = new System.Drawing.Point(1030, 23);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(140, 80);
            this.ClearAllButton.TabIndex = 3;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEdgeButton.Location = new System.Drawing.Point(180, 23);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(140, 80);
            this.AddEdgeButton.TabIndex = 4;
            this.AddEdgeButton.Text = "Add Edge\n Disabled";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);
            // 
            // LargestFirstButton
            // 
            this.LargestFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LargestFirstButton.Location = new System.Drawing.Point(1191, 354);
            this.LargestFirstButton.Name = "LargestFirstButton";
            this.LargestFirstButton.Size = new System.Drawing.Size(140, 80);
            this.LargestFirstButton.TabIndex = 5;
            this.LargestFirstButton.Text = "Largest First  Graph Coloring";
            this.LargestFirstButton.UseVisualStyleBackColor = true;
            this.LargestFirstButton.Click += new System.EventHandler(this.LargestFirstButton_Click);
            // 
            // GreedyAlgorithmWithRelapsesButton
            // 
            this.GreedyAlgorithmWithRelapsesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreedyAlgorithmWithRelapsesButton.Location = new System.Drawing.Point(1191, 250);
            this.GreedyAlgorithmWithRelapsesButton.Name = "GreedyAlgorithmWithRelapsesButton";
            this.GreedyAlgorithmWithRelapsesButton.Size = new System.Drawing.Size(140, 80);
            this.GreedyAlgorithmWithRelapsesButton.TabIndex = 6;
            this.GreedyAlgorithmWithRelapsesButton.Text = "Greedy Algorithm WithRelapses Graph Coloring";
            this.GreedyAlgorithmWithRelapsesButton.UseVisualStyleBackColor = true;
            this.GreedyAlgorithmWithRelapsesButton.Click += new System.EventHandler(this.GreedyAlgorithmWithRelapsesButton_Click);
            // 
            // LargestNotColoredFirstButton
            // 
            this.LargestNotColoredFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LargestNotColoredFirstButton.Location = new System.Drawing.Point(1191, 459);
            this.LargestNotColoredFirstButton.Name = "LargestNotColoredFirstButton";
            this.LargestNotColoredFirstButton.Size = new System.Drawing.Size(140, 80);
            this.LargestNotColoredFirstButton.TabIndex = 7;
            this.LargestNotColoredFirstButton.Text = "Largest Not Colored First  Graph Coloring";
            this.LargestNotColoredFirstButton.UseVisualStyleBackColor = true;
            this.LargestNotColoredFirstButton.Click += new System.EventHandler(this.LargestNotColoredFirstButton_Click);
            // 
            // NeighboursColorCountColoringButton
            // 
            this.NeighboursColorCountColoringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NeighboursColorCountColoringButton.Location = new System.Drawing.Point(1191, 561);
            this.NeighboursColorCountColoringButton.Name = "NeighboursColorCountColoringButton";
            this.NeighboursColorCountColoringButton.Size = new System.Drawing.Size(140, 80);
            this.NeighboursColorCountColoringButton.TabIndex = 8;
            this.NeighboursColorCountColoringButton.Text = "Neighbours Color Count Coloring";
            this.NeighboursColorCountColoringButton.UseVisualStyleBackColor = true;
            this.NeighboursColorCountColoringButton.Click += new System.EventHandler(this.NeighboursColorCountColoringButton_Click);
            // 
            // ColorCountTextLabel
            // 
            this.ColorCountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColorCountTextLabel.Location = new System.Drawing.Point(1193, 23);
            this.ColorCountTextLabel.Name = "ColorCountTextLabel";
            this.ColorCountTextLabel.Size = new System.Drawing.Size(138, 23);
            this.ColorCountTextLabel.TabIndex = 9;
            this.ColorCountTextLabel.Text = "Color Count:";
            this.ColorCountTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorCountLabel
            // 
            this.ColorCountLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ColorCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColorCountLabel.Location = new System.Drawing.Point(1196, 62);
            this.ColorCountLabel.Name = "ColorCountLabel";
            this.ColorCountLabel.Size = new System.Drawing.Size(135, 51);
            this.ColorCountLabel.TabIndex = 10;
            this.ColorCountLabel.Text = "0";
            this.ColorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepByStepCheckBox
            // 
            this.StepByStepCheckBox.AutoSize = true;
            this.StepByStepCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepByStepCheckBox.Location = new System.Drawing.Point(354, 62);
            this.StepByStepCheckBox.Name = "StepByStepCheckBox";
            this.StepByStepCheckBox.Size = new System.Drawing.Size(181, 22);
            this.StepByStepCheckBox.TabIndex = 11;
            this.StepByStepCheckBox.Text = "Step By Step Solutions";
            this.StepByStepCheckBox.UseVisualStyleBackColor = true;
            this.StepByStepCheckBox.CheckedChanged += new System.EventHandler(this.StepByStepCheckBox_CheckedChanged);
            // 
            // ClearEdgesButton
            // 
            this.ClearEdgesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearEdgesButton.Location = new System.Drawing.Point(853, 23);
            this.ClearEdgesButton.Name = "ClearEdgesButton";
            this.ClearEdgesButton.Size = new System.Drawing.Size(148, 80);
            this.ClearEdgesButton.TabIndex = 12;
            this.ClearEdgesButton.Text = "Clear Edges";
            this.ClearEdgesButton.UseVisualStyleBackColor = true;
            this.ClearEdgesButton.Click += new System.EventHandler(this.ClearEdgesButton_Click);
            // 
            // ColoringAlgorithmsOprionsLabel
            // 
            this.ColoringAlgorithmsOprionsLabel.AutoSize = true;
            this.ColoringAlgorithmsOprionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColoringAlgorithmsOprionsLabel.Location = new System.Drawing.Point(350, 24);
            this.ColoringAlgorithmsOprionsLabel.Name = "ColoringAlgorithmsOprionsLabel";
            this.ColoringAlgorithmsOprionsLabel.Size = new System.Drawing.Size(199, 18);
            this.ColoringAlgorithmsOprionsLabel.TabIndex = 13;
            this.ColoringAlgorithmsOprionsLabel.Text = "Coloring Algorithms Oprions:";
            // 
            // StepByStepAdvencedInfoLabel
            // 
            this.StepByStepAdvencedInfoLabel.AutoSize = true;
            this.StepByStepAdvencedInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepByStepAdvencedInfoLabel.Location = new System.Drawing.Point(605, 23);
            this.StepByStepAdvencedInfoLabel.Name = "StepByStepAdvencedInfoLabel";
            this.StepByStepAdvencedInfoLabel.Size = new System.Drawing.Size(193, 18);
            this.StepByStepAdvencedInfoLabel.TabIndex = 14;
            this.StepByStepAdvencedInfoLabel.Text = "Step By Step Advenced Info:";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepLabel.Location = new System.Drawing.Point(605, 55);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(74, 18);
            this.StepLabel.TabIndex = 15;
            this.StepLabel.Text = "Step: 0 / 0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 653);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.StepByStepAdvencedInfoLabel);
            this.Controls.Add(this.ColoringAlgorithmsOprionsLabel);
            this.Controls.Add(this.ClearEdgesButton);
            this.Controls.Add(this.StepByStepCheckBox);
            this.Controls.Add(this.ColorCountLabel);
            this.Controls.Add(this.ColorCountTextLabel);
            this.Controls.Add(this.NeighboursColorCountColoringButton);
            this.Controls.Add(this.LargestNotColoredFirstButton);
            this.Controls.Add(this.GreedyAlgorithmWithRelapsesButton);
            this.Controls.Add(this.LargestFirstButton);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.GreedyAlgorithmButton);
            this.Controls.Add(this.AddVerticeButton);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu";
            this.Text = "Graph Coloring";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button AddVerticeButton;
        private System.Windows.Forms.Button GreedyAlgorithmButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.Button LargestFirstButton;
        private System.Windows.Forms.Button GreedyAlgorithmWithRelapsesButton;
        private System.Windows.Forms.Button LargestNotColoredFirstButton;
        private System.Windows.Forms.Button NeighboursColorCountColoringButton;
        private System.Windows.Forms.Label ColorCountTextLabel;
        private System.Windows.Forms.Label ColorCountLabel;
        private System.Windows.Forms.CheckBox StepByStepCheckBox;
        private System.Windows.Forms.Button ClearEdgesButton;
        private System.Windows.Forms.Label ColoringAlgorithmsOprionsLabel;
        private System.Windows.Forms.Label StepByStepAdvencedInfoLabel;
        private System.Windows.Forms.Label StepLabel;
    }
}

