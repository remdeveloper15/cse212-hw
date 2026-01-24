using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and check order of removal
    // Expected Result: Items with higher priority come out first
    // Defect(s) Found: 1 Error. The priority is not being respected. It was expected "B", but it is "A". 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", priority: 2);
        priorityQueue.Enqueue("B", priority: 3);
        priorityQueue.Enqueue("C", priority: 1);

        var fisrt = priorityQueue.Dequeue();
        Assert.AreEqual("B", fisrt);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("A", second);

        var third = priorityQueue.Dequeue();
        Assert.AreEqual("C", third);
    }

    //Documentation: Code has been corrected. The Dequeue function has been corrected to respect the FIFO order. Also, the remove function has been added to dequeue correctly each object. 

    [TestMethod]
    // Scenario: Add items with same priority and should come out in order added (FIFO)
    // Expected Result: Items come out in insertion order when priority is the same
    // Defect(s) Found: 1 Error. Exptected result was A, but is B. The Dequeue function is not working with a FIFO order. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", priority: 2);
        priorityQueue.Enqueue("B", priority: 2);
        priorityQueue.Enqueue("C", priority: 2);

        var first = priorityQueue.Dequeue();
        Assert.AreEqual("A", first);
        
        var second = priorityQueue.Dequeue();
        Assert.AreEqual("B", second);

        var third = priorityQueue.Dequeue();
        Assert.AreEqual("C", third);
    }

    //Documentation: Code has been updated. Dequeue function has been fixed to respect the FIFO order in case that to objects has the same prioroty
    // Add more test cases as needed below.
}