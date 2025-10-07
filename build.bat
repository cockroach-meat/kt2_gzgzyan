@echo off
cd /d "%~dp0"
if not exist bin mkdir bin
csc /nologo /out:bin\kt_dzhwa.exe src\*.cs