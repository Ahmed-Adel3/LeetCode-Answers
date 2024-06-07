public class Solution {
    public class TrieNode {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public string word = null;
    }
    public class Trie {
        private TrieNode root;

        public Trie() {
            root = new TrieNode();
        }

        public void Insert(string word) {
            TrieNode node = root;
            foreach (char c in word) {
                if (!node.children.ContainsKey(c)) {
                    node.children[c] = new TrieNode();
                }
                node = node.children[c];
            }
            node.word = word;
        }

        public string SearchPrefix(string word) {
            TrieNode node = root;
            foreach (char c in word) {
                if (!node.children.ContainsKey(c)) {
                    break;
                }
                node = node.children[c];
                if (node.word != null) {
                    return node.word;
                }
            }
            return word;
        }
    }
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        // Build the Trie from the dictionary
        Trie trie = new Trie();
        foreach (string root in dictionary) {
            trie.Insert(root);
        }
        
        // Split the sentence into words
        string[] words = sentence.Split(' ');
        StringBuilder result = new StringBuilder();

        // Process each word in the sentence
        foreach (string word in words) {
            if (result.Length > 0) {
                result.Append(" ");
            }
            result.Append(trie.SearchPrefix(word));
        }
        
        // Return the final sentence
        return result.ToString();
    }
}