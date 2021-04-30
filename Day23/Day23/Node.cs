namespace Day23
{
    public class Node
    {
        public Node left, right; // lewy prawy syn
        public int data; // zawartość węzła

        public Node(int data)
        {
            // konstruktor dot. węzła
            this.data = data; // konstruktor ustawia wartośc węzła oraz lewego i prawego syna null
            left = right = null;
        }
    }
}