# Problem 2839

## 설탕 배달

### 문제

상근이는 요즘 설탕공장에서 설탕을 배달하고 있다. 상근이는 지금 사탕가게에 설탕을 정확하게 N킬로그램을 배달해야 한다. 설탕공장에서 만드는 설탕은 봉지에 담겨져 있다. 봉지는 3킬로그램 봉지와 5킬로그램 봉지가 있다.

상근이는 귀찮기 때문에, 최대한 적은 봉지를 들고 가려고 한다. 예를 들어, 18킬로그램 설탕을 배달해야 할 때, 3킬로그램 봉지 6개를 가져가도 되지만, 5킬로그램 3개와 3킬로그램 1개를 배달하면, 더 적은 개수의 봉지를 배달할 수 있다.

상근이가 설탕을 정확하게 N킬로그램 배달해야 할 때, 봉지 몇 개를 가져가면 되는지 그 수를 구하는 프로그램을 작성하시오.

### 입력

첫째 줄에 N이 주어진다. (3 ≤ N ≤ 5000)

### 출력

상근이가 배달하는 봉지의 최소 개수를 출력한다. 만약, 정확하게 N킬로그램을 만들 수 없다면 -1을 출력한다.

### 예제 입력 1

18

### 예제 출력 1

4

### 예제 입력 2

4

### 예제 출력 2

-1

### 예제 입력 3

6

### 예제 출력 3

2

### 예제 입력 4

9

### 예제 출력 4

3

### 예제 입력 5

11

### 예제 출력 5

3

## 문제 링크

[https://www.acmicpc.net/problem/2839](https://www.acmicpc.net/problem/2839)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\2839\Program
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
cd BaekjoonOnlineJudge\Problems\2839\Program.test
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

## Solve - wrong method

- 처음에 문제를 제대로 이해하지 않고 단순히 아래와 같은 논리로 문제를 풀었었다.
  - 5Kg 봉지로 일단 나눠지는지 확인
    - 나눠지면? 깔끔하게 종료
    - 아니라면? 3Kg 봉지로 재도전
- 그런데 채점해 보니 틀렸다고 한다.
- 아니 왜? 이걸? 하면서 문제를 다시 보고 예제 입력과 출력의 결과를 본 후에 왜 예제 입력과 출력의 갯수가 5개인지 이유를 이해할 수 있었다.
  - 11Kg의 경우 단순히 5로 나눈 나머지로만 계산해 버리면 -1을 만들 수 밖에 없다.
  - 그런데 현실 세계에서는 5Kg 봉지에 하나 담고 남은 6Kg을 3kg 봉지 두 개에 나눠 담으면 담기기 때문에 조건을 달리해서 구해야 한다..

## Solve2 - wrong method2

- 처음에 5Kg 봉지로 나눠 보는 건 맞고 그 후에 총 Kg에서 5Kg씩을 빼 가며 3Kg 봉지로 담을 수 있는지를 체크해 보기로 했다.
- 3Kg 봉지로 담을 수 있다면, 그때 까지 뺀 5Kg 봉지의 갯수와 3Kg으로 나눈 몫을 합한 봉지의 개수를 구한다.
- 총 Kg의 수가 마이너스가 된다면 담을 수 없는 설탕의 무게이므로 -1이 나오면 될 것이다.
- 생각 자체는 그럴싸 했지만... 이것도 틀린 조건이었다.
- 11Kg의 경우에는 잘 되나 숫자가 커지면 상대적으로 3Kg의 봉지수가 많아지게 되므로 틀린 조건이 된다.
  - 작은 숫자 말고 상대적으로 큰 수인 29Kg의 경우를 보면 처음 5Kg 봉지로 나눠 지지 않으므로 그 다음 스텝인 5Kg을 덜어내고 남은 설탕인 24Kg으로 조건을 걸게 된다.
  - 이걸 3Kg 봉지에 담을 수 있다고 판단하기 때문에 총 5Kg 1봉지, 3Kg 8봉지로 해서 9봉지가 맞지 않나? 싶기도 하지만
  - 현실 세계에서는 5Kg 봉지로 4봉지를 담고 남은 9Kg을 3Kg 봉지 3개에 담기 때문에 7봉지로 더 적은 봉지를 사용할 수 있다.
- 본격적으로 사고의 논리가 틀리게 되면 코드도 그대로 틀리게 되는 전형적인 삽질이었다.

## Solve3

- 전체 무게에서 5Kg을 빼는게 아니라 처음 부터 5Kg 봉지로 담을 수 있는 최대치를 구하고
- 남은 설탕에서 3Kg 봉지를 담을 수가 없다면, 5Kg 봉지에 담았던 설탕을 하나씩 풀어서 남은 설탕과 합친 후 계속 3Kg 봉지로 담을 수 있는지 체크해 보면 정답을 맞출 수 있다.
- 여기서 5Kg 봉지를 모두 풀었는데도 봉지에 담을 수 없을 때 -1이 나오면 된다.

## Solve3 코드 설명

``` csharp
int Pkg5 = 0;
int Pkg3 = 0;
int Mod = 0;
int PkgCount = 0;

// 최대 담을 수 있는 5kg 봉지 개수를 구하고
// 5Kg 봉지 개수를 줄여가며 3Kg 봉지에 담기는지 조사
int Pkg5MaxCount = n / 5;

// 5Kg 봉지에 깔끔하게 담기면 3Kg 봉지에 담기는지 조사할 필요 없음
if (n % 5 == 0)
{
    return Pkg5MaxCount;
}

// 5Kg에 담았던 설탕을 풀어 헤칠 준비
for (int i = Pkg5MaxCount; i >= 0; i--)
{
    // 5Kg 봉지에 담긴 갯수
    Pkg5 = i;
    // 5Kg 봉지에 담고 남은 설탕의 무게
    Mod = n - 5 * i;
    // 5Kg 봉지에 담아보고 남은 설탕이 3Kg 봉지에 담김
    if (Mod % 3 == 0)
    {
        Pkg3 = Mod / 3;
        break;
    }
}

PkgCount = Pkg5 + Pkg3;

//Console.WriteLine($"Pkg5: {Pkg5}, Pkg3: {Pkg3}");

// 담을 수 없다면 -1
return PkgCount == 0 ? -1 : PkgCount;
```