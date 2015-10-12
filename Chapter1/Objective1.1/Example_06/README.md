A Thread can be a background or a foreground thread.

A process ends when all foreground threads are finished. If there are still background threads alive,
they will be stopped (without throwing an abort/interrupted exception). 