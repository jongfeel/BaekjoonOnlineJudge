# Problem 5052

## 전화번호 목록

### 문제

전화번호 목록이 주어진다. 이때, 이 목록이 일관성이 있는지 없는지를 구하는 프로그램을 작성하시오.

전화번호 목록이 일관성을 유지하려면, 한 번호가 다른 번호의 접두어인 경우가 없어야 한다.

예를 들어, 전화번호 목록이 아래와 같은 경우를 생각해보자

- 긴급전화: 911
- 상근: 97 625 999
- 선영: 91 12 54 26

이 경우에 선영이에게 전화를 걸 수 있는 방법이 없다. 전화기를 들고 선영이 번호의 처음 세 자리를 누르는 순간 바로 긴급전화가 걸리기 때문이다. 따라서, 이 목록은 일관성이 없는 목록이다. 

### 입력

첫째 줄에 테스트 케이스의 개수 t가 주어진다. (1 ≤ t ≤ 50) 각 테스트 케이스의 첫째 줄에는 전화번호의 수 n이 주어진다. (1 ≤ n ≤ 10000) 다음 n개의 줄에는 목록에 포함되어 있는 전화번호가 하나씩 주어진다. 전화번호의 길이는 길어야 10자리이며, 목록에 있는 두 전화번호가 같은 경우는 없다.

### 출력

각 테스트 케이스에 대해서, 일관성 있는 목록인 경우에는 YES, 아닌 경우에는 NO를 출력한다.

### 예제 입력 1

2\
3\
911\
97625999\
91125426\
5\
113\
12340\
123440\
12345\
98346

### 예제 출력 1

NO
YES

## 문제 링크

[https://www.acmicpc.net/problem/5052](https://www.acmicpc.net/problem/5052)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\5052\Program
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
cd BaekjoonOnlineJudge\Problems\5052\Program.test
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

- [Programmers에 동일한 문제](https://github.com/jongfeel/SongDoAlgorithmStudy/tree/master/Problems/42577)가 있어서 백준 알고리즘 문제에 그대로 적용해 봤다.
- 그런데 백준에서는 시간초과로 테스트 실패, 폭망!
- 역시 최대 10000 x 10000 x 50은 내가 봐도 시간 초과가 걸릴 것 같은 loop count이다.
- 백준 알고리즘 문제는 조금 다르게 접근해 봤다.
  - 원래 Programmers의 JAVA로 문제 풀 때도 alphbetical sort를 한 후에 selection sort 할 때 비교하듯이 n과 n+1이 유사성이 있는지를 비교하려고 했었다. 그런데 programmers 채점은 그냥 loop 돌려도 되더라.
  - 백준 알고리즘 채점에서는 우선 sort를 걸어 준 후에 나와 내 다음 값이 유사성이 있는지 검사한다. 그러면 복잡도가 O(n<sup>2</sup>)애 O(n)이 되는 마법이 펼쳐진다.
  - 그리고 채점해 보니까 맞음.