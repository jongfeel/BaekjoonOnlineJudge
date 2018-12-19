# Problem 11726

## 2xn 타일링

### 문제

2×n 크기의 직사각형을 1×2, 2×1 타일로 채우는 방법의 수를 구하는 프로그램을 작성하시오.

아래 그림은 2×5 크기의 직사각형을 채운 한 가지 방법의 예이다.

![https://onlinejudgeimages.s3-ap-northeast-1.amazonaws.com/problem/11726/1.png](https://onlinejudgeimages.s3-ap-northeast-1.amazonaws.com/problem/11726/1.png)

### 입력

첫째 줄에 n이 주어진다. (1 ≤ n ≤ 1,000)

### 출력

첫째 줄에 2×n 크기의 직사각형을 채우는 방법의 수를 10,007로 나눈 나머지를 출력한다.

### 예제 입력 1

2

### 예제 출력 1

2

### 예제 입력 2

9

### 예제 출력 2

55

## 문제 링크

[https://www.acmicpc.net/problem/11726](https://www.acmicpc.net/problem/11726)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\11726\Program
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
cd BaekjoonOnlineJudge\Problems\11726\Program.test
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

- [Programmers에 동일한 문제](https://github.com/jongfeel/SongDoAlgorithmStudy/tree/master/Problems/12900)가 있어서 백준 알고리즘 문제에 그대로 적용해 봤다.
- C#은 상수가 아닌 이상 동적으로 array를 생성할 수 없으므로 문제 조건에 따라 최대치인 1000개의 array를 생성한다. 사실 1000이 맞지만 for문의 index가 n까지 이므로 실제 크기는 1001까지여야 한다.
- 그리고 다른 점 하나는 출력조건이 10007로 나눈 나머지 정도여서 이것만 수정하면 그대로 동작한다.