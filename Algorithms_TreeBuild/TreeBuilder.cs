using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms_TreeBuild
{
    public class TreeBuilder
    {
        public class TreeNode
        {
            public string Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(string value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public  TreeNode BuildTree(string[] sortedData)
        {
            if (sortedData == null || sortedData.Length == 0)
                return null;

            // Build a balanced binary search tree from the sorted data
            return BuildTreeHelper(sortedData, 0, sortedData.Length - 1); ;
        }

        public  TreeNode BuildTreeHelper(string[] sortedData, int start, int end)
        {
            if (start > end)
                return null;

            // Find the middle index
            int mid = (start + end) / 2;

            // Create a new node with the middle value
            TreeNode node = new TreeNode(sortedData[mid]);

            // Recursively build the left and right subtrees
            node.Left = BuildTreeHelper(sortedData, start, mid - 1);
            node.Right = BuildTreeHelper(sortedData, mid + 1, end);

            return node;
        }
    }
}
