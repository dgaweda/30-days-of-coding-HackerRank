using System;
using System.Collections.Generic;

class Node
{
    public int data;
    public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {
    public static Node Insert(Node head,int data)
    {
        
    }

    public static void Display(Node head)
    {
        Node start=head; // EMPTY LINKED LIST which i should add something
        while(start!=null)
        {
            Console.Write(start.data + " ");
            start=start.next;
        }
    }
    static void Main(String[] args) {
	
        Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=Insert(head,data);
        }
        Display(head);
    }
}