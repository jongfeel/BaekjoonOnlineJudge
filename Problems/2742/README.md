# Problem 2742

## 기찍 N

### 문제

자연수 N이 주어졌을 때, N부터 1까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.

### 입력

첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.

### 출력

첫째 줄부터 N번째 줄 까지 차례대로 출력한다.

### 예제 입력 1

5

### 예제 출력 1

5
4
3
2
1

## 문제 링크

[https://www.acmicpc.net/problem/2742](https://www.acmicpc.net/problem/2742)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\2742\Program
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

- 2741 번의 문제와 동일하며 for문을 역순으로 돌려서 출력만 하면 되는 문제