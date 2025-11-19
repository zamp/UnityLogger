# UnityLogger

Simple Logger for Unity.

## How to install: 
* Grab the DLL from releases and drop it into your unity project. Recommended path `Assets/Plugins/UnityLogger`
* If you use asmdef files, make sure the dll is referenced properly (autoreference should work fine)

```cs

namespace MyNamespace
{
	using Log = UnityLogWrapper.Logger<MyClass>;

	public class MyClass
	{
	  	public void SomeMethod()
	  	{
			Log.Info("Some info.");
			Log.Verbose("Some verbose thing");
			Log.Error("Some error occured");
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
