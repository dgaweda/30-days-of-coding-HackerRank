using System;
using System.Collections.Generic;

namespace Day23
{
    static class Actions
    {
        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }

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
    }
}