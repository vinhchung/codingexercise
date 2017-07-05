How to compile and run
======================

Windows 10 or 7

Prerequisite: download and install .net core sdk https://www.microsoft.com/net/core#windowscmd

1. Extract CodingExercise.zip to C:\temp
2. Open command prompt in admin mode and change to path of extracted folder C:\temp\CodingExercise-TabCorp\CodingExercise.
3. type command: dotnet restore
4a. For Windows 10 type command: dotnet publish -c release -r win10-x64
4b. For Windows 7 type command: dotnet publish -c release -r win7-x64
5. the compiled files should be in the \bin\release\netcoreapp1.1\win10-x64\. Change path to this folder
6. copy the BetInputs.txt to this same folder. 
7. To run app type command: CodingExercise.exe < BetInputs.txt

OSX 10

Prerequisite: download and install .net core sdk https://www.microsoft.com/net/core#macos. Please follow instructions on this page. 

1. Extract CodingExercise.zip
2. Open terminal and go to extracted folder.
3. type command: dotnet restore
4. type command: dotnet publish -c release -r osx.10.12-x64
5. the compiled files should be in the \bin\release\netcoreapp1.1\osx.10.12-x64\. Change path to this folder
6. copy the BetInputs.txt to this same folder. 
7. To run app type command: dotnet CodingExercise.dll < BetInputs.txt
