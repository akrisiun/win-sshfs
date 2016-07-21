where sn.exe
set sn=sn.exe
@REM "c:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\x64\sn.exe" -p sshfs\WinSSH4e1-public.snk WinSSH4e1.pub
@REM "c:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\x64\sn.exe" -tp WinSSH4e1.pub

%sn% -p sshfs\WinSSH4e1-public.snk WinSSH4e1.pub
%sn% -tp WinSSH4e1.pub

pause
@REM del WinSSH4e1.pub