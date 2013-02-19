using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Wmpc.Mpd {
    public class PlaybackProvider : Provider {

        public PlaybackProvider(Client client) : base(client) { }


        const string MPD_PLAYBACK_NEXT = "next";
        const string MPD_PLAYBACK_PAUSE = "pause";
        const string MPD_PLAYBACK_PLAY = "play";
        const string MPD_PLAYBACK_PLAYID = "playid";
        const string MPD_PLAYBACK_PREVIOUS = "previous";
        const string MPD_PLAYBACK_SEEK = "seek";
        const string MPD_PLAYBACK_SEEKID = "seekid";
        const string MPD_PLAYBACK_SEEKCUR = "seekcur";
        const string MPD_PLAYBACK_STOP = "stop";

        public Response QueryNext() {
            Command cmd = new Command(MPD_PLAYBACK_NEXT);
            return this.client.SendCommand(cmd);
        }

        public Response QueryPause(bool pause) {
            Command cmd = new Command(MPD_PLAYBACK_NEXT, pause);
            return this.client.SendCommand(cmd);
        }

        public Response QueryPlay(int syngpos) {
            Command cmd = new Command(MPD_PLAYBACK_PLAY, syngpos);
            return this.client.SendCommand(cmd);
        }

        public Response QueryPlayId(int songid) {
            Command cmd = new Command(MPD_PLAYBACK_PLAYID, songid);
            return this.client.SendCommand(cmd);
        }

        public Response QueryPrevious() {
            Command cmd = new Command(MPD_PLAYBACK_PREVIOUS);
            return this.client.SendCommand(cmd);
        }

        public Response QuerySeek(int songpos, int time) {
            Command cmd = new Command(MPD_PLAYBACK_SEEK, songpos, time);
            return this.client.SendCommand(cmd);
        }

        public Response QuerySeekId(int songid, int time) {
            Command cmd = new Command(MPD_PLAYBACK_SEEKID, songid, time);
            return this.client.SendCommand(cmd);
        }

        public Response QuerySeekcur(int time) {
            Command cmd = new Command(MPD_PLAYBACK_SEEKCUR, time);
            return this.client.SendCommand(cmd);
        }

        public Response QueryStop() {
            Command cmd = new Command(MPD_PLAYBACK_STOP);
            return this.client.SendCommand(cmd);
        }





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

        const string MPD_PLAYBACK_REPLAY_GAIN_STATUS_OFF = "off";
        const string MPD_PLAYBACK_REPLAY_GAIN_STATUS_TRACK = "track";
        const string MPD_PLAYBACK_REPLAY_GAIN_STATUS_ALBUM = "album";
        const string MPD_PLAYBACK_REPLAY_GAIN_STATUS_AUTO = "auto";

        public enum MpdReplayGainMode {
            [Description(MPD_PLAYBACK_REPLAY_GAIN_STATUS_OFF)]
            Off = 0,
            [Description(MPD_PLAYBACK_REPLAY_GAIN_STATUS_TRACK)]
            Track = 1,
            [Description(MPD_PLAYBACK_REPLAY_GAIN_STATUS_ALBUM)]
            Album = 2,
            [Description(MPD_PLAYBACK_REPLAY_GAIN_STATUS_AUTO)]
            Auto = 3
        }


        public Response QueryConsume(bool consume) {
            Command cmd = new Command(MPD_PLAYBACK_CONSUME, consume);
            return this.client.SendCommand(cmd);
        }

        public Response QueryCrossfade(bool crossfade) {
            Command cmd = new Command(MPD_PLAYBACK_CROSSFADE, crossfade);
            return this.client.SendCommand(cmd);
        }

        public Response QueryMixrampdb(int deciBells) {
            Command cmd = new Command(MPD_PLAYBACK_MIXRAMPDB, deciBells);
            return this.client.SendCommand(cmd);
        }

        public Response QueryMixrampdelay(int seconds) {
            Command cmd = new Command(MPD_PLAYBACK_MIXRAMPDELAY, seconds);
            return this.client.SendCommand(cmd);
        }

        public Response QueryRandom(bool random) {
            Command cmd = new Command(MPD_PLAYBACK_RANDOM, random);
            return this.client.SendCommand(cmd);
        }

        public Response QueryRepeat(bool repeat) {
            Command cmd = new Command(MPD_PLAYBACK_REPEAT, repeat);
            return this.client.SendCommand(cmd);
        }

        public Response QuerySetVol(int vol) {
            Command cmd = new Command(MPD_PLAYBACK_SETVOL, vol);
            return this.client.SendCommand(cmd);
        }

        public Response QuerySingle(bool single) {
            Command cmd = new Command(MPD_PLAYBACK_SINGLE, single);
            return this.client.SendCommand(cmd);
        }

        public Response QueryReplayGainMode(MpdReplayGainMode mode) {
            Command cmd = new Command(MPD_PLAYBACK_REPLAY_GAIN_MODE, Utils.GetEnumDescription(mode));
            return this.client.SendCommand(cmd);
        }

        public Response QueryReplayGainStatus() {
            Command cmd = new Command(MPD_PLAYBACK_REPLAY_GAIN_STATUS);
            Response response = this.client.SendCommand(cmd);
            return response;
        }


    }
}
