namespace Datastructure_linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);

            linkedList.display();
        }
    }
}