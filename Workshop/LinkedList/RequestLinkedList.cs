namespace Workshop.LinkedList;

public class RequestLinkedList
{
    public static void Run()
    {
        var linkedList = new LinkedList();

        linkedList.AddToFront(1);
        linkedList.AddToFront(2);
        linkedList.AddToFront(3);
        linkedList.AddToFront(4);
        linkedList.AddToFront(5);
        linkedList.AddToFront(6);

        linkedList.ListLoop();
    }
}