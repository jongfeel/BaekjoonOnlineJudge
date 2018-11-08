# Problem 1065

## 한수

### 문제

어떤 양의 정수 X의 자리수가 등차수열을 이룬다면, 그 수를 한수라고 한다. 등차수열은 연속된 두 개의 수의 차이가 일정한 수열을 말한다. N이 주어졌을 때, 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력하는 프로그램을 작성하시오. 

### 입력

첫째 줄에 1,000보다 작거나 같은 자연수 N이 주어진다.

### 출력

첫째 줄에 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력한다.

### 예제 입력 1

110

### 예제 출력 1

99

## 문제 링크

[https://www.acmicpc.net/problem/1065](https://www.acmicpc.net/problem/1065)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\1065\Program
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

- 한수를 구하는 함수부터 만들어 본다.
- 숫자 n에 대해 각 자리수를 구하고 앞자리와 뒷자리의 차가 같은지 조사한다.
- 같으면 한수이다.
- 최소 3자리 숫자의 경우 123이 자리수 마다 1의 차이로 등차수열을 이루고 있으므로 한수이다.
- 그런데 두자리 숫자는 차이를 하나밖에 구할 수 없으므로 등차수열이 맞나 궁금할 수도 있는데
  - 예제에 110의 경우 99개가 있다고 했으므로 0 ~ 99개 모두 한수이고
  - 100 ~ 110에서 한수가 없는 것이다.
  - 차이가 없는 한자리 숫자 (0 ~ 9)와 차이가 하나밖에 구해지지 않는 두자리 숫자 (10 ~ 99) 모두 한수로 인정한다.
- 이 조건을 한수를 구하는 함수에 모두 if 조건으로 만들어보면 된다.