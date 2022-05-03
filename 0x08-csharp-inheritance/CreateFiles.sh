#!/usr/bin/env bash
dotnet new console -n 0-is
cd 0-is
mv Program.cs 0-is.cs
dotnet build
touch 0-main.cs
