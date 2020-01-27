using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph_Coloring.GUI;
using Graph_Coloring.Algorithms;

namespace Graph_Coloring
{
    public partial class Menu : Form
    {
        private GraphGraphic gui;
        private Graph graph = new Graph();
        private Graph relapsesResultGraph = new Graph();

        private bool enableVerticePaint = true;
        private bool enableEdgePaint = false;
        private int verticeNumber = 0;
        private Vertice firstVertice = null;

        private string sortAlgorithm = "";
        private int stepNumber = 0;
        private int stepCount = 0;
        private List<Vertice> colorHistory = new List<Vertice>();

        public Menu()
        {
            InitializeComponent();
            gui = new GraphGraphic(PictureBox);

            StepByStepAdvencedInfoLabel.Text = "";
            StepLabel.Text = "";
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (enableVerticePaint)
            {
                Vertice vertice = new Vertice(e.X, e.Y, verticeNumber);
                graph.AddVertice(vertice);
                verticeNumber++;
                AddVerticeOrEdgeReset();
                gui.DrawVertice(vertice);
            }
            
            if (enableEdgePaint)
            {
                if (graph.Count() >= 1 && firstVertice == null)
                {
                    firstVertice = GetClosestVertice(e);
                    gui.DrawVerticeGold(firstVertice);
                }
                else if (graph.Count() >= 1)
                {
                    Vertice secondVertice = GetClosestVertice(e);
                    if (firstVertice != secondVertice)
                    {
                        graph.AddEdge(firstVertice, secondVertice);
                        gui.DrawEdge(firstVertice, secondVertice);
                        ResetClickedVertice();
                        AddVerticeOrEdgeReset();
                    }
                }
            }
        }

        private void ResetClickedVertice()
        {
            if (firstVertice != null)
            {
                gui.DrawVertice(firstVertice);
                firstVertice = null;
            }
        }

        private void AddVerticeOrEdgeReset()
        {
            if (sortAlgorithm != "")
            {
                sortAlgorithm = "";
                ResetStepByStepOptions();
                SetColorCount(0);

                graph.ResetColors();
                gui.DrawAllVertice(graph);
            }
        }

        public Vertice GetClosestVertice(MouseEventArgs mouse)
        {
            double bestDistance = double.MaxValue;
            int bestIndex = -1;

            for (int i = 0; i < graph.Count(); i++)
            {
                if (bestDistance > CalculateDistance(mouse, graph.vertices[i]))
                {
                    bestDistance = CalculateDistance(mouse, graph.vertices[i]);
                    bestIndex = i;
                }
            }

            return graph.vertices[bestIndex];
        }

        public double CalculateDistance(MouseEventArgs mouse, Vertice vertice)
        {
            return Math.Sqrt(Math.Pow(vertice.X - mouse.X, 2) + Math.Pow(vertice.Y - mouse.Y, 2));
        }

        private void AddVerticeButton_Click(object sender, EventArgs e)
        {
            enableVerticePaint = !enableVerticePaint;

            if (enableVerticePaint)
            {
                AddVerticeButton.Text = "Print Vertice Enabled";

                enableEdgePaint = false;
                AddEdgeButton.Text = "Add Edge Disabled";
            }
            else
            {
                AddVerticeButton.Text = "Print Vertice Disabled";
            }
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            enableEdgePaint = !enableEdgePaint;

            if (enableEdgePaint)
            {
                AddEdgeButton.Text = "Add Edge Enabled";

                enableVerticePaint = false;
                AddVerticeButton.Text = "Add Vertice Disabled";
            }
            else
            {
                AddEdgeButton.Text = "Add Edge Disabled";
            }
        }

        private void StepByStepAlgotythmLogic()
        {
            ResetClickedVertice();

            if (stepNumber == stepCount)
            {
                graph.ResetColors();
                gui.DrawAllVertice(graph);
            }
            else if (stepNumber == stepCount + 1)
            {
                stepNumber = 0;
                gui.DrawVertice(colorHistory[stepNumber]);
            }
            else
                gui.DrawVertice(colorHistory[stepNumber]);

            if (stepCount > 0)
                stepNumber++;

            if (stepNumber < stepCount + 1)
                StepInfoUpdate();
            else
            {
                stepNumber = 0;
                StepInfoUpdate();
            }
        }

        private void StepByStepRelapsesAlgotythmLogic()
        {
            if (stepNumber == stepCount)
            {
                gui.DrawAllVertice(relapsesResultGraph);
            }
            else if (stepNumber == stepCount + 1)
            {
                graph.ResetColors();
                gui.DrawAllVertice(graph);
            }
            else if (stepNumber == stepCount + 2)
            {
                stepNumber = 0;
                gui.DrawVertice(colorHistory[stepNumber]);
            }
            else
                gui.DrawVertice(colorHistory[stepNumber]);

            if (stepCount > 0)
                stepNumber++;

            if (stepNumber < stepCount + 2)
                StepInfoUpdate();
            else
            {
                stepNumber = 0;
                StepInfoUpdate();
            }
        }

        private void StepInfoUpdate()
        {
            if (StepByStepCheckBox.Checked)
            {
                StepLabel.Text = "Step: " + stepNumber + " / " + stepCount;

                if (stepNumber > stepCount)
                {
                    StepLabel.Text = "Step: Result";
                }
            }
        }

        private void StepByStepCheckBox_CheckedChanged(Object sender, EventArgs e)
        {
            if (StepByStepCheckBox.Checked)
            {
                StepByStepAdvencedInfoLabel.Text = "Step By Step Advenced Info:";
                StepLabel.Text = "Step: " + stepNumber + " / " + stepCount;
            }
            else
            {
                StepByStepAdvencedInfoLabel.Text = "";
                StepLabel.Text = "";
            }
        }

        private void GreedyAlgorithmButton_Click(object sender, EventArgs e)
        {
            if (StepByStepCheckBox.Checked)
            {
                if (sortAlgorithm != "Greedy Coloring: Step By Step" || stepNumber == 0)
                {
                    GreedyColoring graphColoring = new GreedyColoring(graph, true);
                    graphColoring.StartColoring();
                    SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());

                    colorHistory = graphColoring.ReturnColorHistory();
                    stepNumber = 0;
                    stepCount = colorHistory.Count;

                    graph.ResetColors();
                    gui.DrawAllVertice(graph);
                }

                sortAlgorithm = "Greedy Coloring: Step By Step";
                StepByStepAlgotythmLogic();
            }
            else
            {
                GreedyColoring graphColoring = new GreedyColoring(graph);
                graphColoring.StartColoring();
                gui.DrawAllVertice(graphColoring.ReturnGraph());
                SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());
                if (sortAlgorithm != "Greedy Coloring")
                {
                    ResetStepByStepOptions();
                }
                sortAlgorithm = "Greedy Coloring";
            }
        }

        private void GreedyAlgorithmWithRelapsesButton_Click(object sender, EventArgs e)
        {
            if (StepByStepCheckBox.Checked)
            {
                if (sortAlgorithm != "Greedy Coloring With Relapses: Step By Step" || stepNumber == 0)
                {
                    sortAlgorithm = "Greedy Coloring With Relapses: Step By Step";

                    GreedyColoringWithRelapses graphColoring = new GreedyColoringWithRelapses(graph, true);
                    graphColoring.StartColoring();
                    SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());
                    relapsesResultGraph = graphColoring.ReturnGraph();

                    colorHistory = graphColoring.ReturnColorHistory();
                    stepNumber = 0;
                    stepCount = colorHistory.Count;

                    graph.ResetColors();
                    gui.DrawAllVertice(graph);
                }

                StepByStepRelapsesAlgotythmLogic();
                sortAlgorithm = "Greedy Coloring With Relapses: Step By Step";
            }
            else
            {
                GreedyColoringWithRelapses graphColoring = new GreedyColoringWithRelapses(graph);
                graphColoring.StartColoring();
                gui.DrawAllVertice(graphColoring.ReturnGraph());
                SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());
                if (sortAlgorithm != "Greedy Coloring With Relapses")
                {
                    sortAlgorithm = "Greedy Coloring With Relapses";
                    ResetStepByStepOptions();
                }
                sortAlgorithm = "Greedy Coloring With Relapses";
            }
        }

        private void LargestFirstButton_Click(object sender, EventArgs e)
        {
            if (StepByStepCheckBox.Checked)
            {
                if (sortAlgorithm != "LargestFirstColoring: Step By Step" || stepNumber == 0)
                {
                    LargestFirstColoring graphColoring = new LargestFirstColoring(graph, true);
                    graphColoring.StartColoring();
                    SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());

                    colorHistory = graphColoring.ReturnColorHistory();
                    stepNumber = 0;
                    stepCount = colorHistory.Count;

                    graph.ResetColors();
                    gui.DrawAllVertice(graph);
                }

                sortAlgorithm = "LargestFirstColoring: Step By Step";
                StepByStepAlgotythmLogic();
            }
            else
            {
                LargestFirstColoring graphColoring = new LargestFirstColoring(graph);
                graphColoring.StartColoring();
                gui.DrawAllVertice(graphColoring.ReturnGraph());
                SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());
                if (sortAlgorithm != "Largest First Coloring")
                {
                    ResetStepByStepOptions();
                }
                sortAlgorithm = "Largest First Coloring";
            }
        }

        private void LargestNotColoredFirstButton_Click(object sender, EventArgs e)
        {
            if (StepByStepCheckBox.Checked)
            {
                if (sortAlgorithm != "Largest Not Colored First Coloring: Step By Step" || stepNumber == 0)
                {
                    LargestNotColoredFirstColoring graphColoring = new LargestNotColoredFirstColoring(graph, true);
                    graphColoring.StartColoring();
                    SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());

                    colorHistory = graphColoring.ReturnColorHistory();
                    stepNumber = 0;
                    stepCount = colorHistory.Count;

                    graph.ResetColors();
                    gui.DrawAllVertice(graph);
                }

                sortAlgorithm = "Largest Not Colored First Coloring: Step By Step";
                StepByStepAlgotythmLogic();
            }
            else
            {
                LargestNotColoredFirstColoring graphColoring = new LargestNotColoredFirstColoring(graph);
                graphColoring.StartColoring();
                gui.DrawAllVertice(graphColoring.ReturnGraph());
                SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());
                if (sortAlgorithm != "Largest Not Colored First Coloring")
                {
                    ResetStepByStepOptions();
                }
                sortAlgorithm = "Largest Not Colored First Coloring";
            }
        }

        private void NeighboursColorCountColoringButton_Click(object sender, EventArgs e)
        {
            if (StepByStepCheckBox.Checked)
            {
                if (sortAlgorithm != "Neighbours Color Count Coloring: Step By Step" || stepNumber == 0)
                {
                    NeighboursColorCountColoring graphColoring = new NeighboursColorCountColoring(graph, true);
                    graphColoring.StartColoring();
                    SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());

                    colorHistory = graphColoring.ReturnColorHistory();
                    stepNumber = 0;
                    stepCount = colorHistory.Count;

                    graph.ResetColors();
                    gui.DrawAllVertice(graph);
                }

                sortAlgorithm = "Neighbours Color Count Coloring: Step By Step";
                StepByStepAlgotythmLogic();
            }
            else
            {
                NeighboursColorCountColoring graphColoring = new NeighboursColorCountColoring(graph);
                graphColoring.StartColoring();
                gui.DrawAllVertice(graphColoring.ReturnGraph());
                SetColorCount(graphColoring.ReturnGraph().ChromaticNumber());
                if (sortAlgorithm != "Neighbours Color Count Coloring")
                {
                    ResetStepByStepOptions();
                }
                sortAlgorithm = "Neighbours Color Count Coloring";
            }
        }

        private void SetColorCount(int number)
        {
            ColorCountLabel.Text = number.ToString();
        }

        private void ClearEdgesButton_Click(object sender, EventArgs e)
        {
            gui.Clear();
            graph.DeleteAllEdges();
            graph.ResetColors();
            ResetClickedVertice();
            gui.DrawAllVertice(graph);
            SetColorCount(0);
            ResetStepByStepOptions();
    }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            gui.Clear();
            graph = new Graph();
            verticeNumber = 0;
            firstVertice = null;
            SetColorCount(0);
            ResetStepByStepOptions();
        }

        private void ResetStepByStepOptions()
        {
            sortAlgorithm = "";
            stepNumber = 0;
            stepCount = 0;
            colorHistory.Clear();
            StepInfoUpdate();
        }
    }
}
