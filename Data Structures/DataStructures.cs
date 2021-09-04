using System;
using Data_Structures.Linked_List;
namespace Data_Structures
{
    public class DataStructures
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            list.IndexOf(2);
        }
    }
}
