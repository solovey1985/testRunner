@echo on
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe MusicHttpClient.sln /p:Configuration=Release /p:Platform="Any CPU"
pause