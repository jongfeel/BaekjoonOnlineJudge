# Problem 10869

## 사칙연산

### 문제

두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 

### 입력

두 자연수 A와 B가 주어진다. (1 ≤ A, B ≤ 10,000)

### 출력

첫째 줄에 A+B, 둘째 줄에 A-B, 셋째 줄에 A*B, 넷째 줄에 A/B, 다섯째 줄에 A%B를 출력한다.

### 예제 입력 1

7 3

### 예제 출력 1

10
4
21
2
1

## 문제 링크

[https://www.acmicpc.net/problem/10869](https://www.acmicpc.net/problem/10869)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\10869\Program
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
cd BaekjoonOnlineJudge\Problems\10869\Program.test
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

- 조건이 자연수 이므로 사칙연산은 기존에 풀었던 [1000](https://www.acmicpc.net/problem/1000), [1001](https://www.acmicpc.net/problem/1001), [10998](https://www.acmicpc.net/problem/10998), [1008](https://www.acmicpc.net/problem/1008) 을 참고해서 진행하고 Modulo인 %는 직접 구현한다.
- 백준 사이트에서 문제 제출한 것과 다르게 이미 구현된 메소드가 존재하므로 각 프로젝트를 추가한 후 using을 사용해서 메소드 호출 후 진행한다.
