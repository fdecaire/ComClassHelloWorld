using System;
using System.Runtime.InteropServices;

// possible locations of sn and regasm tools:
// sn tool:      "C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools\sn" -k key.snk
// regasm tool:  "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\regasm" /codebase ComClassExample2.dll
// regasm tool:  "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\regasm" /u ComClassExample2.dll
namespace ComClassHelloWorld
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("6216B529-3E4A-4FE8-8F7A-BE99C33DB1F1")]
    public interface ILauncher
    {
		string Hello();
    }

	[ClassInterface(ClassInterfaceType.None), Guid("41027763-2E19-415A-8525-F48F604EE810")] //, ProgId("Launcher.Launcher")
    public class Launcher : ILauncher
    {
        public string Hello()
        {
            return "Hello world";
        }
    }
}