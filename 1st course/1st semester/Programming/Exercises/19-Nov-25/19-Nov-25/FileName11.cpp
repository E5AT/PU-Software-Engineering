#include <iostream>
#include <ctime>
using namespace std;

void fillArr(int arr[], int len, int min, int max) {
  if (!arr || len < 1) return;
  for (int i{}; i < len; i++)
    arr[i] = rand() % (max - min + 1) + min;
}

void print(const int arr[], int len) {
  if (!arr || len < 1) return;
  for (int i{}; i < len; i++)
    cout << arr[i] << " ";
  cout << endl;
}

void averageOfOdds(const int arr[], int len) {
  if (!arr || len < 1) return;
  double sum{};
  int count{};
  for (int i{}; i < len; i++)
    if (arr[i] % 2 != 0) sum += arr[i], count++;
  if (!count)
    cout << "Няма нечетни елементи!";
  else
    cout << "Средното аритметично на нечетните: " << sum / count;
  cout << endl;
}

void printFirstAndLastDiv5(const int arr[], int len) {
  if (!arr || len < 1) return;
  int firstIndex, lastIndex;
  firstIndex = lastIndex = -1;
  for (int i{}; i < len; i++)
    if (arr[i] % 5 == 0) {
      if (firstIndex == -1)
        firstIndex = i;
      lastIndex = i;
    }
  if (firstIndex == -1) cout << "Няма елементи, делящи се на пет!";
  else {
    cout << "Първо срешане: " << firstIndex << ". " << arr[firstIndex] << endl;
    cout << "Последно срещане: " << lastIndex << ". " << arr[lastIndex];
  }
  cout << endl;
}

void printLongestOddTail(const int arr[], int len) {
  if (!arr || len < 1) return;
  int startIndex{ -1 }, longest{};
  int currentStartIndex{}, current{};
  for (int i{}; i < len; i++) {
    if (arr[i] % 2 != 0) {
      if (current == 0) currentStartIndex = i;
      current++;
    }
    else {
      if (longest < current) longest = current, startIndex = currentStartIndex;
      current = 0;
    }
  }

  if (startIndex == -1) cout << "Няма нечетни елементи!";
  else
    for (int i{ startIndex }; i < startIndex + longest; i++)
      cout << arr[i] << " ";
  cout << endl;
}

void changeUnderNeg5(int arr[], int len) {
  if (!arr || len < 1) return;
  for (int i{}; i < len; i++) {
    if (arr[i] < -5) {
      int prev = arr[i];
      do {
        cout << i << ". елемент: ", cin >> arr[i];
      } while (prev >= arr[i]);
    }
  }
}

int main() {
  system("chcp 1251 > null");
  srand((unsigned)time(nullptr));

  const int len = 12;
  int arr[len];
  fillArr(arr, len, -10, 15);
  print(arr, len);
  cout << endl;

  averageOfOdds(arr, len);
  cout << endl;

  printFirstAndLastDiv5(arr, len);
  cout << endl;

  printLongestOddTail(arr, len);
  cout << endl;

  changeUnderNeg5(arr, len);
  print(arr, len);
}