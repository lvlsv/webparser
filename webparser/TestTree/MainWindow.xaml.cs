using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestTree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Node> nodes;
        List<List<string>> treeList = new List<List<string>>();
        public MainWindow()
        {
            InitializeComponent();
            nodes = new ObservableCollection<Node>
        {
            new Node
            {
                Name ="Европа",
                Nodes = new ObservableCollection<Node>
                {
                    new Node {Name="Германия" },
                    new Node {Name="Франция" },
                    new Node
                    {
                        Name ="Великобритания",
                        Nodes = new ObservableCollection<Node>
                        {
                            new Node {Name="Англия" },
                            new Node {Name="Шотландия" },
                            new Node {Name="Уэльс" },
                            new Node {Name="Сев. Ирландия" },
                        }
                    }
                }
            },
            new Node
            {
                Name ="Азия",
                Nodes = new ObservableCollection<Node>
                {
                    new Node {Name="Китай" },
                    new Node {Name="Япония" },
                    new Node { Name ="Индия" }
                }
            },
            new Node { Name="Африка" },
            new Node { Name="Америка" },
            new Node { Name="Австралия" }
        };
            trview.Items.Add(nodes);
        }

        private void AddItemsToList()
        {
            treeList.Add(new List<string>
            {
                "test1", "test2", "test3"
            });

            treeList.Add(new List<string>
            {
                "zet1", "zet2", "zet3"
            });
        }

    }
}
