using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads
{
    class Program
    {
        static void mythread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 1 shows " + i);
            }
        }

        static void mythread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 2 shows " + i);
            }
        }


        static void Main(string[] args)
        {
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);

            thread1.Start();
            thread2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 3 shows " + i);
            }

            Console.ReadLine();
        }

    }
}

/*
using System;
using System.Threading;

// Simple threading scenario:  Start a static method running
// on a second thread.
public class ThreadExample
{
    // The ThreadProc method is called when the thread starts.
    // It loops ten times, writing to the console and yielding 
    // the rest of its time slice each time, and then ends.
    public static void ThreadProc()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("ThreadProc: {0}", i);
            // Yield the rest of the time slice.
            Thread.Sleep(0);
        }
    }

    public static void Main()
    {
        Console.WriteLine("Main thread: Start a second thread.");
        // The constructor for the Thread class requires a ThreadStart 
        // delegate that represents the method to be executed on the 
        // thread.  C# simplifies the creation of this delegate.
        Thread t = new Thread(new ThreadStart(ThreadProc));

        // Start ThreadProc.  Note that on a uniprocessor, the new 
        // thread does not get any processor time until the main thread 
        // is preempted or yields.  Uncomment the Thread.Sleep that 
        // follows t.Start() to see the difference.
        t.Start();
        //Thread.Sleep(0);

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Main thread: Do some work.");
            Thread.Sleep(0);
        }

        Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
        t.Join();
        Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
        Console.ReadLine();
    }
}

*/

/*

using System;
using System.Threading;

public class Work
{
    public static void Main()
    {
        // Start a thread that calls a parameterized static method.
        Thread newThread = new Thread(Work.DoWork);
        newThread.Start(42);

        // Start a thread that calls a parameterized instance method.
        Work w = new Work();
        newThread = new Thread(w.DoMoreWork);
        newThread.Start("The answer.");
    }

    public static void DoWork(object data)
    {
        Console.WriteLine("Static thread procedure. Data='{0}'",
            data);
    }

    public void DoMoreWork(object data)
    {
        Console.WriteLine("Instance thread procedure. Data='{0}'",
            data);

        Console.ReadKey();
    }
}
// This example displays output like the following:
//       Static thread procedure. Data='42'
//       Instance thread procedure. Data='The answer.'

    */
