# Problem 1152

## 단어의 개수

### 문제

영어 대소문자와 띄어쓰기만으로 이루어진 문자열이 주어진다. 이 문자열에는 몇 개의 단어가 있을까? 이를 구하는 프로그램을 작성하시오. 단, 한 단어가 여러 번 등장하면 등장한 횟수만큼 모두 세어야 한다.

### 입력

첫 줄에 영어 대소문자와 띄어쓰기로 이루어진 문자열이 주어진다. 이 문자열의 길이는 1,000,000을 넘지 않는다. 단어는 띄어쓰기 한 개로 구분되며, 공백이 연속해서 나오는 경우는 없다. 또한 문자열의 앞과 뒤에는 공백이 있을 수도 있다.

### 출력

첫째 줄에 단어의 개수를 출력한다.

### 예제 입력 1

The Curious Case of Benjamin Button

### 예제 출력 1

6

### 예제 입력 2

 Mazatneunde Wae Teullyeoyo

### 예제 출력 2

3

### 예제 입력 3

Teullinika Teullyeotzi 

### 예제 출력 3

2

## 문제 링크

[https://www.acmicpc.net/problem/1152](https://www.acmicpc.net/problem/1152)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\1152\Program
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
cd BaekjoonOnlineJudge\Problems\1152\Program.test
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

- C#의 string method인 trim을 호출하여 앞 뒤 공백을 제거한다.
- 그 후 split method를 써서 전체 단어의 개수를 구한다.