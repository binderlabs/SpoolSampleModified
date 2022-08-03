# SpoolSampleModified
Modified Spool Sample for SEImpersonate Privilege Escalation. 

* Download the repo, open in Visual Studio 2017 and compile the binary.
* Original SpoolSample (https://github.com/leechristensen/SpoolSample) need to run in multiple cmd sessions. Tweaked a little bit to run in a single session (i.e in a simple reverse shell). 
* Please note that this tool works ony if user has SEImpersonate Privilege. 
* I believe this tool will useful a lot in your pentest as well as in OSEP lab may be even in OSEP exam :). 

# Usage

`SpoolSampleModified.exe <computername> <pipename> <cmd>`

eg.

`SpoolSampleModified.exe desktop-pouorrr desktop-pouorrr/pipe/test "C:\Windows\System32\cmd.exe /c whoami > C:\Users\Public\test.txt"`
