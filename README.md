# UnityLogger

Simple Logger for Unity.

## How to install: 
* Grab the DLL from releases and drop it into your unity project. Recommended path `Assets/Plugins/UnityLogger`
* If you use asmdef files, make sure the dll is referenced properly (autoreference should work fine)

```cs

using UnityLogger;

namespace MyNamespace
{
	using Log = Logger<MyClass>;

	public class MyClass
	{
	  	public void SomeMethod()
	  	{
	  	    Logger.LogLevel = Exception;
			Log.Info("Info message.");
			Log.Debug("Debug message.");
			Log.Error("Error occurred");~~~~
			try
			{
				int crash = 1 / 0;
			}
			catch (Exception e)
			{    
				Log.Exception(e);
			}
		}
	}
}
