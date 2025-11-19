using UnityLogger;

namespace ExampleNamespace
{
    using Log = Logger<Example>;

    public class Example
    {
        public void SomeMethod()
        {
            // Set log level. Anything at or below this level will be logged.
            Logger.LogLevel = LogLevel.Exception;
            
            // Log your messages.
            Log.Debug("Debug message.");
            Log.Info("Info message.");
            Log.Warn("Warn message.");
            Log.Error("Error message.");
            try
            {
                int zero = 0;
                int crash = 1 / zero;
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }
    }
}