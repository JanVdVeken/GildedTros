using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using GildedTros.App;

namespace GildedTros.Test.Approval
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Console.SetIn(new StringReader("a\n"));
            
            GildedTros.App.Program.Main(new string[] { });
            var output = fakeOutput.ToString();

            Approvals.Verify(output);
        }
    }
}
