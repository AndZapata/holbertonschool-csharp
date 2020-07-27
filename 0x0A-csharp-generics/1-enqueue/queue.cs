using System;

/// <summary>
/// Clase Queue Does not inherit from anything
/// </summary>
/// <typeparam name="T">param type</typeparam>
class Queue<T>
{
    /// <summary>
    /// Function to check the type of a param
    /// </summary>
    /// <returns>The type of the param</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Class Node inside queue class
    /// </summary>
    public class Node
    {
        T value;
        public Node next = null;
        public Node(T val)
        {
        this.value = val;
        }
    }
    public Node head;
    public Node tail;
    int count = 0;

    /// <summary>   
    /// Adds a  new node to the end of the queue.
    /// </summary>
    /// <param name="val">The value to be added in a new node</param>
    public void Enqueue(T val)
    {
        Node newNode = new Node(val);

        if (this.head == null)
        this.head = newNode;
        if (this.tail != null)
        this.tail.next = newNode;
        this.tail = newNode;
        this.count++;
    }

    /// <summary>
    /// Returns the number of nodes in a queue.
    /// </summary>
    public int Count()
    {
        return this.count;
    }
}
