using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class PlaybackProvider : Provider {

        public PlaybackProvider(Client client) : base(client) { }

        const string MPD_PLAYBACK_CONSUME = "consume";
        const string MPD_PLAYBACK_CROSSFADE = "crossfade";
        const string MPD_PLAYBACK_MIXRAMPDB = "mixrampdb";
        const string MPD_PLAYBACK_MIXRAMPDELAY = "mixrampdelay";
        const string MPD_PLAYBACK_RANDOM = "random";
        const string MPD_PLAYBACK_REPEAT = "repeat";
        const string MPD_PLAYBACK_SETVOL = "setvol";
        const string MPD_PLAYBACK_SINGLE = "single";
        const string MPD_PLAYBACK_REPLAY_GAIN_MODE = "replay_gain_mode";
        const string MPD_PLAYBACK_REPLAY_GAIN_STATUS = "replay_gain_status";
        
        /*
         consume {STATE}
        [2] Sets consume state to STATE, STATE should be 0 or 1. When consume is activated, each song played is removed from playlist. 
        crossfade {SECONDS}
         Sets crossfading between songs. 
        mixrampdb {deciBels}
         Sets the threshold at which songs will be overlapped. Like crossfading but doesn't fade the track volume, just overlaps. The songs need to have MixRamp tags added by an external tool. 0dB is the normalized maximum volume so use negative values, I prefer -17dB. In the absence of mixramp tags crossfading will be used. See http://sourceforge.net/projects/mixramp 
        mixrampdelay {SECONDS}
         Additional time subtracted from the overlap calculated by mixrampdb. A value of "nan" disables MixRamp overlapping and falls back to crossfading. 
        random {STATE}
         Sets random state to STATE, STATE should be 0 or 1. 
        repeat {STATE}
         Sets repeat state to STATE, STATE should be 0 or 1. 
        setvol {VOL}
         Sets volume to VOL, the range of volume is 0-100. 
        single {STATE}
        [2] Sets single state to STATE, STATE should be 0 or 1. When single is activated, playback is stopped after current song, or song is repeated if the 'repeat' mode is enabled. 
        replay_gain_mode {MODE}
         Sets the replay gain mode. One of off, track, album, auto[4]. 
         Changing the mode during playback may take several seconds, because the new settings does not affect the buffered data. 
         This command triggers the options idle event. 
        replay_gain_status 
         Prints replay gain options. Currently, only the variable replay_gain_mode is returned.
            */

        public Response QueryConsume(bool consume) {
            Command cmd = new Command(MPD_PLAYBACK_CONSUME, consume);
            return this.client.SendCommand(cmd);
        }

        public Response QueryCrossfade(bool crossfade) {
            Command cmd = new Command(MPD_PLAYBACK_CROSSFADE, crossfade);
            return this.client.SendCommand(cmd);
        }

        public Response QueryCrossfade(bool crossfade) {
            Command cmd = new Command(MPD_PLAYBACK_CROSSFADE, crossfade);
            return this.client.SendCommand(cmd);
        }

    }
}
