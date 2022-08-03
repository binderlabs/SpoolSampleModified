# SpoolSampleModified
Modified Spool Sample for SEImpersonate Privilege Escalation. 

* Download this repo, open in Visual Studio 2017 and compile the binary.
* Original SpoolSample (https://github.com/leechristensen/SpoolSample) need multiple sessions. Tweaked a little bit to run in a single command prompt and  to bypass windows defender.
* Please note that this tool works ony if user has SEImpersonate Privilege. 
* I believe this tool will useful a lot in your pentest as well as in OSEP lab may be even in OSEP exam :). 

# Usage

`SpoolSampleModified.exe <computername> <pipename> <cmd>`

eg.

`SpoolSampleModified.exe desktop-pouorrr desktop-pouorrr/pipe/test "C:\Windows\System32\cmd.exe /c whoami > C:\Users\Public\test.txt"`
![This is an image](/images/img2.png)


![This is an image](/images/img1.png)
