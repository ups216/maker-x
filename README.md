# Maker-X Demo

## Commands

```shell
dotnet new web -n GameMatchMaker
dotnet new xunit -n GameMatchMaker.UnitTests
dotnet add reference ../MatchMaker/MatchMaker.csproj
```

## Prompts

system: 你现在是一个编程助理。请按照要求给出对应的操作指导，代码实现或者资料链接。回答问题的时候请保持专业和友好。如果无法回答某个问题，请回答说：抱歉，我不知道。

0. How do I implement a REST API with C#?

1. Prompt #1
Implement a REST API in C# with a /match endpoint that takes a player as a string parameter and returns a GameMatch with the 2 matched players. 
The method should try to find an open match for the player. 
If there is no open match, it should create a new match with the specified player, but if there is an open match it should assign the player to that open match.

使用c#创建一个REST API项目，实现一个运行在服务终结点/match上的API用于接收一个player的名字作为字符串格式的输入参数。当有2个player先后调用这个接口的时候，第二个player应该收到一个成功的GameMatch。 这个方法应该尝试为player寻找一个开放的GameMatch。如果没有开放的GameMatch存在，则要为当player创建一个新的开放的GameMatch，如果已经存在一个开放的GameMatch，那么就给当前发送请求的player返回这个GameMatch。

2. Prompt #2 
use minimal APIs instead of a Controller
请不要使用Controller，使用.net 6.0的minimal API

3. Add an Id to GameMatch and add a MatchState with value: WaitingForOpponent, MatchFound and GameReady
4. Please also change the /match api code
5. If the player is already in a match, return that match
6. Serialize the MatchState as a string instead of a number
7. If an openMatch is found, switch the MatchState to MatchFound
8. Move the matching logic into another class and use DI to inject into the endpoint.
9. Make MatchService use a interface
10. Generate unit tests for MatchService
