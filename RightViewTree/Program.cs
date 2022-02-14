// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Node tree = new Node(5);
tree.left = new Node(4);
//tree.left.left = new Node(3);
tree.right = new Node(6);
tree.right.right = new Node(7);
tree.right.left = new Node(3);
//Console.WriteLine(IsBST(tree));


IList<int> RightSideView(Node root)
{
    var res = new Dictionary<int, int>();
    HelperView(0, root, res);
    return res.Values.ToList();
}

static void HelperView(int depth, Node root, Dictionary<int, int> Dic)
{
    if (root == null)
        return;

    if (!Dic.ContainsKey(depth))
        Dic[depth] = root.data;

    HelperView(depth + 1, root.right, Dic);
    HelperView(depth + 1, root.left, Dic);


}
