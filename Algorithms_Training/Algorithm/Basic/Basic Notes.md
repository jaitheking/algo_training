# Note to Data Structures


## Singly & Doubly Linked Lists

Definition : A linked list is a sequential list of nodes that hold data which point to other nodes also containing data.

> Data --> Data --> Data --> Data --> null

Uses :
    1. Used in List, Queue & Stack implementations
    2. Can easily model real world objects such a train
    3. Used in separate chaining, which is present certain Hashtable to deal with hashigh collisions
    4. Often used in the implementation of adjacency list for graphs.

Terminology:
    1. Head - The first node
    2. Tail - The last node in a linked list
    3. Pointer - Reference to another node
    4. Node - An object containing data and pointers

Singly vs Doubly Linked List :

Singly has only the pointers to the next sequential node. 
Doubly has pointers to the next sequential node as well as the previous node. It has access to head and tail

> Data <--> Data <--> Data <--> null // Example of doubly linked list

Pros and Cons :

|List |Pros|Cons|
|Singly|Uses less memory & simpler| Cannot easily access previous elements|
|Doubly|Can be traversed backwards|Takes 2x memory|

Complexity Analysis
-----------

|Operation|Singly Linked|Doubly Linked|
|-|-|-|
|Search|O(n)|O(n)|
|Insert at the head |O(1)|O(1)|
|Insert at tail | O(1)|O(1)|
|Remove at head|O(1)|O(1)|
|Remove at tail|O(n)|O(1)|
|Remove in middle|O(n)|O(n)|

## Stack

Definition : A stack is one-ended linear data structure, having two primary operations, namely push and pop.
The top pointer is always accessible (LIFO)

Uses: 
    1. Used by undo mechanisms in text editors.
    2. Used in compiler syntax checking for matching brackets and braces.
    3. Can be used to model a pile of books or plates
    4. Used behind the scenes to support recursion by keeping track of previous function calls.
    5. Can be used to do a Depth First Search (DFS) on a graph

Complexity:
|Operation|Complexity|
|-|-|
|Pushing|O(1)|
|Popping|O(1)|
|Peeking|O(1)|
|Searching|O(n)| 
|Size|O(1)|

Terminology:

Pushing - Add an object to the stack
Popping - Removing an object at the top of the stack
Tower of Hanoi is one of the main principle observable in stack data structures


## Queue

Definition:
A queue is a linear data structure which models real world queues by having two primary operations:enqueue and dequeue.

Terminology:
Enqueue - Adding an object at the end of a queue
Dequeue - Removing an object at the start of a queue

Uses:
    1. Any waiting line models a queue
    2. Can be used to efficiently keey track of the x most recently added elements.
    3. Web server request management where you want first come first serve (FIFO)
    4. Breadth first search (BFS) graph traversal.

Complexity:

|Operation|Complexity|
|-|-|
|Enqueue|O(1)|
|Dequeue|O(1)|
|Peeking|O(1)|
|Contains|O(n)|
|Removal|O(n)|
|Is Empty|O(1)|

## Priority Queues
### (PQs) with an interlude on heaps

Definition:
Abstract Data type that operates similar to a normal queue except that each element has a certain priority.

Note: Priority queues only supports comparable data


Terminology:
Min Heap,Max Heap


Uses:
    1. Used in certain implementations of Dijkstra's shortest path algorithm
    2. Anytime you need the dynamically fetch the "next best" or "next worst" element
    3. Used in Huffman coding
    4. Best First Search
    5. Used by Minimum Spanning Tree

Complexity:
|Operation|Complexity|
|-|-|
|Binary Heap construction|O(n)|
|Polling|O(log(n))
|Peeking|O(1)|
|Adding|O(log(n))|
|Naive Removing|O(n)|
|Advanced remove with Hash Table|O(log(n))|
|Naive contains|O(n)|
|Contains with Hash Table|O(1)|

** Using Hashtable will take up space

 
## Union Find

Definition : A data structure that keeps track of elements which are split into one or more disjoint sets.

Terminology:
Find - Return elements
Union - Merges two groups

Uses:
    1. Kruskal's Minimum spanning tree
    2. Grid percolation
    3. network connectivity
    4. Least common ancestor in trees
    5. Image processing


Kruskal's Minimum Spanning Tree
1. Sort edges by ascending edge weight
2. Walk through the sorted edges and look at the two nodes the edge belongs to, if the nodes are already unified we don't include this edge, otherwise we include it and unify the nodes.
3. The algorithm terminates when every edge has been processed or all the vertices have been unified.


## Heap
A heap is a tree based DS that satisfies the heap invariant (also called heap property): If A is a parent node of B then A is ordered with respect to B for all nodes A, B in the heap


## Binary Tree & Binary Search Tree

Definition : A tree is an undirected graph which satisfies any of the following definitions:

- An acyclic connected graph
- A connected graph with N nodes with N-1 edges.
- A graph in which any two vertices are connected by exactly one path

A binary search tree is a binary tree that satisfies the BST invariant:
left subtree has smaller elements and right subtree has larger elements.


Terminology:
A child is a node extending from another node. A parent is the inverse of this

A leaf node is a node with no children

A subtree is a tree entirely contained within another. They are usually denoted with triangles.

A binary tree is a tree for which every node has at most two child nodes.

Uses:

Binary Search Trees (BSTs) are used in:

- Implementation of some map and set ADTS
- Red Black Trees
- AVL Trees
- Splay Tress
- etc

Used in the implementation of binary heaps
Syntax trees

Treap - a probabilistic DS (uses a randomized BST)


Complexity:

|Operation |Worst|
|-|-|
|Insert|O(n)|
|Delete|O(n)|
|Remove|O(n)|
|Search|O(n)|

** Average case , O(log n)

Adding elements to a BST
Binary Search Tree elements must be comparable so that we can order them inside the tree.

When inserting an element we want to compare its value to the value stored in the current node we're considering to decide on one of the follwoing:

Removing elements from a BST

1. Find the element we wish to remove
2. Replace the node we want to remove with its successor (if any) to maintain the BST invariant

Find Phase
When searching our BST for a node with a particular value one of four things will happen:
1. We hit a null node at which point we know the value does not exist within our BST
2. Comparator value equal to 0 (found it!)
3. Comparator value less than 0 (the value, if it exists, is in the left subtree)
4. Comparator value greater than 0 (the value, if it exists, is in the right subtree)


Remove Phase
1. Node to remove is a leaf node
    a. No side effect when removing
2. Node to remove has a right subtree but no left subtree
    a. Successor or direct child node replaces the node to remove
3. Node to remove has a left subtree but no right subtree
    a. Successor or direct child node replaces the node to remove
4. Node to remove has both a left subtree & right subtree
    a. Successor can either be the largest value in the left subtree or the smallest value in the right subtree

Tree Traversals

Preorder, Inorder, PostOrder  & Level Order

Preorder
``preorder(node):``
``if node ==null:``
``return print (node.value)``
``preorder(node.left)``
``preorder(node.right)``
Preorder prints before the recursive calls

Inorder
``inorder(node):``
``if node == null: return``
``inorder(node.left)``
``print(node.value)``
``inorder(node.right)``
Inorder prints between the recursive calls

PostOrder
``postorder(node):``
``if node == null: return``
``postorder(node.left)``
``postorder(node.right)``
``print(node.value)``
Postorder prints after the recursive calls

Level order Traversal - Print the nodes as they appear one layer at a time
- Can be obtained with Breadth First search (BFS)
- Using a Queue by adding the child node
- Can't be done recursively


## Hash Table (HT)

Definition:
A hash table is a data structure that provides a mapping from keys to values using a technique called hashing.
Commonly the unit are called as key-value pairs.
Keys must be unique,but values can be repeated

Uses:
Commonly used in tracking frequencies
A hash function H(x) is a function that maps a key 'x' to a whole number in a fixed range.
 
 A hash function H(x) must be deterministic. This means that if H(x)=y then H(x) must always produce y and never another value.

 Keys used in our hash table are immutable (Unchanged over time)


 O(1) using a hash function as a way to index into a hash table.

 Hash collision is what occurs when two values have the same hash values. The resolution technique we can use to resolve this:
 - Separate chaining which deal with hash collisions by maintaining a data structure (usually a linked list) to hold all the different values which hashed to a particular value.
 - Open addressing deals with hash collisions by finding another place within the hash table for the object to go by offsetting it from the position to which it hashed to.


Complexity:

|Operation|Average|Worst|
|-|-|-|
|Insertion|O(1)|O(n)|
|Removal|O(1)|O(n)|
|Search|O(1)|O(n)|
* The constant time behavior attributed to hash tables is only true if you have a good uniform hash function


### Hash table separate chaining:
Separate chaining is one of many strategies to deal with hash collisions by maintaining a data structure (usually a linked list) to hold all the different values which hashed to a particular value

### Hash table open addressing:
- Key-value pairs are stored in the table

Terminology:
Load Factor = Item of table / Size of table

Probing sequences : Linear/Quadratic/Double Hashing/Pseudo Random Number Generator

## Fenwick Tree

Definition:
Also called Binary Indexed Tree, a data structure that supports sum range queries as well as setting values in a static array and getting the value of the prefix sum up some index efficiently.

Complexity:

|Operation | Complexity|
|-|-|
|Construction|O(n)|
|Point Update|O(log(n))|
|Range Sum|O(log(n))|
|Range Update|O(log(n))|
|Adding Index |NA|
|Removing Index|NA|

Terminology:  
A specific cell of a Fenwick tree is responsible for other cells as well.
The position of the Least Significant Bit (LSB) determines the range of responsibility that cell has to the cells below itself.

## Suffix Array 

Definition:
An array which contains all the sorted suffixes of a string

Uses:
Finding Unique substrings.


### Longest Common Prefix (LCP) Array
Definition: 
The LCP array is an array in which every index tracks how many characters two sorted adjacent suffixes have in common.

By convention, LCP[0] is undefined, but for most purposes it's fine to set it to zero.

LCP Array can be constructed by many methods (O (log n ) and O(n))

### Finding Unique Substrings

The problem of finding/counting all the unique substrings of a string is a commonplace problem in computer science.

The naive algorithm generates all substrings and places them in a set resulting in a O(n2) algortihm.

A better approach is to use the LCP array. This provides not only a quick but space efficient solution.

The number of unique substring formula:
n(n+1)/2  - Sum of LCP values in the LCP array
E.g. n=5, word ='AZAZA', the number of unique substrings = 9

### Longest Common Substring (K-Common Substring)

Objective : Find the longest common substring that appears in at least 2<= k <= n of the strings

The approach can be solved with dynamic programming in O(n1*n2*n3*n3*....*n of m), or efficiently with suffix array
O(n1+n2+...n of m) time

Longest Repeated Substring (LRS)
LCP array can solve this problem. The brute method requires O(n^2) time and lots of space. 


## Balanced Binary Search Trees (BBST)

Definition:
A balanced binary search tree (BBST) is a self-balancing binary search tree. This type of tree will adjust itself in order to maintain a low (logarithmic) height allowing for faster operations such as insertions and deletions.

Complexity:
For Binary Search Trees
|Operation|Avg .Complexity| Worst|
|-|-|-|
|Insert|O(log(n))|O(n)|
|Delete|O(log(n))|O(n)|
|Remove|O(log(n))|O(n)|
|Search|O(log(n))|O(n)|

Hence, BBST has the following complexity
|Operation|Avg .Complexity| Worst|
|-|-|-|
|Insert|O(log(n))|O(log(n))|
|Delete|O(log(n))|O(log(n))|
|Remove|O(log(n))|O(log(n))|
|Search|O(log(n))|O(log(n))|

Terminology:

The secret ingredient of BBST is the clever usage of a tree invariant and tree rotations
Tree invariant - A property/rule you impose on your tree that it must meet after every operation
Tree Rotations - A valid transformation of values and nodes in the trees as we please as long as the BST invariant remains satisfied.

> function rightRotate(A):  
> B= A.left  
> A.left = B.right  
> B.right = A  
> return B  