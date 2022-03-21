Feature: PlayerCharacter

Scenario Outline: Redução da Saúde
	Given sou um novo jogador
	When tomou <damage> de dano
	Then Minha saúde agora deve ser <expectedHealth>

Examples:
	| damage | expectedHealth |
	| 0      | 100            |
	| 40     | 60             |
	| 50     | 50             |
