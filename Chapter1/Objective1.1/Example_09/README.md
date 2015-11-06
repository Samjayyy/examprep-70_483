Creating and starting Threads is expensive. Therefore, it is a good practice to reuse threads and 
pool them together. The ThreadPool is the default implementation for this pattern.

ThreadPool Threads:
- are Background Threads
- have Normal Priority
- are recycled, hence state is also recycled!

You cannot wait for the thread, it is put on a queue and executed when a ThreadPool Thread is available.

