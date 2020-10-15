Set WshShell = CreateObject("WScript.Shell")
WshShell.Run chr(34) & "checkPlan.bat" & Chr(34), 0
Set WshShell = Nothing