﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class Status : ResponseEntity {

        const string MPD_STATUS_VOLUME = "volume";
        const string MPD_STATUS_REPEAT = "repeat";
        const string MPD_STATUS_SINGLE = "single";
        const string MPD_STATUS_CONSUME = "consume";
        const string MPD_STATUS_PLAYLIST = "playlist";
        const string MPD_STATUS_PLAYLISTLENGTH = "playlistlength";
        const string MPD_STATUS_STATE = "state";
        const string MPD_STATUS_SONG = "song";
        const string MPD_STATUS_SONGID = "songid";
        const string MPD_STATUS_NEXTSONG = "nextsong";
        const string MPD_STATUS_NEXTSONGID = "nextsongid";
        const string MPD_STATUS_TIME = "time";
        const string MPD_STATUS_ELAPSED = "elapsed";
        const string MPD_STATUS_BITRATE = "bitrate";
        const string MPD_STATUS_XFADE = "xfade";
        const string MPD_STATUS_MIXRAMPDB = "mixrampdb";
        const string MPD_STATUS_MIXRAMPDELAY = "mixrampdelay";
        const string MPD_STATUS_AUDIO = "audio";
        const string MPD_STATUS_UPDATING_DB = "updating_db";
        const string MPD_STATUS_ERROR = "error";

        const string MPD_STATE_PLAY = "play";
        const string MPD_STATE_STOP = "stop";
        const string MPD_STATE_PAUSE = "pause";

        public enum MpdState {
            Play = 1,
            Stop = 2,
            Pause = 3
        }

        public int Volume { get; set; }
        public bool Repeat { get; set; }
        public bool Random { get; set; }
        public bool Single { get; set; }
        public bool Consume { get; set; }
        public int Playlist { get; set; }
        public int PlaylistLength { get; set; }
        public int Song { get; set; }
        public int SongId { get; set; }
        public int NextSong { get; set; }
        public int NextSongId { get; set; }
        public int Time { get; set; }
        public int Elapsed { get; set; }
        public int Bitrate { get; set; }
        public int Xfade { get; set; }
        public int Mixrampdb { get; set; }
        public int MixrampDelay { get; set; }
        public string Audio { get; set; }
        public int UpdatingDb { get; set; }
        public string Error { get; set; }
        public MpdState State { get; set; }

        public Status(Response response)
            : base(response) {
            foreach (KeyValuePair<string, string> pair in response.Values) {
                switch (pair.Key.ToLower()) {
                    case MPD_STATUS_AUDIO:
                        this.Audio = pair.Value;
                        break;
                    case MPD_STATUS_BITRATE:
                        this.Bitrate = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_CONSUME:
                        this.Consume = Utils.ParseBool(pair.Value);
                        break;
                    case MPD_STATUS_ELAPSED:
                        this.Elapsed = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_ERROR:
                        this.Error = pair.Value;
                        break;
                    case MPD_STATUS_MIXRAMPDB:
                        this.Mixrampdb = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_MIXRAMPDELAY:
                        this.MixrampDelay = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_NEXTSONG:
                        this.NextSong = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_NEXTSONGID:
                        this.NextSongId = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_PLAYLIST:
                        this.Playlist = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_PLAYLISTLENGTH:
                        this.PlaylistLength = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_REPEAT:
                        this.Repeat = Utils.ParseBool(pair.Value);
                        break;
                    case MPD_STATUS_SINGLE:
                        this.Single = Utils.ParseBool(pair.Value);
                        break;
                    case MPD_STATUS_SONG:
                        this.Song = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_SONGID:
                        this.SongId = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_TIME:
                        this.Time = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_UPDATING_DB:
                        this.UpdatingDb = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_VOLUME:
                        this.Volume = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_XFADE:
                        this.Xfade = int.Parse(pair.Value);
                        break;
                    case MPD_STATUS_STATE:
                        switch (pair.Value) {
                            case MPD_STATE_PLAY: this.State = MpdState.Play; break;
                            case MPD_STATE_STOP: this.State = MpdState.Stop; break;
                            case MPD_STATE_PAUSE: this.State = MpdState.Pause; break;
                        }
                        break;
                }
            }
        }
    }

}

