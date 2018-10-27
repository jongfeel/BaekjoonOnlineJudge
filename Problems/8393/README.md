# Problem 8393

## 합

### 문제

n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.

### 입력

첫째 줄에 n (1 ≤ n ≤ 10,000)이 주어진다.

### 출력

1부터 n까지 합을 출력한다.

### 예제 입력 1

3

### 예제 출력 1

6

## 문제 링크

[https://www.acmicpc.net/problem/8393](https://www.acmicpc.net/problem/8393)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\8393\Program
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
cd BaekjoonOnlineJudge\Problems\8393\Program.test
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

## Solve - Math

- 수학적인 방법을 사용한다.
- 합을 구하는 유명한 공식을 이용해서 풀면 for문을 안쓰고도 풀 수 있다.
- 이 공식은 아래 사이트에서 참고할 수 있다.
- [https://brilliant.org/wiki/sum-of-n-n2-or-n3/](https://brilliant.org/wiki/sum-of-n-n2-or-n3/)

## Solve2 - C# library

- 또 C#의 Linq를 사용해서 Sum 메소드를 호출하면 sum을 바로 구할 수도 있다. 해당 코드는 주석 처리함.