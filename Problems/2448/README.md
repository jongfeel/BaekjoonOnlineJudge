# Problem 2448

## 별찍기 - 11

### 문제

예제를 보고 별찍는 규칙을 유추한 뒤에 별을 찍어 보세요.

### 입력

첫째 줄에 N이 주어진다. N은 항상 3*2^k 수이다. (3, 6, 12, 24, 48, ...) (k<=10)

### 출력

첫째 줄부터 N번째 줄까지 별을 출력한다.

### 예제 입력 1

24

### 예제 출력 1

```script
                       *
                      * *
                     *****
                    *     *
                   * *   * *
                  ***** *****
                 *           *
                * *         * *
               *****       *****
              *     *     *     *
             * *   * *   * *   * *
            ***** ***** ***** *****
           *                       *
          * *                     * *
         *****                   *****
        *     *                 *     *
       * *   * *               * *   * *
      ***** *****             ***** *****
     *           *           *           *
    * *         * *         * *         * *
   *****       *****       *****       *****
  *     *     *     *     *     *     *     *
 * *   * *   * *   * *   * *   * *   * *   * *  
***** ***** ***** ***** ***** ***** ***** *****
```

## 문제 링크

[https://www.acmicpc.net/problem/2448](https://www.acmicpc.net/problem/2448)

## Run - bash

```bash
cd BaekjoonOnlineJudge\Problems\2448\Program
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

- 문제에서 주어진 내용과 같이 규칙성을 잘 찾아낸 후에 별을 찍어보면 되는 문제이다.