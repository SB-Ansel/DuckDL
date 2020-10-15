
## DuckDL - GUI Video Downloader frontend for your favourite sites

Electroduck, SB-Ansel 🦆

**Updated as of 15/10/2020** 🎃

----

### Future plans / work in progress

- Implement a proper YouTube-Dl update screen. Probably include a progress bar (or text) on the splash screen to indicate the progress of the update, as at present, this update is running in the background when the main window loads. Though, updating the dependency in the splash does increase the amount of time the user has to wait until the program loads.

- Add UPJS to DuckDL to enable in place upgrading of DuckDL for future updates.

- Implement a configuration menu for configuration persistent options such as: download speed (to avoid ISP throttling) and update frequency checks for UPJS (thanks gilnicki <3) and YouTube-dl.

- Use system native icons for video list.

----

### Improvements/Changes made since 1.4.1 (Sep 24, 2020)

- Filenames were changed to reflect the download site of origin. e.g. past versions (Haendel - Sarabande.18.klPZIGQcrHA.mp4) - versions going forward (youtube.Haendel - Sarabande.18.klPZIGQcrHA.mp4)

- DuckDL can now download from: Twitter, Reddit, Instagram, YouTube and Facebook.

- UI changes. Main Window is no a fixed size. XP styles were enabled (for some reason this looks better on windows 10...).

- Added a ton of additional backend rewrites and logic to get and additional sites (reddit was the worst offender) downloads (redownloads) to work properly. (too much to state here :p)

- Added a 'Open in browser' feature. Allows users to select a video and open the original URL in their system default browser.

----

### Improvements/Changes made since qc_fix (Jun 11, 2015)

- Fixed issue with YT URL handling, where the user was unable to use the YT shortened URL.

- Fixed issue when pressing the cancel button during a download would causes an unhandled exception.

- Unified fonts between windows (Segoe-UI will be used going forward).

- Removed MPC-HC in favour of using system associated media players instead.

- Implemented a dependency check for Microsoft Redistributable 2010.

- Implemented automatic updating of the YouTube-DL dependency. **//This requires some work!**

- Improved format selection dialog so that command line arguments can be used allowing for greater user control.