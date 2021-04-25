using System;
class Node{
    public Node left,right; // wezel lewy i prawy
    public int data; // wartosc węzła
    public Node(int data){ // wstawianie węzła
        this.data=data;
        left=right=null;
    }
}
class Solution{
    // RECURSIVE
    static int GetHeight(Node root){
        // z Czego składa się root ?
        // LEWY WEZEL - root.left
        // PRAWY WEZEL - root.right
        // WARTOSC KORZENIA - data
        // Liczba połączeń od korzenia do naajwyższego liścia = wysokość 
        //                           3 - data
        //                        /     \
        //                       2       5 - root.right
        //                      /      /   \
        //                     1      4     6
        //                                   \
        //                                    7

        if (root == null)
        {
            return -1;
        }
        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);

        return (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
    }
    
    static Node Insert(Node root, int data){
        if(root == null){
            return new Node(data); // jeśli korzen jest null to wstaw korzeN
        }
        else{
            Node node; // tworzy nowy wezel ktory będzie lewym lub prawym synem w zaleności od wartości
            if(data <= root.data){ // Jeśli wartośc wezla jest mniejsza lub równa wartosci korzenia to wstaw po lewej
                node = Insert(root.left,data); // wstawienie węzła
                root.left = node; // lewy wezel korzenia = cur
            }
            else{
                node = Insert(root.right,data);  // jeśli wartosc nowego wezla jest WIĘKSZA od wartosci korzenia
                root.right = node;               // WSTAW PRAWY WEZEL
            }
            return root; // zwroc węzeł
        }
    }
    static void Main(String[] args){
        Node root = null;
        int T = Int32.Parse(Console.ReadLine()); // ilośc węzłów
        
        while(T --> 0){ 
            int data = Int32.Parse(Console.ReadLine()); // wczytywanie wartości węzłów
            root = Insert(root,data); // wstawianie węzła           
        }
        int height = GetHeight(root); // pobranie wysokości węzła
        Console.WriteLine(height);
    }
}