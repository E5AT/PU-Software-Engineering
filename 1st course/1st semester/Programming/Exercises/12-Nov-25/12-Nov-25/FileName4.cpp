//#include <iostream>
//using namespace std;
//
//int MaxNum(int *arr, int len) {
//  int maxNum{ arr[0]};
//  for (int i{ 1 }; i < len; i++)
//    maxNum = max(maxNum, arr[i]);
//  return maxNum;
//}
//
//void PrintEven(int* arr, int len) {
//  for (int i{}; i < len; i++)
//    if (arr[i] % 2 == 0) cout << arr[i] << "; ";
//  cout << endl;
//}
//
//int main() {
//
//  int len;
//  cout << "Въведете дължината на масива: "; cin >> len;
//
//  int* arr = new int[len];
//
//  for (int i{}; i < len; i++)
//    cout << "Въведете елемент с индекс " << i << ": ", cin >> arr[i];
//
//  cout << "Най-голямото число: " << MaxNum(arr, len);
//  cout << endl;
//
//  cout << "Четни числа: ";
//  PrintEven(arr, len);
//}