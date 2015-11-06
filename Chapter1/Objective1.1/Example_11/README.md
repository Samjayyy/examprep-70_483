Tasks can have continuations and continuations can have constraint. 

The result of a continuation is a new task.

Tasks can fault: an exception was thrown
Tasks can be cancelled: use CancellationTokenSource to signal cancellation and pass cancellationTokenSource.Token to Task.



