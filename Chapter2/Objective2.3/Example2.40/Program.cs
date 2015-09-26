
using System;

namespace Example2._40
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                MovableObject obj = new MovableObject();

                // left
                ILeft objLeft = obj;
                objLeft.Move();

                // right
                IRight objRight = obj;
                objRight.Move();
            }

            Console.WriteLine("-------------");
            {
                // implementing both
                IMoving moving = new MovingObject();
                //moving.Move(); // does not compile, ambiguous call

                // left
                ILeft movingLeft = moving;
                movingLeft.Move();

                // right
                IRight movingRight = moving;
                movingRight.Move();
            }
            Console.ReadKey();
        }
    }

    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Move();
    }

    class MovableObject : ILeft, IRight
    {
        void ILeft.Move() {
            Console.WriteLine("Go left!");
        }

        void IRight.Move() {
            Console.WriteLine("Go right!");
        }
    }

    interface IMoving : ILeft, IRight
    {

    }
    class MovingObject : IMoving
    {
        public void Move()
        {
            Console.WriteLine("Go anywhere");
        }
        void ILeft.Move()
        {
            Console.WriteLine("Go left!");
        }

        //void IRight.Move()
        //{
        //    Console.WriteLine("Go right!");
        //}
    }
}
