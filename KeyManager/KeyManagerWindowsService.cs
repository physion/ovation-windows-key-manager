﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace KeyManager
{
    public partial class KeyManagerWindowsService : ServiceBase
    {
        private readonly KeyRepositoryApp _app;

        public KeyManagerWindowsService()
        {
            InitializeComponent();
            _app = new KeyRepositoryApp();
        }

        protected override void OnStart(string[] args)
        {
            _app.Start();
        }

        protected override void OnStop()
        {
            _app.Stop();
        }
    }
}