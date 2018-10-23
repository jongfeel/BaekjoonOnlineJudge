# Problem 10430

## 나머지

### 문제

(A+B)%C는 (A%C + B%C)%C 와 같을까?

(A×B)%C는 (A%C × B%C)%C 와 같을까?

세 수 A, B, C가 주어졌을 때, 위의 네가지 값을 구하는 프로그램을 작성하시오.

### 입력

첫째 줄에 A, B, C가 순서대로 주어진다. (2 ≤ A, B, C ≤ 10000)

### 출력

첫째 줄에 (A+B)%C, 둘째 줄에 (A%C + B%C)%C, 셋째 줄에 (A×B)%C, 넷째 줄에 (A%C × B%C)%C를 출력한다.

### 예제 입력 1

5 8 4

### 예제 출력 1

1
1
0
0

## 문제 링크

[https://www.acmicpc.net/problem/10430](https://www.acmicpc.net/problem/10430)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\10430\Program
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
cd BaekjoonOnlineJudge\Problems\10430\Program.test
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

- 우리가 알고 있는 4칙 연산의 분배 법칙이 mod 연산에도 적용 되는지 해 보는 프로그램이다.
- 사실 그냥 돌려보면 답이 나오는 거라 문제를 푸는 것 보다 왜 mod 연산의 분배 법칙이 저렇게 되는지 이해를 하는게 중요하다.
- mod는 modulo의 약자로 나눗셈의 나머지를 의미하며 modulo operation의 equivalent distributive (분배 법칙) 쪽을 보면 식이 나와 있으니 참고하면 된다.
- [https://en.wikipedia.org/wiki/Modulo_operation](https://en.wikipedia.org/wiki/Modulo_operation)