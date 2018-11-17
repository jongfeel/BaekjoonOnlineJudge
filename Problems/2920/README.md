# Problem 2920

## 음계

### 문제

다장조는 c d e f g a b C, 총 8개 음으로 이루어져있다. 이 문제에서 8개 음은 다음과 같이 숫자로 바꾸어 표현한다. c는 1로, d는 2로, ..., C를 8로 바꾼다.

1부터 8까지 차례대로 연주한다면 ascending, 8부터 1까지 차례대로 연주한다면 descending, 둘 다 아니라면 mixed 이다.

연주한 순서가 주어졌을 때, 이것이 ascending인지, descending인지, 아니면 mixed인지 판별하는 프로그램을 작성하시오.

### 입력

첫째 줄에 8개 숫자가 주어진다. 이 숫자는 문제 설명에서 설명한 음이며, 1부터 8까지 숫자가 한 번씩 등장한다.

### 출력

첫째 줄에 ascending, descending, mixed 중 하나를 출력한다.

### 예제 입력 1

1 2 3 4 5 6 7 8

### 예제 출력 1

ascending

### 예제 입력 2

8 7 6 5 4 3 2 1

### 예제 출력 2

descending

### 예제 입력 3

8 1 7 2 6 3 5 4

### 예제 출력 3

mixed

## 문제 링크

[https://www.acmicpc.net/problem/2920](https://www.acmicpc.net/problem/2920)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\2920\Program
dotnet build
```

```bash
dotnet run
```

## Run program - Visaul Studio Code

- Open folder "Program" by Visual Studio Code
- Check out settings - launch.json
  - For debug console, set below to launch.json (already set launch.json)
  > "console": "integratedTerminal"
- Select configuration ".NET Core Launch (console)" and press F5 to debug start

## MSTest - bash

```bash
cd BaekjoonOnlineJudge\Problems\2920\Program.test
dotnet build
```

```bash
dotnet test
```

## Run Test project - Visaul Studio Code

- Open folder "Program.test" by Visual Studio Code
- Check out settings - launch.json
  - For debug console, set below to launch.json (already set launch.json)
  > "console": "integratedTerminal"
- Select configuration "dotnet build" and press F5 to start debug build
- Select configuration "dotnet test" and press F5 to start debug test

## Solve

- 사실 "12345678", "87654321", 그외로 if문을 걸면 그냥 되는데 사실 그렇게 하면 재미가 없으므로
- array의 앞 인덱스와 현재 인덱스의 값의 차이가 모두 1인지 -1인지를 판단해서 accending, decending을 출력해 주는 걸로 해본다.
- 이걸 하려면 C# linq의 Zip과 Skip을 사용해야 한다.