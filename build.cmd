@echo off

@:Build
@set msbuild="%ProgramFiles(x86)%\msbuild\14.0\Bin\MSBuild.exe"
@if not exist %MSBuild% @set msbuild="%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe"

set out=%~dp0bin\
echo Out %out%
%MSBuild% /m /nr:false /p:Platform="Any CPU" /v:M Sshfs.sln

@REM %MSBuild% /m /nr:false /p:Platform="Any CPU" /v:M Sshfs\Sshfs\Sshfs.csproj

@PAUSE