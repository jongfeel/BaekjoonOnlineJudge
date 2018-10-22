# Problem 11719

## 그대로 출력하기2

### 문제

입력 받은 대로 출력하는 프로그램을 작성하시오.

### 입력

입력이 주어진다. 입력은 최대 100줄로 이루어져 있고, 알파벳 소문자, 대문자, 공백, 숫자로만 이루어져 있다. 각 줄은 100글자를 넘지 않으며, 빈 줄이 주어질 수도 있고, 각 줄의 앞 뒤에 공백이 있을 수도 있다.

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

[https://www.acmicpc.net/problem/11719](https://www.acmicpc.net/problem/11719)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\11719\Program
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

- [11718](https://www.acmicpc.net/problem/11718) 문제와 동일한거 아닌가? 하고 소스를 그대로 넣어 보니 동작함
- 이유는 Console.ReadLine() 메소드 자체가 공백까지 입력이 가능한 형태이기 때문
- 만약 C로 짰으면 처음부터 이 문제가 먹히도록 짰을 때 역으로 11718번 문제를 그대로 쓸 수 있을 듯.