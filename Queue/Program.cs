// See https://aka.ms/new-console-template for more information
using Queue;

Console.WriteLine("Hello, World!");
QueueLinkedList linkedListQueue = new QueueLinkedList();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
//linkedListQueue.Dequeue();
//linkedListQueue.Dequeue();
linkedListQueue.Display();// this.top=this.top.next
linkedListQueue.Dequeue();

Console.ReadKey();
