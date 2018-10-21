# Problem 2741

## N 찍기

### 문제

자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.

### 입력

첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.

### 출력

첫째 줄부터 N번째 줄 까지 차례대로 출력한다.

### 예제 입력 1 

5

### 예제 출력 1 

1
2
3
4
5

## 문제 링크

[https://www.acmicpc.net/problem/2741](https://www.acmicpc.net/problem/2741)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\2741\Program
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

- 일단 그냥 풀기에는 쉬워 보이나
- 입력 조건의 자연수 N의 범위가 100000 이나 된다.
- 이걸 그냥 Console.WriteLine으로 찍으면 string이 최대 100000개가 찍히기에, 메모리 제한이나 시간 제한에 걸려 테스트에 통과할 수가 없다.
- 그래서 StringBuilder를 통해 메모리를 확보한 후 for 문을 돌려 저장 후 한꺼번에 출력하는 방법으로 진행한다.
- 단순한 문제지만 string 메모리가 재할당이 되지 않고 새로 생성된다는 문제를 알면 풀 수 있다.

## 다른 언어에서는?

- C나 C++언어는 특별히 메모리 제한을 생각할 필요가 없다. c#과 다르게 문자열 개념의 string이 없고 char[]의 개념이기 때문이다.