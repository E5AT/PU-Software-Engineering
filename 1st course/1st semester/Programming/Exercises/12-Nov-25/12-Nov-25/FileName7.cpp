#include <iostream>
using namespace std;

void maxAndCount(const int* arr, int n, int& maxValue, int& countMax){
  maxValue = arr[0];
  countMax = 1;
  for (int i = 1; i < n; i++)
    if (maxValue < arr[i])
      maxValue = arr[i], countMax = 1;
    else if (maxValue == arr[i])
      countMax++;
}

bool isPrime(int x) {
  if (x <= 1) return false;
  for (int i = 2; i < sqrt(x); i++)
    if (x % 2 == 0) return false;
  return true;
}

int countPrime(const int* arr, int n) {
  int count{};
  for (int i{}; i < n; i++)
    if (isPrime(arr[i])) count++;
  return count;
}

void replaceNegatives(int* arr, int n, int value) {
  for (int i{}; i < n; i++)
    if (arr[i] < 0)
      arr[i] = value;
}

int main() {

  int n;
  cout << "n = ", cin >> n;

  int* arr = new int[n];
  cout << "Elements: ";
  for (int i{}; i < n; i++)
    cin >> arr[i];

  int value;
  cout << "Value to replace: ", cin >> value;

  int maxValue, countMax;
  maxAndCount(arr, n, maxValue, countMax);
  cout << "Max: " << maxValue << endl
    << "Count max: " << countMax << endl;

  int countPr = countPrime(arr, n);
  cout << "Prime count: " << countPr << endl;

  replaceNegatives(arr, n, value);
  cout << "New array: ";
  for (int i{}; i < n; i++)
    cout << arr[i] << " ";
  cout << endl;

  delete[] arr;
}