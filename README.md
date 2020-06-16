# NetChecker

A fast and lightweight tool for monitoring Internet connectivity.

---

## What is it?

NetChecker is a .NET 4.5 program that runs silently in the background and checks for Internet connectivity at customizable interval. The status of your Internet connection can be seen by the application's tray icon.

## How does it work?

When a check is performed, it makes a GET request to one of many Google domains that return an HTTP 204 response. If there are any errors in this response then it can be assumed that the Internet is down. Although it is entirely possible for one of these to go down, it is also very unlikely considering this is Google we are talking about here.

Because 204 responses return no content, this tool uses very little bandwidth even at the most frequent check interval.

## Why?

Because Windows doesn't really do a good job in letting you know if your Internet is down. You can be connected to a network and if that network isn't getting Internet then Windows won't show that there are any problems. This tool gets straight to the point and lets you know if you can access the Internet or not.