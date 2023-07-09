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
            linkedList.Insert(40);

            linkedList.display();
            Console.WriteLine("After deleting");

            linkedList.delete(10);
            linkedList.delete(30);
            linkedList.delete(60);
            linkedList.display();


        }
    }
}