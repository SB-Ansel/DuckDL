### DuckDL - YouTube-DL frontend
- Electroduck, SB-Ansel

**Updated as of 6/10/2020**

----
### Improvements/Changes made since qc_fix (Jun 11,2015): 
- Fixed issue with YT URL handling, where the user was unable to use the YT shortend URL. 
- Fixed issue when pressing the cancel button during a download would causes an unhandled exception.
- Unified fonts between windows (Segoe Ui will be used going forward).
- Removed MPC-HC in favour of using system associated media players instead.
- Implemented a dependency check for Microsoft Redistributable 2010.
- Implemented automatic updating of the YouTube-DL dependency. **//This requires some work!**
- Improved format selection dialog so that command line arguments can be used allowing for greater user control.
----
### Future plans:
-  Implement a proper YouTube-Dl update screen. Probably include a progress bar (or text) on the splash screen to indicate the progress of the update, as at present, this update is running in the background when the main window loads. Though, updating the dependency in the splash does increase the amount of time the user has to wait until the program loads. 
- Change the way DuckDl creates filename names, example (**Haendel - Sarabande.18.klPZIGQcrHA.mp4**), also store date created in the creation of file, this will allow for filtering in the file explorer.
- Consider scrapping sites for m3u8 file and then use FFMPEG to download videos (Twitter) //YouTube-Dl can do this, consider using this instead of adding another dependency.
----
### Current work inprogress: 
- Work is currently being made with making: Twitter, Reddit, Facebook and Instagram, downloadable via DuckDl. In past builds of DuckDl, the downloader would only download from sources which had a numeric format code in their --list-formats when processed by yt-dl, not all sources use youtubes format codes which are always numeric in nature. Facebooks format codes are a combination of numeric and char values, so we're rewrite and converting some sections to work with the format codes.

- Implementing a preferences (configuration) menu to store user customisable values such as; update frequency and download speed (to avoid ISP throttling).

- Rewriting the redownload feature to take into account the new sources (Twitter, Reddit, Facebook and Instagram) as well as implementing an error check feature before initating a file download.

- Changing the downloaded filenames to be more meaningful.
