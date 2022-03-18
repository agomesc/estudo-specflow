using System;
using TechTalk.SpecFlow;

namespace GameCore.Spec.StepDefinitions
{
    [Binding]
    public class PlayerCharacterStepDefinitions
    {

        private PlayerCharacter player;
        
        [Given(@"sou um novo jogador")]
        public void GivenImANewPlayer()
        {
            player = new PlayerCharacter();
        }

        [When(@"tomou 0 de dano")]
        public void Tomou0DeDano()
        {
            player.Hit(0);
        }

        [When(@"tomou 40 de dano")]
        public void Tomou40deDano()
        {
            player.Hit(40);
        }

        [Then(@"Minha saúde agora deve ser 100")]
        public void MinhaSaudeAagoraDeveSer100()
        {
            Assert.Equal(100, player.Health);
        }

        [Then(@"Minha saúde agora deve ser 60")]
        public void MinhasaudeAgoraDeveSer60()
        {
            Assert.Equal(60, player.Health);
        }


        [When(@"tomou 100 de dano")]
        public void Tomou100Dedano()
        {
            player.Hit(100);
        }
        [Then(@"eu deveria estar morto")]
        public void EuDeveriaEstarMorto()
        {
            Assert.True(player.IsDead);
        }
    }
}
