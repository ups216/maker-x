# Maker-X Demo

## Prompts

1. implement a REST API in C# with a /match endpoint that takes a player as a string parameter and returns a GameMatch with the 2 matched players. The method should try to find an open match for the player. If there is no open match, it should create a new match with the specified player, but if there is an open match it should assign the player to that open match.
使用c#创建一个REST API项目，实现一个运行在 /match 上的API用于接收一个 player 的名称作为字符串格式的输入参数，并且当有2个 player 调用这个接口的时候返回一个 GameMatch 。 这个方法应该尝试为 player 寻找一个 OpenMatch。如果没有 Open Match 存在，则要为当前 Player 创建一个新的 match，如果已经存在一个 open match，那么就将新的 player 指定给这个open match。
2. use .net 6.0 and minimal APIs instead of a Controller
3. Add an Id to GameMatch and add a MatchState with value: WaitingForOpponent, MatchFound and GameReady
4. Please also change the /match api code
5. If the player is already in a match, return that match
6. Move the matching logic into another class and use DI to inject into the endpoint.
7. Make MatchService use a interface
