using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;


namespace SourcePull
{
    public partial class SourcePull : ServiceBase
    {
        private Timer _timer = new Timer();
        public SourcePull()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("AutomatedSources"))
            {
                System.Diagnostics.EventLog.CreateEventSource("AutomatedSources", "AutomatedSourceLog");
            }
            eventLog1.Source = "AutomatedSources";
            eventLog1.Log = "AutomatedSourceLog";
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Put elapsed timer logic here. This will fire every time the timer is up.
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In onstart");

            _timer.AutoReset = true;
            _timer.Interval = 15000; //Will fire every 15 seconds.
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Start();
        }

        protected override void OnStop()
        {
            //Put stopped logic here.
        }
    }
}
