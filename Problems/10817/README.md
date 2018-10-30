# Problem 10817

## 세 수

### 문제

세 정수 A, B, C가 주어진다. 이때, 두 번째로 큰 정수를 출력하는 프로그램을 작성하시오. 

### 입력

첫째 줄에 세 정수 A, B, C가 공백으로 구분되어 주어진다. (1 ≤ A, B, C ≤ 100)

### 출력

두 번째로 큰 정수를 출력한다.

### 예제 입력 1

20 30 10

### 예제 출력 1

20

### 예제 입력 2

30 30 10

### 예제 출력 2

30

### 예제 입력 3

40 40 40

### 예제 출력 3

40

### 예제 입력 4

20 10 10

### 예제 출력 4

10

## 문제 링크

[https://www.acmicpc.net/problem/10817](https://www.acmicpc.net/problem/10817)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\10817\Program
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
cd BaekjoonOnlineJudge\Problems\10817\Program.test
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

- 이 문제를 쉽게 푸는 방법은 입력받은 숫자 세개를 array에 담고 sort를 한 후에 index = 1에 위치한 숫자를 얻는 것이다.
- 이렇게 푸는게 제일 깔끔하긴 한데 이 문제 만큼은 좀 억지를 부려 봤다.
- 세 수를 비교해서 두번 째 큰 수를 찾는 방법은 if 문을 총 여섯번 사용하면 되는데, if else 문을 쓰다 보면 depth가 3이나 된다. 여기서 얻을 수 있는 좋은 지식은 두 가지가 되는데
  - data structure를 공부한 컴공인이라면 이게 tree를 표현하는 구조라는 걸 눈치챌 수 있다.
  - 또 수학을 잘 하거나 좋아하는 분은 숫자가 써져 있는 공 3개를 뽑에 차례로 나열하는 방법, 즉 Permutation(순열)의 결과 값이라는 것이다. 공을 뽑는 경우의 수를 구하면 가운데 있는 숫자가 뭔지를 한 눈에 찾아낼 수 있다.
- 위 두 수학적 지식을 결합하면 sort를 하는 한 가지 방법인 binary search라는 걸 알게 된다.
- 카네기 멜론 대학교의 sort algorithm 자료 중 Lower bound를 참고해 보도록 하자
- [https://www.cs.cmu.edu/~adamchik/15-121/lectures/Sorting%20Algorithms/sorting.html](https://www.cs.cmu.edu/~adamchik/15-121/lectures/Sorting%20Algorithms/sorting.html)
- 어쨌든 결론은 그 트리 모양을 최대한 살리고 conditional operator (?:)를 써서 method를 구현했다는 것이다.