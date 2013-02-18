using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public abstract class ResponseEntity {

        protected Response response;

        public Response Response {
            get { return this.response; }
        }

        public ResponseEntity(Response response) {
            this.response = response;
        }

    }
}
