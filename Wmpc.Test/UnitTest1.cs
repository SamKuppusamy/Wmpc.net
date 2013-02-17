using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wmpc.Mpd;

namespace Wmpc.Test {
    [TestClass]
    public class UnitTest1 {

        private Client client;

        [TestInitialize]
        public void Initialize(){
            this.client = new Client("192.168.1.3", 6600);
        } 

        [TestMethod]
        public void TestClient() {
            Response response = client.SendCommand("status time");
            Assert.IsTrue(response.OK);
            Assert.IsNotNull(response.ResponseString);
        }

        [TestMethod]
        public void TestStatusClearError() {
            Response response = this.client.StatusProvider.QueryClearError();
            Assert.IsTrue(response.OK);
        }

        [TestMethod]
        public void TestStatusCurrentSong() {
            Track track = this.client.StatusProvider.QueryCurrentSong();
            Assert.IsNotNull(track);
        }

        [TestMethod]
        public void TestStatusElapsed() {
            Response response = this.client.StatusProvider.QueryElapsed();
            Assert.IsTrue(response.OK);
        }


    }
}
