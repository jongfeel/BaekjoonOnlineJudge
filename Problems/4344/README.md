# Problem 4344

## 평균은 넘겠지

### 문제

대학생 새내기들의 90%는 자신이 반에서 평균은 넘는다고 생각한다. 당신은 그들에게 슬픈 진실을 알려줘야 한다.

### 입력

첫째 줄에는 테스트 케이스의 개수 C가 주어진다.

둘째 줄부터 각 테스트 케이스마다 학생의 수 N(1 ≤ N ≤ 1000, N은 정수)이 첫 수로 주어지고, 이어서 N명의 점수가 주어진다. 점수는 0보다 크거나 같고, 100보다 작거나 같은 정수이다.

### 출력

각 케이스마다 한 줄씩 평균을 넘는 학생들의 비율을 반올림하여 소수점 셋째 자리까지 출력한다.

### 예제 입력 1

5\
5 50 50 70 80 100\
7 100 95 90 80 70 60 50\
3 70 90 80\
3 70 90 81\
9 100 99 98 97 96 95 94 93 91

### 예제 출력 1

40.000%
57.143%
33.333%
66.667%
55.556%

## 문제 링크

[https://www.acmicpc.net/problem/4344](https://www.acmicpc.net/problem/4344)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\4344\Program
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
cd BaekjoonOnlineJudge\Problems\4344\Program.test
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

- 문제 조건대로 풀고 반올림의 경우는 Math.Round(), 소수점 세째자리는 string format "F3"를 이용한다.