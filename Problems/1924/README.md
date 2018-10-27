# Problem 1924

## 2007년

### 문제

오늘은 2007년 1월 1일 월요일이다. 그렇다면 2007년 x월 y일은 무슨 요일일까? 이를 알아내는 프로그램을 작성하시오.

### 입력

첫째 줄에 빈 칸을 사이에 두고 x(1≤x≤12)와 y(1≤y≤31)이 주어진다. 참고로 2007년에는 1, 3, 5, 7, 8, 10, 12월은 31일까지, 4, 6, 9, 11월은 30일까지, 2월은 28일까지 있다.

### 출력

첫째 줄에 x월 y일이 무슨 요일인지에 따라 SUN, MON, TUE, WED, THU, FRI, SAT중 하나를 출력한다.

### 예제 입력 1

1 1

### 예제 출력 1

MON

### 예제 입력 2

3 14

### 예제 출력 2

WED

### 예제 입력 3

9 2

### 예제 출력 3

SUN

### 예제 입력 4

12 25

### 예제 출력 4

TUE

## 문제 링크

[https://www.acmicpc.net/problem/1924](https://www.acmicpc.net/problem/1924)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\1924\Program
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
cd BaekjoonOnlineJudge\Problems\1924\Program.test
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

- 프로그래밍 언어의 Date 관련 라이브러리를 사용할 것인지 아니면 직접 계산할 것인지에 따라서 코드의 색깔 자체가 달라진다.
- 어쨌든 나는 주니어급 프로그래머는 아니므로 System의 DateTime 구조체를 사용해서 day of week를 아주 쉽게 구하는 코드를 짰다.