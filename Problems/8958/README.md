# Problem 8958

## OX 퀴즈

### 문제

"OOXXOXXOOO"와 같은 OX퀴즈의 결과가 있다. O는 문제를 맞은 것이고, X는 문제를 틀린 것이다. 문제를 맞은 경우 그 문제의 점수는 그 문제까지 연속된 O의 개수가 된다. 예를 들어, 10번 문제의 점수는 3이 된다.

"OOXXOXXOOO"의 점수는 1+2+0+0+1+0+0+1+2+3 = 10점이다.

OX퀴즈의 결과가 주어졌을 때, 점수를 구하는 프로그램을 작성하시오.

### 입력

첫째 줄에 테스트 케이스의 개수가 주어진다. 각 테스트 케이스는 한 줄로 이루어져 있고, 길이가 0보다 크고 80보다 작은 문자열이 주어진다. 문자열은 O와 X만으로 이루어져 있다.

### 출력

각 테스트 케이스마다 점수를 출력한다.

### 예제 입력 1

5\
OOXXOXXOOO\
OOXXOOXXOO\
OXOXOXOXOXOXOX\
OOOOOOOOOO\
OOOOXOOOOXOOOOX

### 예제 출력 1

10\
9\
7\
55\
30

## 문제 링크

[https://www.acmicpc.net/problem/8958](https://www.acmicpc.net/problem/8958)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\8958\Program
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
cd BaekjoonOnlineJudge\Problems\8958\Program.test
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

- XO로 이루어진 string 값을 X로 split 한다. 그러면 X가 연속된 string의 경우는 공백이 나오고 아닌 경우는 O만 이루어진 string 값을 얻을 수 있게 된다.
- O로만 이루어진 string array는 1 부터 n 까지의 숫자의 합의 결과로 볼 수 있기 때문에 n(n+1)/2의 공식을 써서 구한다.
- 이렇게 구한 결과값을 모두 합하면 점수 값이 된다.