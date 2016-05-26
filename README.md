# ClickMeUp
An easy robot in C# to detect edits in a web page.
I tested ClickMeUp with Windows 7, Windows 8.1 and Windows 10.

## What is ClickMeUp
In May 2016, in occasion of a "Click Day" (an italian informatic day) I had the necessity to detect some important updates in a web page. So I created this tool that detected them for me.
ClickMeUp is a very simple program: it crawl the source code of the page and memorize it the first time it visits the page. Then, it crawl the page again and again (the delay of the timer can be set by the user) and compares the memorized version of the page with the new one.
If it detects differences between the two versions a new tab in the web browser will be opened.

## How to use ClickMeUp
Insert an URL to crawl, then click to "Start". You can set other options, too. Now, wait ;)

### Tips
I noticed that Google homepage changes it's source code continually, so if you want to test if the program works, you can crawl the URL:
https://www.google.com/
