A process can signal the OS that it can pause the current thread for a while, in order to do other work.

You can do so using

- Thread.Sleep(0)

    This will yield execution to any other thread on any CPU

- Thread.Sleep(1)

    This will suspend the Thread for at least 15ms (even though you only want to suspend it 1ms) 
    and yield execution to any thread on any CPU

- Thread.Yield()

    This will yield execution to any thread on the SAME CPU.

Interesting SO Questions:
- http://stackoverflow.com/questions/1413630/switchtothread-thread-yield-vs-thread-sleep0-vs-thead-sleep1
- http://stackoverflow.com/questions/19066900/thread-sleep1-takes-longer-than-1ms


