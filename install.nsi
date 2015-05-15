SetCompressor lzma
Outfile "DuckDLInstall.exe"

InstallDir $PROGRAMFILES\Electroduck\DuckDL
RequestExecutionLevel admin

Section
SetOutPath $INSTDIR
File "Electroduck Controls.dll"
File DuckDL\bin\Release\DuckDL.exe
File DuckDL\youtube-dl.exe
File LICENSE.txt
WriteUninstaller $INSTDIR\Uninstall.exe
CreateDirectory $SMPROGRAMS\Electroduck\DuckDL
CreateShortCut "$SMPROGRAMS\Electroduck\DuckDL.lnk" "$INSTDIR\DuckDL.exe"
CreateShortCut "$SMPROGRAMS\Electroduck\Uninstall DuckDL.lnk" "$INSTDIR\Uninstall.exe"
SectionEnd

Section "Uninstall"
RMDir /r $INSTDIR
Delete "$SMPROGRAMS\Electroduck\DuckDL.lnk"
Delete "$SMPROGRAMS\Electroduck\Uninstall DuckDL.lnk"
SectionEnd