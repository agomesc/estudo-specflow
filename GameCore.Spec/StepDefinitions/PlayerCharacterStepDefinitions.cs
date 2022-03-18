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
            this.player = new PlayerCharacter();
        }

        [When(@"tomou (.*) de dano")]
        public void TomouDeDano(int damage)
        {
            this.player.Hit(damage);
        }

        [Then(@"Minha saúde agora deve ser 100")]
        public void MinhaSaudeAagoraDeveSer100()
        {
            Assert.Equal(100, this.player.Health);
        }

        [Then(@"Minha saúde agora deve ser 60")]
        public void MinhasaudeAgoraDeveSer60()
        {
            Assert.Equal(60, this.player.Health);
        }

        [Then(@"eu deveria estar morto")]
        public void EuDeveriaEstarMorto()
        {
            Assert.True(this.player.IsDead);
        }
    }
}
