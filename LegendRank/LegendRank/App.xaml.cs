using Newtonsoft.Json;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LegendRank.Models;
using LegendRank.Services;
using LegendRank.ViewModels;
using LegendRank.Views;

namespace LegendRank
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer plataformInitializer = null) : base(plataformInitializer) { }

        protected override async void OnInitialized()
        {

            InitializeComponent();

            await NavigationService.NavigateAsync($"{NavigationConstant.NavigationPage}/{NavigationConstant.SummonerPage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.Register<ILolIconsApiService, LolIconsApiService>();
            containerRegistry.Register<ISummonerLeagueApiService, SummonerLeagueApiService>();
            containerRegistry.Register<ISummonerApiService, SummonerApiService>();
            containerRegistry.Register<IRankingApiService, RankingApiService>();
            containerRegistry.Register<ISerializerService, SerializerService>();
            containerRegistry.Register<IMatchApiService, MatchApiService>();
            containerRegistry.RegisterSingleton<IChampionService, ChampionService>();
            containerRegistry.RegisterSingleton<IRuneService, RuneService>();

            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstant.NavigationPage);
            containerRegistry.RegisterForNavigation<MainTabbedPage>(NavigationConstant.MainTabbedPage);
            containerRegistry.RegisterForNavigation<MatchTabbedPage, MatchViewModel>(NavigationConstant.MatchTabbedPage);
            containerRegistry.RegisterForNavigation<MatchAnalysisTabbedPage>(NavigationConstant.MatchAnalysisTabbedPage);

            containerRegistry.RegisterForNavigation<RankingPage, RankingViewModel>(NavigationConstant.RankingPage);
            containerRegistry.RegisterForNavigation<SummonerPage, SummonerViewModel>(NavigationConstant.SummonerPage);
            containerRegistry.RegisterForNavigation<SummonerDetailPage, SummonerDetailViewModel>(NavigationConstant.SummonerDetailPage);

            containerRegistry.RegisterForNavigation<MatchTotalPage>(NavigationConstant.MatchTotalPage);
            containerRegistry.RegisterForNavigation<MatchBuildPage>(NavigationConstant.MatchBuildPage);
            containerRegistry.RegisterForNavigation<MatchAnalysisChampionKillPage>(NavigationConstant.MatchAnalysisChampionKillsPage);
            containerRegistry.RegisterForNavigation<MatchAnalysisGoldPage>(NavigationConstant.MatchAnalysisGoldPage);
            containerRegistry.RegisterForNavigation<MatchAnalysisDamageDealtPage>(NavigationConstant.MatchAnalysisDamageDealtPage);
        }
    }
}
