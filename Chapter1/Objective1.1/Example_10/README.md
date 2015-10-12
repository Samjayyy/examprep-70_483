ThreadPool Threads are useful because you get some kind of optimal resource management.

However, they do not allow you to be signaled when they are ready, nor can you get the result value.

Introducing Task.

A ``Task`` is a representation of an ``Action`` and  a ``Task<T>`` is a representation of a ``Func<T>``. 

A task
- contains meta data about execution state
- result (if applicable)
- can contain child tasks
- can contain continuations



