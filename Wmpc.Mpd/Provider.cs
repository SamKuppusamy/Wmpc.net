using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public abstract class Provider {

        protected Client client;
        public Provider(Client client) {
            this.client = client;
        }

    }
}
