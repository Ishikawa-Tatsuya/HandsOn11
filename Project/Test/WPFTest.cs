using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.NativeStandardControls;
using RM.Friendly.WPFStandardControls;
using System.Diagnostics;
using System.Windows;
using WpfTarget;
using Codeer.Friendly.Windows.Grasp;

namespace Test
{
    [TestClass]
    public class WPFTest
    {
        WindowsAppFriend _app;
        dynamic _main;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start("WpfTarget.exe"));
            _main = _app.Type<Application>().Current.MainWindow;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).CloseMainWindow();
        }
    }
}
