# Problem 11718

## 그대로 출력하기

### 문제

입력 받은 대로 출력하는 프로그램을 작성하시오.

### 입력

입력이 주어진다. 입력은 최대 100줄로 이루어져 있고, 알파벳 소문자, 대문자, 공백, 숫자로만 이루어져 있다. 각 줄은 100글자를 넘지 않으며, 빈 줄은 주어지지 않는다. 또, 각 줄은 공백으로 시작하지 않고, 공백으로 끝나지 않는다.

### 출력

입력받은 그대로 출력한다.

### 예제 입력 1

Hello
Baekjoon
Online Judge

### 예제 출력 1

Hello
Baekjoon
Online Judge

## 문제 링크

[https://www.acmicpc.net/problem/11718](https://www.acmicpc.net/problem/11718)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\11718\Program
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

- 처음에 문제를 이해 못해서 Console.ReadLine을 그대로 Console.WriteLine으로 출력하도록 코드를 한 줄로 짰더니
- 틀렸습니다!
- 그래서 while문 안에 넣어서 Console.ReadLine을 Console.WriteLine으로 출력하도록 무한 루프를 돌렸더니
- 출력초과!
- 그래서 Console.ReadLine 입력이 없을 때 까지의 조건으로 무한루프를 돌렸더니 그제서야 됨
- 문제가 쉬워 보여도 조건대로 짜기가 까다롭다.