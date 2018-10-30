# Problem 9498

## 시험 성적

### 문제

시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.

### 입력

첫째 줄에 시험 점수가 주어진다. 시험 점수는 0보다 크거나 같고, 100보다 작거나 같은 자연수이다.

### 출력

시험 성적을 출력한다.

### 예제 입력 1

100

### 예제 출력 1

A

## 문제 링크

[https://www.acmicpc.net/problem/9498](https://www.acmicpc.net/problem/9498)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\9498\Program
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
cd BaekjoonOnlineJudge\Problems\9498\Program.test
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

- Programmer's common sense.
- 그냥 if else 문으로 짜면 쉬운데 conditional operator인 ?: 를 사용해서 풀어보기로 한다.
- 사실 if, else if, else로 짜는게 제일 보기도 편하고 쉽다.