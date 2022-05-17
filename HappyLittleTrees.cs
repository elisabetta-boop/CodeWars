// Create a Tree class so I can grow a happy little tree. The tree has a trunk and branches which grow in unit sizes. Branches can start at the current trunk height. All branches grow simultaneously,

// Methods to include:

// Tree() - Constructor (trunk starts with height of 1 and no branches)
// GrowTrunk() - Increase trunk height by 1 (add a new level on top of the tree similar to adding layers to a cake)
// NewBranch() - Add a new branch at the current height (multiple separate branches can be added at each level)
// GrowBranches() - All existing branches increase in length by 1
// Ouch(int n) - The nth oldest branch is removed (the input is 1-indexed, and must be validated: if a branch does not exist or the input is not positive, do nothing)
// Description() - Returns a string describing all the properties of the tree as seen below (replace the _ with appropiate values, )
// "The tree trunk is {HEIGHT} unit(s) tall! There are {BRANCHES_COUNT} branch(es) that have position(s): {POSITIONS...} and length(s): {LENGTHS...}!"
// Where HEIGHT and BRANCHES_COUNT are integers, POSITIONS... and LENGTHS... are comma-separated lists.

// If there are no branches, the following string should be returned instead:

// "The tree trunk is {HEIGHT} unit(s) tall! There are 0 branch(es)!"


using System;
using System.Collections.Generic;
using System.Linq;

/*
functions:
  void GrowTrunk();
  void GrowBranches();
  void NewBranch();
  void Ouch(int n);
  string Description();
*/

public class Tree : ITree
{

  int treeHeight = 1;
        List<Branch> branches = new List<Branch>();

        private class Branch
        {
            public int Position { get; set; }
            public int BranchLength { get; set; }

            public Branch(int position, int branchLength = 1)
            {
                Position = position;
                BranchLength = branchLength;
            }

        }

        public void GrowTrunk()
        {
            treeHeight++;
        }

        public void NewBranch()
        {
            branches.Add(new Branch(treeHeight)  );
        }

        public void GrowBranches()
        {
            foreach (var branch in branches)
            {
                branch.BranchLength++;
            }
        }

        public void Ouch(int index)
        {
          if (branches.Count > 0 && index < branches.Count && index > 0 )
          {
            branches.RemoveAt( index-1 );
          }
        }

        public string Description()
        {
            if (branches.Count > 0)
            {
                var positions = string.Join(",",branches.Select(b => b.Position));
                var lengths = string.Join(",", branches.Select(b => b.BranchLength));

                var description = "The tree trunk is "
                                    + treeHeight.ToString()
                                    +" unit(s) tall! There are " + branches.Count + " branch(es) that have position(s): " 
                                    + positions
                                    + " and length(s): "
                                    + lengths + "!";
                return description;
            }
            return "The tree trunk is " + treeHeight.ToString() + " unit(s) tall! There are " + branches.Count.ToString() + " branch(es)!";
        }
  
}