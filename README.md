# Trybe Games

## Descrição
Este repositório contém a implementação do projeto Trybe Games, onde foram desenvolvidos métodos para manipulação de coleções em um software de jogos, consultas LINQ para operações específicas e uma aplicação de testes.

### Requisitos

1. **Requisito 1 - Adicionar Nova Pessoa Jogadora:**
   - Método `AddPlayer()` implementado em `src/TrybeGames/TrybeGamesController.cs`.
   - Recebe as entradas da pessoa usuária pelo Console para criar uma nova instância de Player e adicioná-la ao banco de dados existente na classe TrybeGamesDatabase.

2. **Requisito 2 - Adicionar Novo Estúdio de Jogos:**
   - Método `AddGameStudio()` implementado em `src/TrybeGames/TrybeGamesController.cs`.
   - Recebe as entradas da pessoa usuária pelo Console para criar uma nova instância de GameStudio e adicioná-la ao banco de dados existente na classe TrybeGamesDatabase.

3. **Requisito 3 - Adicionar Novo Jogo ao Banco de Dados:**
   - Método `AddGame()` implementado em `src/TrybeGames/TrybeGamesController.cs`.
   - Recebe as entradas da pessoa usuária pelo Console para criar uma nova instância de Game e adicioná-la ao banco de dados existente na classe TrybeGamesDatabase.

4. **Requisito 4 - Buscar Jogos Desenvolvidos por um Estúdio de Jogos:**
   - Método `GetGamesDevelopedBy()` implementado em `src/TrybeGames/Database/TrybeGamesDatabase.cs`.
   - Retorna a lista de jogos desenvolvidos por um estúdio de jogos especificado.

5. **Requisito 5 - Buscar Jogos Jogados por uma Pessoa Jogadora:**
   - Método `GetGamesPlayedBy()` implementado em `src/TrybeGames/Database/TrybeGamesDatabase.cs`.
   - Retorna a lista de jogos jogados por uma pessoa jogadora especificada.

6. **Requisito 6 - Buscar Jogos Comprados por uma Pessoa Jogadora:**
   - Método `GetGamesOwnedBy()` implementado em `src/TrybeGames/Database/TrybeGamesDatabase.cs`.
   - Retorna a lista de jogos comprados por uma pessoa jogadora especificada.

7. **Requisito 7 - Buscar Todos os Jogos com o Nome do Estúdio Desenvolvedor:**
   - Método `GetGamesWithStudio()` implementado em `src/TrybeGames/Database/TrybeGamesDatabase.cs`.
   - Retorna a lista de jogos com informações sobre o estúdio desenvolvedor conforme o DTO GameWithStudio.

8. **Requisito 8 - Buscar Todos os Diferentes Tipos de Jogos Cadastrados:**
   - Método `GetGameTypes()` implementado em `src/TrybeGames/Database/TrybeGamesDatabase.cs`.
   - Retorna a lista de tipos de jogos cadastrados.

9. **Requisito 9 - Buscar Todos os Estúdios de Jogos com Seus Jogos Desenvolvidos e Pessoas Jogadoras:**
   - Método `GetStudiosWithGamesAndPlayers()` implementado em `src/TrybeGames/Database/TrybeGamesDatabase.cs`.
   - Retorna a lista de estúdios de jogos com informações sobre seus jogos e pessoas jogadoras conforme os DTOs StudioGamesPlayers e GamePlayer.

### Habilidades Técnicas

- **Linguagens:**
  - C#
  
- **Tecnologias:**
  - LINQ
  - .NET

- **Ferramentas:**
  - Visual Studio Code
  - Git
