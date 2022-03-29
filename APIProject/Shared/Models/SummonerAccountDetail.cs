﻿namespace APIProject.Shared.Models
{
    public class SummonerAccountDetail
    {
        public string LeagueId { get; set; }
        public string SummonerId { get; set; }
        public string SummonerName { get; set; }
        public string QueueType { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int LeaguePoints { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public bool HotsTreak { get; set; }
        public bool Veteran { get; set; }
        public bool Inactive { get; set; }
        public MiniSeries MiniSeries { get; set; }
    }
}
