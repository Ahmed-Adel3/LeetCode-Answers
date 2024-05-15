public class Node{
    public Node next;
    public Node prev;
    public int val;
    public int key;
    public Node(int key, int val)
    {
        this.key = key;
        this.val = val;
        next = null;
        prev = null;
    }
}

public class LRUCache {

    Dictionary<int,Node> items;
    int capacity;
    Node head;
    Node tail;

    public LRUCache(int capacity) {
        items = new Dictionary<int,Node>();
        this.capacity = capacity; 
        head = new Node(0,0);
        tail = new Node(0,0);

        head.next = tail;
        head.prev = tail;
        tail.next = head;
        tail.prev = head;
    }

    public void Remove(Node node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    public void Insert(Node node)
    {
        node.prev = tail.prev;
        tail.prev.next = node;
        node.next = tail;
        tail.prev = node;
    }
    
    public int Get(int key) {
        if(items.ContainsKey(key))
        {
            var item = items[key];
            Remove(item);
            Insert(item);
            return item.val;
        }
        else 
            return -1;
    }
    
    public void Put(int key, int value) {
        if(items.ContainsKey(key))
        {
            Remove(items[key]);
        }

        items[key] = new Node(key,value);
        Insert(items[key]);
        if(items.Count > capacity){
            items.Remove(head.next.key);
            Remove(head.next);
        }
    }
}