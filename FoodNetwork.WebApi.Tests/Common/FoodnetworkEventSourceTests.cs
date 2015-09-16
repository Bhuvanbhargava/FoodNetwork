using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodNetwork.WebApi.Common;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Utility;

namespace FoodNetwork.WebApi.Tests.Common
{
    [TestClass]
    public class FoodnetworkEventSourceTests
    {
        [TestMethod]
        public void ShouldValidateEventSource()
        {
            EventSourceAnalyzer.InspectAll(FoodnetworkEventSource.Log);
        }
    }
}
