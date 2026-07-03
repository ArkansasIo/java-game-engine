@echo off
title Arklight.Utility.exe
set ENGINE_DIR=..

set argC=0
for %%x in (%*) do set /A argC+=1

if %argC% == 0 goto choosemod

if %argC% == 1 (
    set mod=%1
    goto help
)

if %argC% GEQ 2 (
    @REM This option is for use by other scripts so we don't want any extra output here - before or after.
    call bin\Arklight.Utility.exe %*
    EXIT /B 0
)

:choosemod
echo ----------------------------------------
echo.
call bin\Arklight.Utility.exe
echo Enter --exit to exit
set /P mod="Please enter a modname: Arklight.Utility.exe "
if /I "%mod%" EQU "--exit" (exit /b)
if /I "%mod%" EQU "ra" (goto help)
if /I "%mod%" EQU "cnc" (goto help)
if /I "%mod%" EQU "ts" (goto help)
if /I "%mod%" EQU "d2k" (goto help)
echo.
echo Unknown mod: %mod%
echo.
goto choosemod
:help
echo.
echo ----------------------------------------
echo.
echo Starting Arklight.Utility.exe %mod%
call bin\Arklight.Utility.exe %mod%
:start
echo.
echo ----------------------------------------
echo.
echo Script options:
echo   --exit to exit
echo   --help to view the help
echo   --mod to choose a new mod
echo.
set /P command="Please enter a command: Arklight.Utility.exe %mod% "
if /I "%command%" EQU "--exit" (exit /b)
if /I "%command%" EQU "--help" (goto help)
if /I "%command%" EQU "--mod" (goto choosemod)
echo.
echo ----------------------------------------
echo.
echo Starting Arklight.Utility.exe %mod% %command%
call bin\Arklight.Utility.exe %mod% %command%
goto start

