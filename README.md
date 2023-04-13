# Maker-X Demo

## Prompts

1. implement a REST API in C# with a /match endpoint that takes a player as a string parameter and returns a GameMatch with the 2 matched players. The method should try to find an open match for the player. If there is no open match, it should create a new match with the specified player, but if there is an open match it should assign the player to that open match.
2. use .net 6.0 and minimal APIs instead of a Controller
3. Add an Id to GameMatch and add a MatchState with value: WaitingForOpponent, MatchFound and GameReady
4. Please also change the /match api code
5. If the player is already in a match, return that match
6. Move the matching logic into another class and use DI to inject into the endpoint.
7. Make MatchService use a interface
