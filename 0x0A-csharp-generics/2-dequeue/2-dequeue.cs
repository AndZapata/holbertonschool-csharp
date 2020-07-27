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
        public Node(T value)
        {
            this.value = value;
        }
    }
    public Node head;
    public Node tail;
    int count = 0;

    /// <summary>
    /// Adds a  new node to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added in a new node</param>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        if (this.head == null)
            this.head = node;
        if (this.tail != null)
            this.tail.next = node;
        this.tail = node;
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
