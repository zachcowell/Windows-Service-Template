Windows-Service-Template
========================

Example of how to create a simple windows service that utilizes System.Timers

This is a common template that I've seen in a lot of places. This seems to me to be the simplest implementation. The web service will fire every time the timer has elapsed. I found it easiest to write a separate class/module for the actions that I need to perform, build it, and add it as a reference to the service project, and fire off the applicable methods.

Alternatively, a simpler option would be to build a small console app and use Task Scheduler to fire it off Daily/Monthly/etc. The reason I didn't go this route was because our Task Scheduler is on the fritz and rather than spending a few hours debugging the problem I wrote this in ~10min.
