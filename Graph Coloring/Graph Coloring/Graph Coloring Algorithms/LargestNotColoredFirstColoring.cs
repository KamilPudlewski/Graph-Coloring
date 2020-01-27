using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring.Algorithms
{
    public class LargestNotColoredFirstColoring
    {
        private Graph graph = new Graph();
        private List<int> colors = new List<int>();

        bool saveHistory = false;
        private List<Vertice> colorHistory = new List<Vertice>();

        public LargestNotColoredFirstColoring(Graph graph)
        {
            this.graph = graph;
        }

        public LargestNotColoredFirstColoring(Graph graph, bool saveHistory)
        {
            this.graph = graph;
            this.saveHistory = saveHistory;
        }

        public void StartColoring()
        {
            graph.ResetColors();
            InitializeColors();
            Graph coloredGraph = new Graph();


            for (int i = 0; i < graph.Count(); i++)
            {
                SortGraphByNotColoredNeighboursCountDescending();
                bool coloredStatus = false;
                int j = 0;

                while (!coloredStatus)
                {
                    if (coloredGraph.GetVertice(graph.vertices[j].Number) == null)
                    {
                        List<int> neighboursColors = graph.GetNeighboursColors(graph.vertices[j]);
                        var enableColors = colors.Where(c => !neighboursColors.Contains(c));
                        graph.vertices[j].Color = enableColors.Min();
                        coloredGraph.vertices.Add(graph.vertices[j]);
                        coloredStatus = true;
                        if (saveHistory)
                            colorHistory.Add(new Vertice(graph.vertices[j]));
                    }
                    j++;
                }
            }
            graph = coloredGraph;
        }

        private void InitializeColors()
        {
            colors.Clear();
            for (int i = 1; i <= graph.Count(); i++)
            {
                colors.Add(i);
            }
        }

        private void SortGraphByNotColoredNeighboursCountDescending()
        {
            Graph sortedGraph = new Graph();
            sortedGraph.vertices = graph.SortByNotColoredNeighboursCountDescending();
            graph = sortedGraph;
        }

        public Graph ReturnGraph()
        {
            return graph;
        }

        public List<Vertice> ReturnColorHistory()
        {
            return colorHistory;
        }
    }
}
