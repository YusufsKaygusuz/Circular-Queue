using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue
{
    class Program
    {
        class CircularQueue
        {
            int[] Data;
            int Rear;
            int Front;

            public CircularQueue(int size)
            {
                Data = new int[size];
                Rear = 2;
                Front = 2;
            }
            #region Helper Methods
            public bool isEmpty()
            {
                return (Rear == Front);
            }

            public bool isFull()
            {
                return (Front == Data.Length);
            }

            public int Capacity()
            {
                return Data.Length;
            }
            #endregion

            public void Enqueu(int i)
            {

                if(Rear == Data.Length && Front != 0)
                {
                    Rear = 0;
                }

                //else if(Rear == Data.Length)
                //Console.WriteLine("Kuyruk Dolu!!!");

                Data[Rear] = i;
                Rear++;
            }

            public int Dequeue()
            {
                /*
                if(Rear == Front)
                    Console.WriteLine("Sıra Boş");
                */

                if (Front == Data.Length)
                {
                    Front = 0;
                }

                int i = Data[Front];
                Front++;
                return i;
            }

        }


        static void Main(string[] args)
        {
            CircularQueue CQ = new CircularQueue(5);

            CQ.Enqueu(45);
            CQ.Enqueu(21);
            CQ.Enqueu(39);
            CQ.Enqueu(15);

            int First = CQ.Dequeue();
            Console.WriteLine(First);

            int Second = CQ.Dequeue();
            Console.WriteLine(Second);

            int Third = CQ.Dequeue();
            Console.WriteLine(Third);

            int Fourth = CQ.Dequeue();
            Console.WriteLine(Fourth);


            Console.ReadLine();
        }
    }
}
