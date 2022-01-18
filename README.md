# DemoPlaywrightASPNET48

Steps to reproduce:
1) Open the solution in Visual Studio.
2) Run the project (for example via F5).
3) You'll see an exception:
`Driver not found: C:\Windows\Microsoft.NET\Framework\v4.0.30319\Temporary ASP.NET Files\vs\14c7fcac\6704b262\assembly\dl3\.playwright\node\win32_x64\playwright.cmd
Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code.
Exception Details: Microsoft.Playwright.PlaywrightException: Driver not found: C:\Windows\Microsoft.NET\Framework\v4.0.30319\Temporary ASP.NET Files\vs\14c7fcac\6704b262\assembly\dl3\.playwright\node\win32_x64\playwright.cmd`

##### Source error:
`Line 13:         public async Task<ActionResult> Index()
Line 14:         {
Line 15:             using (var playwright = await Playwright.CreateAsync())
Line 16:             {
Line 17:                 var browser = await playwright.Webkit.LaunchAsync();`
