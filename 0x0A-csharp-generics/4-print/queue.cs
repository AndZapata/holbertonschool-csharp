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
        public T value;
        public Node next = null;
        public Node(T val)
        {
            this.value = val;
        }
    }
    public Node head;
    public Node tail;
    public int count = 0;

    /// <summary>
    /// Adds a  new node to the end of the queue.
    /// </summary>
    /// <param name="val">The value to be added in a new node</param>
    public void Enqueue(T val)
    {
        Node node = new Node(val);

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

    /// <summary>
    /// removes the first node in the queue
    /// </summary>
    /// <returns> returns its value </returns>
    public T Dequeue()
	{
		Node current;
		if (this.head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		current = this.head;
		this.head = current.next;
		count--;
		return current.value;
	}

    /// <summary>
    /// function to peek the first value of a queue
    /// </summary>
    /// <returns> Returns the first value of a queue, defautl if empty</returns>
    public T Peek()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return this.head.value;
    }

    /// <summary>
    /// Function to print the values in a queue, print default if empty
    /// </summary>
    public void Print()
    {
        if (this.head == null)
            Console.WriteLine("Queue is empty");
        Node current;
        current = this.head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }
}
