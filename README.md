DebateSidebarWordAddIn
======================

Debate Sidebar Word AddIn is software for high school and college policy & LD debate teams, integrated into Microsoft Office Word as a COM AddIn and requiring .NET Framework 4.0 and Visual Studio Tools for Office. Available at http://debatesynergy.com and used by hundreds of students every month.

The problem solved is that debaters had to print evidence and carry it in large tubs with airplane baggage fees, prior to paperless dabete format. Wired featured this app in an article they wrote about paperless debate modernization: http://www.wired.com/2012/01/ff_debateteam/
The solution is a fullstack website in Nodejs and also a Windows desktop add-in for MS Office in C#. The reason for this was that Nodejs gave realtime socket.io for typing syncronization and AWS for file hosting for permanent availability. C# VSTO was a great solution inside MS Word which was already used by debaters to format their evidence; with this sidebar they can stay in their application and organize things better and there is also an option to upload a speech to the website for live-steaming.

Other code to see: https://github.com/gulakov/debatesynergy.com-nodejs
