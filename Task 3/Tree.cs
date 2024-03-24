using System;
using System.Collections.Generic;

class Tree
{
    public List<Tree> childes = new List<Tree>();
    public string gen { get; private set; }

    public Tree(string gen)
    {
        this.gen = gen;
    }

    public void AddChild(Tree child)
    {
        childes.Add(child);
    }

    public void ShowFamily(string prefix = "")
    {
        Console.WriteLine(prefix + gen);

        foreach (var child in childes)
        {
            child.ShowFamily(prefix + "  ");
        }
    }
}
