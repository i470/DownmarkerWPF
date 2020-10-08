using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MarkPad.Events;
using MarkPad.Infrastructure;
using MarkPad.Preview;

namespace MarkPad
{
    public partial class App : ISingleInstanceApp
    {
       

        private readonly AppBootstrapper bootstrapper;

        public App()
        {
            InitializeComponent();

            HtmlPreview.Init();

            bootstrapper = new AppBootstrapper();
        }

        public void HandleArguments(string[] args)
        {
            if (args.Length == 2)
            {
                var filePath = args[1];
                bootstrapper.GetEventAggregator().Publish(new FileOpenEvent(filePath));
            }
        }


        public bool SignalExternalCommandLineArgs(IList<string> args)
        {
            // handle command line arguments of second instance
            HandleArguments(args.ToArray());

            return true;
        }
    }
}
