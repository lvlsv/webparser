using System.Collections.ObjectModel;

namespace TestTree
{
    class Node
    {
        public string Name { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }
    }
}
