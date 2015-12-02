To install the Out-of-Process Host from NuGet
Open or create a Visual Studio project or solution on the computer where you will run the Out-of-Process Host.
Open the NuGet Package Manager and search online for semantic logging service.
Select the Semantic Logging Application Block - Out-of-process Service and choose Install.
Review and then accept the license terms by selecting I Agree. After the installation is complete, close the package manager dialog.
Open a command prompt as an administrator and navigate to the subfolder \packages\EnterpriseLibrary.SemanticLogging.Service.version\tools\ in your solution folders.
Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
Set-ExecutionPolicy Undefined -scope LocalMachine
Run the install-packages.ps1 PowerShell script to install the dependencies for the Out-of-Process host.
At the command prompt, type SemanticLogging-svc.exe -install to install the service using the Local Service account. If you want to use a different account, use the -account command line switch instead (see the table below for details of all of the command line switches). Alternatively, type SemanticLogging-svc.exe -start to install and start the service.
If you did not start the service when you installed it, open the Services console in Control Panel and select the service Enterprise Library Semantic Logging Out-of-Process Service. On the context menu, click Start to start the service.


Running the Out-of-Process Windows Service/Console Host
By default, the Out-of-Process Host application uses a configuration file named SemanticLogging-svc.xml located in the same folder as the application. You can use a different configuration file by editing the app.config file and changing the value of the EtwConfigurationFileName key. For more information, see Using the trace event service for the out-of-process scenario.
You must ensure that the Out-of-Process Host application is running to collect events. By default, it is installed with its startup type set to Manual. You can start it manually or configure it to start automatically with the operating system by setting the service properties in the Services console in Control Panel.
