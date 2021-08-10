#nullable enable
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Algos
{
    internal static class FindClosestValueInBST
    {
        //Write a function that takes in
        //a Binary Search tree(BST) and a target integer
        //value and returns the closest value to that target value
        //contained in the BST
        
        //You can assume that there will be only one closest value
        
        //Each BST node has an integer value, a left child node, and a right
        //child node. A node is said to be a valid BST node if and only
        //if it satisfies the BST property: its value is strictly greater 
        //that the values of every node to its left; its value is less that or equal
        //to the values of every node to its right; and its children nodes
        // are either valid BST nodes themselves or None/Null.
        
        //Sample input
        //                     10
        //          5                         15
        //      2         5              13          22
        //  1     n    n      n        n     14     n    n
        
        //target = 12
        
        public static void Run()
        {
            var tree = Tree();
        }

        private static Node Tree()
        {
            var root = new Node(){ Right = null, Left = null, value = 15};
            return root;
            
            // if difference is 1 ... return...
            // if difference is greater than 1...  continue searching for the closest one
            
        }

        private class Node
        {
            public Node? Right { get; set; }
            public Node? Left { get; set; }
            
            public int value;
        }
    }
}