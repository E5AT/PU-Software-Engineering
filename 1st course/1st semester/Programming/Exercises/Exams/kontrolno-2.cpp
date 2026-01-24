#include <iostream>
using namespace std;

void fillArr(double arr[], int len, double min, double max) {
  if (!arr) return;
  if (min > max) swap(min, max);
  for(int i{};i<len;i++)
    do
    {
      cout << i << ". елемент(от " << min << " до " << max << "): ";
      cin >> arr[i];
    } while (arr[i]<min || arr[i]>max);
}

void print(const double arr[], int len) {
  if (!arr) {
    cout << "Ќ€ма масив!";
    return;
  }

  if (len < 1) {
    cout << "Ќ€ма елементи с четни и нечетни индекси!";
    return;
  }

  cout << "≈лементи с четни индекси: ";
  for (int i{}; i < len; i += 2) {
    cout << arr[i];
    if (i + 2 < len) cout << ";";
  }

  cout << endl;

  if (len < 2) {
    cout << "Ќ€ма елементи с нечетни индекси!";
    return;
  }
  cout << "≈лементи с нечетни индекси: ";
  for (int i{ 1 }; i < len; i += 2) {
    cout << arr[i];
    if (i + 2 < len) cout << ";";
  }
}

void countAndSumAfterNeg(const double arr[], int len, int& countAfterNeg, double& sumAfterNeg) {
  if (!arr || len < 1) {
    countAfterNeg = 0;
    sumAfterNeg = NAN;
    return;
  }

  countAfterNeg = sumAfterNeg = 0;
  for (int i{}; i < len - 1; i++)
    if (arr[i] < 0) sumAfterNeg += arr[i+1], countAfterNeg++;
}

int main() {
  system("chcp 1251 > null");

  const int len = 8;
  double arr[len];

  const double min = -25.9, max = 10.11;
  fillArr(arr, len, min, max);
  cout << endl;

  print(arr, len);
  cout << "\n\n";

  int countAfterNeg;
  double sumAfterNeg;
  countAndSumAfterNeg(arr, len, countAfterNeg, sumAfterNeg);
  if (!countAfterNeg)
    cout << "Ќ€ма елементи, които се намират непосредствено след отрицателен!";
  else
    cout << "Ѕрой елементи, намиращи се след отрицателен: " << countAfterNeg << "\n",
    cout << "—умата на елементите, намиращи се след отрицателен: " << sumAfterNeg;
  cout << endl;
}