using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring.Algorithms
{
    public class GreedyColoringWithRelapses
    {
        private Graph graph = new Graph();

        private List<int> usedColors = new List<int>();
        private List<int>[] availableColours;
        private int[] lowerColor;

        bool saveHistory = false;
        private List<Vertice> colorHistory = new List<Vertice>();

        public GreedyColoringWithRelapses(Graph graph)
        {
            this.graph = graph;
        }

        public GreedyColoringWithRelapses(Graph graph, bool saveHistory)
        {
            this.graph = graph;
            this.saveHistory = saveHistory;
        }

        public void StartColoring()
        {
            graph.ResetColors();
            Initialize();

            for (int i = 0; i < graph.Count(); i++)
            {
                lowerColor[i] = int.MinValue;
                availableColours[i] = new List<int>();
            }

           if (graph.Count() <= 0)
                return;
            else if (graph.Count() == 1)
                 ColoringVertice(0, 1);
            else
                StartGreedyColoringWithRelapses();
        }

        private void Initialize()
        {
            availableColours = new List<int>[graph.Count()];
            lowerColor = new int[graph.Count()];
        }

        private List<int> GetAvailableColors(int vertice, int maxColor)
        {
            // Pozyskiwanie informacji o użytych kolorach sąsiadow wierzchołka k
            List<int> neighboursColors = graph.GetPreviousNeighboursColors(graph.vertices[vertice]);

            // Sprawdzanie jakie kolory mogą być użyte z listy wszystkich kolorów których nie posiadają sąsiedzi
            List<int> colorsCanBeUsed = usedColors.Where(p => !neighboursColors.Any((p2) => p2 == p)).ToList();
            colorsCanBeUsed.Remove(0);

            // Jezeli nie znaleziono żadnego możliwego do użycia koloru
            if (colorsCanBeUsed.Count == 0)
            {
                if (usedColors.Max() + 1 <= maxColor)
                {
                    return new List<int>() { usedColors.Max() + 1 };
                }
                else
                {
                    return new List<int>() { };
                }
            }
            // Jeżeli istnieje przynajmniej jeden kolor który można uzyć
            else
            {
                if (usedColors.Max() + 1 <= maxColor)
                {
                    colorsCanBeUsed.Add(usedColors.Max() + 1);
                }
                return colorsCanBeUsed.Where((x) => x <= maxColor).ToArray().ToList();
            }
        }

        private void ColoringVertice(int vertice, int color)
        {
            //Console.WriteLine("Colored vertice " + vertice + " color " + color);
            //PrintAvailableColors(vertice);
            graph.vertices[vertice].Color = color;

            if (saveHistory)
                colorHistory.Add(new Vertice(graph.vertices[vertice]));

            if (!usedColors.Contains(color))
            {
                usedColors.Add(color);
            }
        }

        private int FindFirstVerticeByColor(int color)
        {
            int minIndex = int.MaxValue;
            int minColor = int.MaxValue;

            for (int i = 0; i < graph.Count(); i++)
            {
                if (graph.vertices[i].Color >= color && minColor > graph.vertices[i].Color && minIndex > i)
                {
                    minColor = graph.vertices[i].Color;
                    minIndex = i;
                }
            }
            if (minIndex == int.MaxValue) throw new ArgumentException("Not Found Any Vertice Has Color: " + color);
            return minIndex;
        }

        private void StartGreedyColoringWithRelapses()
        {
            Graph resultGraph = new Graph();
            int actualMaxColor = 1;
            int vertice = 0;
            lowerColor[vertice] = actualMaxColor;
            ColoringVertice(0, 1);
            int q = graph.Count();
            int lowerboundColor = int.MaxValue;
            bool increase = true;

            do
            {
                if (vertice == -1)
                    break;

                if (increase)
                {
                    lowerColor[vertice] = actualMaxColor;
                    vertice = vertice + 1;
                    availableColours[vertice] = GetAvailableColors(vertice, actualMaxColor + 1);
                }

                if (availableColours[vertice].Count == 0)
                {
                    vertice = vertice - 1;
                    actualMaxColor = lowerColor[vertice];
                    increase = false;
                }
                else
                {
                    // Kolorowanie wierzchołka
                    int color = 0;
                    color = availableColours[vertice].Min();
                    availableColours[vertice].Remove(color);
                    ColoringVertice(vertice, color);

                    if (color > actualMaxColor)
                    {
                        actualMaxColor = actualMaxColor + 1;
                    }

                    if (vertice < graph.Count() - 1)
                    {
                        increase = true;
                    }
                    else
                    {
                        // Zapamiętywanie ilości kolorów
                        if (usedColors.Count < lowerboundColor)
                        {
                            lowerboundColor = usedColors.Count;
                        }
                        // Zapamietywanie aktualnego rozwiazania
                        resultGraph = new Graph(graph);

                        // Znalezienie wierzchołka pokolorowanego maksymalnym kolorem w danej iteracji
                        int v = FindFirstVerticeByColor(actualMaxColor);

                        // Cofniecie i usuniecie koloru ze zbiorow dostępnych kolorów
                        for (int ind = 0; ind < v; ind++)
                        {
                            for (int jnd = actualMaxColor; jnd < q; jnd++)
                            {
                                availableColours[ind].Remove(jnd);
                            }
                        }
                       
                        q = actualMaxColor;
                        actualMaxColor = q - 1;
                        vertice = v - 1;
                        increase = false;
                    }
                }
            } while (((vertice != 0) && (actualMaxColor != lowerboundColor))); // Koniec w momencie gdy cofniemy się do pierwszego wierzcholka i actualMaxColor bedzie rowne lowerboundColor

            // Ustawienie najlepszego rozwiązania
            graph = new Graph(resultGraph);
        }

        private void PrintAvailableColors(int k)
        {
            Console.Write("AC_" + (k).ToString() + "=" + '{');
            for (int i = 0; i < availableColours[k].Count; i++)
            {
                if (i != availableColours[k].Count - 1)
                {
                    Console.Write((availableColours[k][i]).ToString() + ',');
                }
                else
                {
                    Console.Write((availableColours[k][i]).ToString());
                }
            }
            Console.WriteLine("}");
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