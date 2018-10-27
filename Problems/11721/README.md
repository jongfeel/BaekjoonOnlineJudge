# Problem 11721

## 열 개씩 끊어 출력하기

### 문제

알파벳 소문자와 대문자로만 이루어진 길이가 N인 단어가 주어진다.

한 줄에 10글자씩 끊어서 출력하는 프로그램을 작성하시오.

### 입력

첫째 줄에 단어가 주어진다. 단어는 알파벳 소문자와 대문자로만 이루어져 있으며, 길이는 100을 넘지 않는다. 길이가 0인 단어는 주어지지 않는다.

### 출력

입력으로 주어진 단어를 열 개씩 끊어서 한 줄에 하나씩 출력한다. 단어의 길이가 10의 배수가 아닌 경우에는 마지막 줄에는 10개 미만의 글자만 출력할 수도 있다.

### 예제 입력 1

BaekjoonOnlineJudge

### 예제 출력 1

BaekjoonOn
lineJudge

### 예제 입력 2

OneTwoThreeFourFiveSixSevenEightNineTen

### 예제 출력 2

OneTwoThre
eFourFiveS
ixSevenEig
htNineTen

## 문제 링크

[https://www.acmicpc.net/problem/11721](https://www.acmicpc.net/problem/11721)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\11721\Program
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

## Solve

- string length가 10번째가 되는 시점마다 new line ("\n") 글자를 넣어준다.
- "\n"을 넣어줄 때 마다 길이가 1씩 늘어나므로 그 다음 라인 부터는 1씩 늘어난 index에서 넣어준다.