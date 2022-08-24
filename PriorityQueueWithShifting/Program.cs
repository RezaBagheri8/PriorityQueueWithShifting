using PriorityQueueWithShifting;

var queue = new PriorityQueue(10);

queue.Dequeue();
queue.Enqueue(2, 10000);
queue.Enqueue(5, 100);
queue.Enqueue(6, 1);
queue.Print();





queue.Enqueue(90, 2);

queue.Dequeue();

Console.WriteLine("--------------------------------------");

queue.Print();



