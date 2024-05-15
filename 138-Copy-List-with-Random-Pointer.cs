/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    
    Dictionary<Node,Node> NodeDict = new Dictionary<Node,Node>();

    public Node CopyRandomList(Node head) {
        if(head == null)
            return null;
        var newNode = CloneNode(head);
        CloneRandom(newNode);
        return newNode;
    }

    public Node CloneNode(Node node){
        var newNode = new Node(node.val);
        NodeDict.Add(node,newNode);
        if(node.next != null)
            newNode.next = CloneNode(node.next);
        return newNode;
    }

    public void CloneRandom(Node newNode){
        var oldNode = NodeDict.FirstOrDefault(a=> ReferenceEquals(a.Value,newNode)).Key;

        if(oldNode != null && oldNode.random != null)
            newNode.random = NodeDict[oldNode.random];
        if(newNode.next != null)
            CloneRandom(newNode.next);
    }
}