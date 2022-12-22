using System.Diagnostics;
using SpeedTesterConsoleApp;

var timer = new Stopwatch();
var app = new TesterApplication(timer);
app.Configure();
app.Start();


