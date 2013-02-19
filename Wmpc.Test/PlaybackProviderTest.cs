using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wmpc.Mpd;

namespace Wmpc.Test {
    [TestClass]
    public class PlaybackProviderTest {

        private Client client;

        [TestInitialize]
        public void Initialize(){
            this.client = new Client("192.168.1.3", 6600);
        } 

        [TestMethod]
        public void TestReplayGainStatus() {
            Response response = this.client.PlaybackProvider.QueryReplayGainStatus();
            Assert.IsNotNull(response);
        }


    }
}
