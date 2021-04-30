using System;
using System.Collections.Generic;
using Day23;

class Solution
{
    static Queue<Node> queue = new Queue<Node>();
    static void levelOrder(Node root)
    {
        if (root != null)
        {
            Console.Write(root.data + " ");
            if (root.left != null)
            {
                queue.Enqueue(root.left);
            }

            if (root.right != null)
            {
                queue.Enqueue(root.right);
            }

            if (queue.Count != 0)
            {
                levelOrder(queue.Dequeue());
            }
        }
    }
    
    static void Main(String[] args)
    { 
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = Actions.insert(root, data);
        }
        levelOrder(root);
    }
}