﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using LegendRank.Models;

namespace LegendRank
{
    public static class Config
    {
        //Api Key
        public const string ApiKey = "RGAPI-f0ea5578-3543-4f89-abf1-8542db660a92";


        //Ranking data endpoints
        public const string NaRankingApiUrl = "https://na1.api.riotgames.com/lol/league-exp/v4/entries";

        //Summoner data endpoints of all regions
        public const string LatinAmericaNorthMatchesApiUrl = "https://la1.api.riotgames.com/lol/match/v4";
        public const string LatinAmericaNorthLeagueApiUrl = "https://la1.api.riotgames.com/lol/league/v4/entries";
        public const string LatinAmericaNorthSummonerApiUrl = "https://la1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string LatinAmericaSouthSummonerApiUrl = "https://la2.api.riotgames.com/lol/summoner/v4/summoners";
        public const string NorthAmericaSummonerApiUrl = "https://na1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string EuropaWestummonerApiUrl = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string EuropaNodicSummonerApiUrl = "https://eun1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string BrazilSummonerApiUrl = "https://br1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string JapanSummonerApiUrl = "https://jp1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string KoreaSummonerApiUrl = "https://kr1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string OceaniaSummonerApiUrl = "https://oc1.api.riotgames.com/lol/summoner/v4/summoners";
        public const string RussiaSummonerApiUrl = "https://ru.api.riotgames.com/lol/summoner/v4/summoners";
        public const string TurkeySummonerApiUrl = "https://tr1.api.riotgames.com/lol/summoner/v4/summoners";


        //Images Api 
        public const string ProfileIconUrl = "https://ddragon.leagueoflegends.com/cdn/11.7.1/img/profileicon/";
        public const string ChampionIconUrl = "https://ddragon.leagueoflegends.com/cdn/11.7.1/img/champion/";
        public const string ItemIconUrl = "https://ddragon.leagueoflegends.com/cdn/11.7.1/img/item/";
        public const string SummonerSpellsIconUrl = "https://ddragon.leagueoflegends.com/cdn/11.7.1/img/spell/";
        public const string RuneIconUrl = "https://ddragon.canisback.com/img/";


        //Match Api Endpoint
        public const string LanMatchApiUrl = "https://la1.api.riotgames.com/lol/match/v4";


        //Champion Api
        public const string ChampionsApiUrl = "http://ddragon.leagueoflegends.com/cdn/11.7.1/data/en_US/champion.json";

        //Rune Api
        public const string RuneApiUrl = "http://ddragon.leagueoflegends.com/cdn/11.7.1/data/en_US/runesReforged.json";


    }
}
