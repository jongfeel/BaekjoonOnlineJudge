# Problem 11720

## 숫자의 합

### 문제

N개의 숫자가 공백 없이 쓰여있다. 이 숫자를 모두 합해서 출력하는 프로그램을 작성하시오.

### 입력

첫째 줄에 숫자의 개수 N (1 ≤ N ≤ 100)이 주어진다. 둘째 줄에 숫자 N개가 공백없이 주어진다.

### 출력

입력으로 주어진 숫자 N개의 합을 출력한다.

### 예제 입력 1

1
1

### 예제 출력 1

1

### 예제 입력 2

5
54321

### 예제 출력 2

15

### 예제 입력 3

25
7000000000000000000000000

### 예제 출력 3

7

### 예제 입력 4

11
10987654321

### 예제 출력 4

46

## 문제 링크

[https://www.acmicpc.net/problem/11720](https://www.acmicpc.net/problem/11720)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\11720\Program
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
cd BaekjoonOnlineJudge\Problems\11720\Program.test
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

- string을 int array로 만드는 방법과 int array를 sum 하는 방법에 대한 걸 구현하면 된다.
- Linq를 사용해서 Select().Sum() 메소드를 호출해서 구한다.
- 이 방법으로 풀면 첫번째 숫자의 갯수 입력하는 게 의미가 없어진다.

```csharp
numbers.Select(n => int.Parse(n.ToString())).Sum();
```