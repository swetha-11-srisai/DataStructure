using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-createlinked list,2-AddInReverseOrder,3-Insertatparticularposition,4-RemovefirstNode,5-RemovelastNode,6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                        case 2:
                        list.AddInReverseOrder(56);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(70);
                        list.Display();
                        break;
                    case 3:
                        list.Add(56);
                        list.Add(70);
                        list.InsertAtParticularPosition(1,30);
                        list.Display();
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveFirstNode();
                        list.Display();
                        break;
                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveLastNode();
                        list.Display();
                        break;

                    case 6:
                        flag = false;
                        break;

                }
            }
        }
    }
}
