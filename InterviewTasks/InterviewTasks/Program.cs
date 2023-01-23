// See https://aka.ms/new-console-template for more information
using Implementations;
//T01
QueueWithArray<string> arrQueue = new QueueWithArray<string>(5);
arrQueue.Enqueue("Deivid");
arrQueue.Enqueue("Ivan");
arrQueue.Enqueue("Petur");
arrQueue.Enqueue("Pesho");
arrQueue.Enqueue("Nasko");
//queue.Enqueue("Nasko"); - the Queue is FULL

Console.WriteLine(arrQueue.Dequeue());
Console.WriteLine(arrQueue.Dequeue());
Console.WriteLine(arrQueue.Dequeue());
Console.WriteLine(arrQueue.Dequeue());
Console.WriteLine(arrQueue.Dequeue());
//Console.WriteLine(queue.Dequeue()); - the Queue is empty at this point
Console.WriteLine();
//T02
QueueWithLinkedList<string> queueWithLinkedList = new QueueWithLinkedList<string>();
queueWithLinkedList.Enqueue("a");
queueWithLinkedList.Enqueue("b");
queueWithLinkedList.Enqueue("c");
queueWithLinkedList.Enqueue("d");
queueWithLinkedList.Enqueue("e");

Console.WriteLine(queueWithLinkedList.Dequeue());
Console.WriteLine(queueWithLinkedList.Dequeue());
Console.WriteLine(queueWithLinkedList.Dequeue());
Console.WriteLine(queueWithLinkedList.Dequeue());
Console.WriteLine(queueWithLinkedList.Dequeue());
Console.WriteLine();
//T03
StackWithArray<string> arrStack = new StackWithArray<string>(5);
arrStack.Push("A");
arrStack.Push("B");
arrStack.Push("C");
arrStack.Push("D");
arrStack.Push("E");

Console.WriteLine(arrStack.Pop());
Console.WriteLine(arrStack.Pop());
Console.WriteLine(arrStack.Pop());
Console.WriteLine(arrStack.Pop());
Console.WriteLine(arrStack.Pop());
Console.WriteLine();

//T04

StackWithLinkedList<int> stackWithLinkedList = new StackWithLinkedList<int>();
stackWithLinkedList.Push(1);
stackWithLinkedList.Push(2);
stackWithLinkedList.Push(3);
stackWithLinkedList.Push(4);
stackWithLinkedList.Push(5);

Console.WriteLine(stackWithLinkedList.Pop());
Console.WriteLine(stackWithLinkedList.Pop());
Console.WriteLine(stackWithLinkedList.Pop());
Console.WriteLine(stackWithLinkedList.Pop());
Console.WriteLine(stackWithLinkedList.Pop());
Console.WriteLine(stackWithLinkedList.Pop());