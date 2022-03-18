Feature: PlayerCharacter

Scenario: Não sofrer dano quando atingido não afeta a saúde
	Given sou um novo jogador
	When tomou 0 de dano
	Then Minha saúde agora deve ser 100

Scenario: Saúde inicial é reduzida ao ser atingida
	Given sou um novo jogador
	When tomou 40 de dano
	Then Minha saúde agora deve ser 60

Scenario: sofrer muitos danos resulta na morte do jogador 
	Given sou um novo jogador
	When tomou 100 de dano
	Then eu deveria estar morto

