#include <iostream>
using namespace std;

void fillArr(double arr[], int len, double min, double max) {
  if (!arr) return;
  for(int i{};i<len;i++)
    do {
      cout << i << ". елемент: ";
      cin >> arr[i];
    } while (arr[i]<min || arr[i]>max);
}

void print(const double arr[], int len) {
  if (!arr || len < 1) return;
  for (int i{}; i < len; i++)
    cout << arr[i] << " ";
  cout << endl;
}

double maxEL(const double arr[], int len) {
  if (!arr || len < 1) return NAN;
  double maxEl = arr[0];
  for (int i{}; i < len; i++)
    maxEl = max(maxEl, arr[i]);
  return maxEl;
}

void printIndexMax(const double arr[], int len, double max) {
  if (!arr || len < 1) return;
  for (int i{}; i < len; i++)
    if (arr[i] == max) cout << i << " ";
  cout << endl;
}

void findMinElAndCount(const double arr[], int len, double& minEl, int& count) {
  if (!arr || len < 1) {
    minEl = NAN;
    count = 0;
    return;
  }
  minEl = arr[0];
  count = 1;
  for (int i{ 1 }; i < len; i++)
    if (minEl == arr[i]) count++;
    else if (minEl > arr[i]) minEl = arr[i], count = 1;
}

double sumNeg(const double arr[], int len) {
  if (!arr || len < 1) return NAN;
  double sum{};
  for (int i{}; i < len; i++)
    if (arr[i] < 0) sum += arr[i];
  return sum;
}

int main() {
  system("chcp 1251 > null");

  const int len = 7;
  double arr[len];
  fillArr(arr, len, -100.5, 45.5);
  print(arr, len);

  double maxElement = maxEL(arr, len);
  cout << "Максимален елемент: " << maxElement << endl;

  cout << "Индекс на максимални елементи: ";
  printIndexMax(arr, len, maxElement);

  double minEl;
  int minCount;
  findMinElAndCount(arr, len, minEl, minCount);
  cout << "Минимален елемент: " << minEl << " (" << minCount << " път/и)\n";

  cout << "Сумата на отрицателните: " << sumNeg(arr, len);
}