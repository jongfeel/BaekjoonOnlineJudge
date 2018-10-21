# Problem 7287

## 등록

### 문제

자신이 온라인 저지에서 맞은 문제의 개수와 아이디를 그대로 출력하는 프로그램을 작성하시오.

### 입력

이 문제는 입력이 없다.

### 출력

첫 줄에 자신이 맞은 문제의 수, 둘째 줄에 아이디를 출력한다.

### 예제 입력 1 

### 예제 출력 1 

123
Your_ICPC_Team_Name

## 문제 링크

[https://www.acmicpc.net/problem/7287](https://www.acmicpc.net/problem/7287)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\7287\Program
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

## Solve1

- 그냥 현재 맞춘 문제수를 백준 알고리즘 사이트의 내 정보로 들어가서 맞춘 개수를 입력하면 된다.