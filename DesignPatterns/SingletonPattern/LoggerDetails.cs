

namespace DesignPatterns.SingletonPattern
{
  public class LoggerDetails
  {
    public string Name = "LoggerDetails";

    private LoggerDetails() { }
    private static LoggerDetails instance = new LoggerDetails();
    private static readonly object padlock = new object();
    private static Lazy<LoggerDetails> loggerDetailsLazy = new Lazy<LoggerDetails>(() => new LoggerDetails());

    public static LoggerDetails Instance
    {
      get => instance;
    }

    public static LoggerDetails Lazy1Instance
    {
      get
      {
        if(instance==null)
        {
          instance = new LoggerDetails();
        }
        return instance;
      }
    }

    public static LoggerDetails ThreadSafeInstance
    {
      get
      {
      // Acquiring the Lock: When a thread reaches the lock statement, it tries to acquire a mutual-exclusion lock on the specified object(in this case, padlock).
      // If another thread already holds the lock, the current thread will wait(block) until the lock is released.

      // Executing the Code Block: Once the thread acquires the lock, it executes the code block within the lock statement.
      // During this time, no other thread can enter the locked code block.

      // Releasing the Lock: After the code block is executed, the lock is automatically released,
      // allowing other waiting threads to acquire the lock and execute the code block.
        lock (padlock)
        {
          if (instance == null)
          {
            instance = new LoggerDetails();
          }
          return instance;
        }
      }
    }

    // Lazy Initialization: The Lazy<LoggerDetails> instance ensures that the LoggerDetails object is created only when it is first accessed,
    // and it handles the creation in a thread-safe manner by default.

    // Thread-Safe by Default: The Lazy<T> class uses LazyThreadSafetyMode.ExecutionAndPublication by default,
    // which ensures that the object is created only once, even if multiple threads try to access it simultaneously.
    public static LoggerDetails LazyAutoLockInstance
    {
      get
      {
        return loggerDetailsLazy.Value;
      }
    }
  }
}
