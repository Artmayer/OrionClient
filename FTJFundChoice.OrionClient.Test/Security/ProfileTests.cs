﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Test.Security {

    [TestClass]
    public class ProfileTests : BaseTest {

        [TestMethod]
        public async Task GetAll() {
            var result = await Client.Security.Profiles.GetAll();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
        }

        [TestMethod]
        public async Task Search() {
            var result = await Client.Security.Profiles.Search("testrep@");

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
        }
    }
}