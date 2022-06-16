using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDs;

public class TreeNode<T>
{
    public int key { get; set; }
    public TreeNode<T> parent { get; set; }
    public TreeNode<T> left { get; set; }
    public TreeNode<T> right { get; set; }
    public T data { get; set; }

    public TreeNode(int key, T data)
    {
        this.key = key;
        this.data = data;
    }
}

public class BinarySearchTree<T>
{
    public TreeNode<T> root { get; set; }

    public void PrintTreeInorder()
    {
        PrintTreeInorder(this.root);
        Console.WriteLine("\n");
    }
    public void PrintTreeInorder(TreeNode<T> node)
    {
        if (node != null)
        {
            PrintTreeInorder(node.left);
            Console.Write($"{node.key}  ");
            PrintTreeInorder(node.right);
        }
    }

    public TreeNode<T> Search(int key)
    {
        return Search(this.root, key);
    }
    static public TreeNode<T> Search(TreeNode<T> root, int key)
    {
        if ((root == null) || (root.key == key))
        {
            return root;
        }
        if (key < root.key)
        {
            return Search(root.left, key);
        }
        else
        {
            return Search(root.right, key);
        }
    }

    public TreeNode<T> Minimum()
    {
        return Minimum(this.root);
    }
    static public TreeNode<T> Minimum(TreeNode<T> root)
    {
        while (root.left != null)
        {
            root = root.left;
        }
        return root;
    }

    public TreeNode<T> Maximum()
    {
        return Maximum(this.root);
    }
    static public TreeNode<T> Maximum(TreeNode<T> root)
    {
        while(root.right != null)
        {
            root = root.right;
        }
        return root;
    }

    static public TreeNode<T> Successor(TreeNode<T> node)
    {
        if (node.right != null)
        {
            return Minimum(node.right);
        }
        else
        {
            TreeNode<T> ancestor = node.parent;
            while ((ancestor != null) && (node == ancestor.right))
            {
                node = ancestor;
                ancestor = ancestor.parent;
            }
            return ancestor;
        }
    }
    public bool Insert(TreeNode<T> node)
    {
        return Insert(this, node);
    }
    static public bool Insert(BinarySearchTree<T> tree, TreeNode<T> node)
    {
        TreeNode<T> tempNode = null;
        TreeNode<T> root = tree.root;
        while (root != null)
        {
            tempNode = root;
            if (node.key < root.key)
            {
                root = root.left;
            }
            else
            {
                root = root.right;
            }
        }
        node.parent = tempNode;
        // Tree is empty
        if (tempNode == null)
        {
            tree.root = node;
        }
        // Insert in left subtree if key smaller
        else if (node.key < tempNode.key)
        {
            tempNode.left = node;
        }
        // Else insert in right subtree
        else
        {
            tempNode.right = node;
        }

        return true;
    }

    static public void Transplant(BinarySearchTree<T> tree, TreeNode<T> u, TreeNode<T> v)
    {
        if (u.parent == null)
        {
            tree.root = v;
        }
        else if (u == u.parent.left)
        {
            u.parent.left = v;
        }
        else
        {
            u.parent.right = v;
        }
        if (v != null)
        {
            v.parent = u.parent;
        }
    }

    public bool Delete(TreeNode<T> node)
    {
        return Delete(this, node);
    }
    static public bool Delete(BinarySearchTree<T> tree, TreeNode<T> node)
    {
        if (node.left == null)
        {
            Transplant(tree, node, node.right);
        }
        else if (node.right == null)
        {
            Transplant(tree, node, node.left);
        }
        else
        {
            TreeNode<T> minimum = Minimum(node.right);
            if (minimum.parent != node)
            {
                Transplant(tree, minimum, minimum.right);
                minimum.right = node.right;
                minimum.right.parent = minimum;
            }
            Transplant(tree, node, minimum);
            minimum.left = node.left;
            minimum.left.parent = minimum;
        }
        return true;
    }
}