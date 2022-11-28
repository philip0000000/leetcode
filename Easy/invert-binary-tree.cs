// 1st
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return root;
        var Parent = new List<TreeNode>();
        Parent.Add(root);
        var ParentTemp = new List<TreeNode>();
        
        // get all values
        while (Parent.Count > 0)
        {
            ParentTemp.Clear();
            for (int m = 0; m < Parent.Count; m++)
            {
                var tempLeft = Parent[m].left; // invert the two child TreeNodes
                Parent[m].left = Parent[m].right;
                Parent[m].right = tempLeft;
                if (Parent[m].left != null)
                    ParentTemp.Add(Parent[m].left);
                if (Parent[m].right != null)
                    ParentTemp.Add(Parent[m].right);
            }
            Parent = new List<TreeNode>(ParentTemp);
        }
        
        return root;
    }
}

// 2nd
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root != null)
        {
            var Parent = new List<TreeNode>();
            Parent.Add(root);
            // get all values
            while (Parent.Count > 0)
            {
                var ParentTemp = new List<TreeNode>();
                for (int m = 0; m < Parent.Count; m++)
                {
                    (Parent[m].left, Parent[m].right) = (Parent[m].right, Parent[m].left);
                    if (Parent[m].left != null)
                        ParentTemp.Add(Parent[m].left);
                    if (Parent[m].right != null)
                        ParentTemp.Add(Parent[m].right);
                }
                Parent = ParentTemp;
            }
        }
        return root;
    }
}

// 3rd
public class Solution {
    public static void Invert(TreeNode tn)
    {
        (tn.left, tn.right) = (tn.right, tn.left); // invert the two child TreeNodes
        if (tn.left != null)
            Invert(tn.left);
        if (tn.right != null)
            Invert(tn.right);
    }
    public TreeNode InvertTree(TreeNode root) {
        if (root != null)
            Invert(root);
        return root;
    }
}
