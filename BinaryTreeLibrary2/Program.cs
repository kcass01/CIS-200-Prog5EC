// Program 5EC
// CIS 200-76
// Fall 2017
// Due: 12/5/2017
// By: D7010

// File: Program.cs
// This console app tests the gneric binary tree
// it does so through a test with an int dree, a double tree, and a string tree

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeLibrary2;

namespace BinaryTreeLibrary2
{
    class Program
    {
        //precondition:none
        //postcondition: binary trees of various types created and displayed
        static void Main(string[] args)
        {
            //binary tree of ints
            Tree<int> intTree = new Tree<int>();
            //add 10 values
            intTree.InsertNode(12);
            intTree.InsertNode(24);
            intTree.InsertNode(5);
            intTree.InsertNode(8);
            intTree.InsertNode(111);
            intTree.InsertNode(72);
            intTree.InsertNode(7);
            intTree.InsertNode(55);
            intTree.InsertNode(43);
            intTree.InsertNode(32);

            Console.WriteLine("Int Tree In order Traversal");
            intTree.InorderTraversal();

            //pause between outputs
            Pause();

            //binary tree of double values
            Tree<double> doubleTree = new Tree<double>();
            //add 10 doubles to tree
            doubleTree.InsertNode(1.25);
            doubleTree.InsertNode(3.75);
            doubleTree.InsertNode(0.99);
            doubleTree.InsertNode(4.99);
            doubleTree.InsertNode(9.87);
            doubleTree.InsertNode(6.62);
            doubleTree.InsertNode(4.45);
            doubleTree.InsertNode(2.25);
            doubleTree.InsertNode(3.33);
            doubleTree.InsertNode(1.17);

            Console.WriteLine("Double Tree in Order Traversal");
            doubleTree.InorderTraversal();
            //pause again between inputs
            Pause();

            //binary tree of string values
            Tree<string> stringTree = new Tree<string>();
            //insert 10 strings into tree
            stringTree.InsertNode("Hello");
            stringTree.InsertNode("Alphabet");
            stringTree.InsertNode("Louisville");
            stringTree.InsertNode("Kentucky");
            stringTree.InsertNode("Indiana");
            stringTree.InsertNode("Finals");
            stringTree.InsertNode("Test");
            stringTree.InsertNode("Order");
            stringTree.InsertNode("String");

            Console.WriteLine("String Tree in Order Traversal");
            stringTree.InorderTraversal();
            //pause again between inputs
            Pause();
        }

        //precondition: none
        //postcondition: pauses until user input then clears
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.Clear(); // Clears screen
        }
    }



}
