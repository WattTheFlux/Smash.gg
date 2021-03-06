﻿using Smash.gg;
using Xunit;

namespace Smash.ggTests
{
    public class DeserialiseLinks
    {
        private readonly AsyncDataHelper _data;
        public DeserialiseLinks()
        {
            _data = new AsyncDataHelper();
        }

        [Theory]
        [InlineData("https://api.smash.gg/phase_group/499362?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/499360?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/515049?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/515605?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/515606?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/533045?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/499364?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/499361?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/499363?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/499719?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/203126?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/203348?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/208372?expand[]=sets&expand[]=entrants")]
        [InlineData("https://api.smash.gg/phase_group/506683?expand[]=sets&expand[]=entrants")]
        public void PhaseGroups(string url)
        {
            _data.Deserialize<PhaseGroup>(url);

        }

        [Theory]
        [InlineData("https://api.smash.gg/event/80373?expand[]=groups&expand[]=phase")]
        [InlineData("https://api.smash.gg/event/89083?expand[]=groups&expand[]=phase")]
        [InlineData("https://api.smash.gg/event/82871?expand[]=groups&expand[]=phase")]
        public void EventGroup(string url)
        {
            _data.Deserialize<EventGroup>(url);
        }

        [Theory]
        [InlineData("https://api.smash.gg/tournament/koopas-keep-dojo?expand[]=event&expand[]=phase&expand[]=groups&expand[]=stations")]
        [InlineData("https://api.smash.gg/tournament/koopas-keep-17?expand[]=event&expand[]=phase&expand[]=groups&expand[]=stations")]
        [InlineData("https://api.smash.gg/tournament/fair-game-1-2-icebreaker?expand[]=event&expand[]=phase&expand[]=groups&expand[]=stations")]
        [InlineData("https://api.smash.gg/tournament/smashfactory?expand[]=event&expand[]=phase&expand[]=groups&expand[]=stations")]
        public void TournamentGroup(string url)
        {
            _data.Deserialize<TournamentGroup>(url);
        }
    }
}
