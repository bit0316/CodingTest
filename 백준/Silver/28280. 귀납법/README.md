# [Silver I] 귀납법 - 28280 

[문제 링크](https://www.acmicpc.net/problem/28280) 

### 성능 요약

메모리: 176072 KB, 시간: 368 ms

### 분류

너비 우선 탐색, 그래프 이론, 그래프 탐색

### 제출 일자

2024년 9월 29일 21:34:11

### 문제 설명

<p>똑똑한 한별이는 수학적 귀납법을 배우자마자 산술⋅기하 평균 부등식을 스스로 증명해냈다. 잠시 한별이의 우아한 증명을 감상해 보자.</p>

<p>명제(산술⋅기하 평균 부등식): 모든 정수 $n > 0$과 양의 실수 $x_1, \cdots, x_n$에 대해, 부등식 $\frac{1}{n}\sum_{i=1}^n x_i \ge \sqrt[n]{\prod_{i=1}^{n}x_i}$가 성립한다.</p>

<p>증명: $n=1$일 때에는 분명하다. 또 모든 양의 실수 $x_1, x_2$에 대해 $\frac{1}{2}(x_1 + x_2) - \sqrt{x_1x_2}$$= \frac{1}{2}(\sqrt{x_1} - \sqrt{x_2})^2 \ge 0$이므로 $n = 2$일 때도 성립한다.</p>

<details><summary style="display: list-item">단계 1: $n = k$일 때 성립하면 $n = 2k$ 일 때도 성립한다.</summary>

<p>이건 $n=k$일 때와 $n=2$일 때의 명제를 한번씩 사용하면 쉽다. 즉, \[\frac{1}{2k}\sum_{i=1}^{2k} x_i = \frac{1}{2}\left(\frac{1}{k}\sum_{i=1}^k x_i + \frac{1}{k}\sum_{i=k+1}^{2k} x_i\right) \ge \frac{1}{2}\left(\sqrt[k]{\prod_{i=1}^{k}x_i} + \sqrt[k]{\prod_{i=k+1}^{2k}x_i}\right)\ge \sqrt{\sqrt[k]{\prod_{i=1}^{k}x_i} \sqrt[k]{\prod_{i=k+1}^{2k}x_i}} = \sqrt[2k]{\prod_{i=1}^{2k}x_i}\]</p>
</details>

<details><summary style="display: list-item">단계 2: $n=k > 1$일 때 성립하면 $n=k-1$일 때도 성립한다.</summary>

<p>양의 실수 $x_1, \cdots, x_{k-1}$에 대해, $x_k = \frac{1}{k-1}\sum_{i=1}^{k-1} x_i$로 두자. 그러면 $\frac{1}{k}\sum_{i=1}^k x_i = \frac{1}{k-1}\sum_{i=1}^{k-1} x_i$을 확인할 수 있고,</p>

<p>\[\frac{1}{k-1}\sum_{i=1}^{k-1} x_i=\frac{1}{k}\sum_{i=1}^k x_i \ge \sqrt[k]{\prod_{i=1}^{k}x_i} = \sqrt[k]{\left(\prod_{i=1}^{k-1}x_i \right)\frac{1}{k-1}\sum_{i=1}^{k-1} x_i}\]</p>

<p>이고, 양변을 $k$제곱하고 $\frac{1}{k-1}\sum_{i=1}^{k-1}x_i$로 나눠주면 $(\frac{1}{k-1}\sum_{i=1}^{k-1} x_i)^{k-1} \ge \prod_{i=1}^{k-1}x_i $을 얻는다. 따라서 $n=k-1$일 때도 명제가 성립한다.</p>
</details>

<p>단계 1, 2를 종합하면 모든 자연수 $n$에 대해 산술⋅기하 평균 부등식이 성립한다! 증명 끝!</p>

<p>옆에서 한별이의 증명을 읽은 여러분은 정말로 단계 1, 2를 가지고 증명을 완성한 것인지 의구심이 남아 있다. 양의 정수 $k$가 주어질 때, 정수 $1$에서 시작하여 현재 값을 $2$배 하거나 $1$을 뺀 값으로 바꾸는 행동을 몇 번 해야 $k$를 만들 수 있는지 계산해서 의구심을 해소해 보자. 물론 도중에 거친 값들은 모두 양의 정수여야 한다.</p>

### 입력 

 <p>첫 줄에는 테스트케이스의 개수 $T$가 주어진다. ($1 \le T \le 20$)</p>

<p>각 테스트케이스마다 한 줄에 양의 정수 $k$가 주어진다.</p>

<p>$k$의 총합은 $4 \times 10^6$을 넘지 않는다.</p>

### 출력 

 <p>각 테스트케이스마다 한 줄에, $1$에서 시작해서 $2$배를 하거나 $1$을 빼는 행동을 최소 몇 번 반복해야 $k$를 만들 수 있는지 출력한다.</p>

<p>만약 $k$를 만들지 못한다면, 대신 <span style="color:#e74c3c;"><code>Wrong proof!</code></span>를 출력한다.</p>

