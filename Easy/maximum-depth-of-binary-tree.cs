// 1st
public class Solution {
    public int MaxDepth(TreeNode root) {
        int deepest = 0;
        if (root != null)
        {
            var Nodes = new List<TreeNode>();
            Nodes.Add(root);
            while (Nodes.Count > 0)
            {
                deepest++;
                var ChildNodes = new List<TreeNode>();
                for (int m = 0; m < Nodes.Count; m++)
                {
                    if (Nodes[m].left != null)
                        ChildNodes.Add(Nodes[m].left);
                    if (Nodes[m].right != null)
                        ChildNodes.Add(Nodes[m].right);
                }
                Nodes = ChildNodes;
            }
        }
        return deepest;
    }
}

// 2nd
public class Solution {
    public int deepest = 0;
    public void CountDepth(TreeNode tn, int deep)
    {
    	deep++;
        if (tn.left != null)
            CountDepth(tn.left, deep);
        if (tn.right != null)
            CountDepth(tn.right, deep);
        if (deep > deepest)
            deepest = deep;
    }
    public int MaxDepth(TreeNode root) {
        if (root != null)
            CountDepth(root, 0);
        return deepest;
    }
}
