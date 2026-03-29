//#include <iostream>
//using namespace std;
//
//void fillArr(double arr[], int len, double min, double max) {
//  if (!arr || len < 1) return;
//  for(int i{};i<len;i++)
//    do
//    {
//      cout << i << ". елемент: ";
//      cin >> arr[i];
//    } while (min>i || max<i);
//}
//
//void printArr(const double arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//  cout << endl;
//}
//
//double maxElementArr(double arr[], int len) {
//  if (!arr || len < 1) return NAN;
//  double maxNum = arr[0];
//  for (int i{1}; i < len; i++)
//    maxNum = max(maxNum, arr[i]);
//  return maxNum;
//}
//
//void printindexMaxElemens(double arr[], int len, double max) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    if (arr[i] == max)
//      cout << i << " ";
//  cout << endl;
//}
//
//void findMinElAndCount(double arr[], int len, double& minEl, int& count) {
//  if (!arr || len < 1) {
//    minEl = NAN;
//    count = 0;
//    return;
//  }
//  minEl = arr[0];
//  count = 1;
//  for (int i{ 1 }; i < len; i++)
//    if (arr[i] == minEl) count++;
//    else if (arr[i] < minEl) minEl = arr[i], count = 1;
//}
//
//double negElementsSum(double arr[], int len) {
//  if (!arr || len < 1) return NAN;
//  double sum{};
//  for (int i{}; i < len; i++)
//    if (arr[i] < 0) sum += arr[i];
//  return sum;
//}
//
//int main() {
//  system("chcp 1251 > null");
//
//  const int len = 7;
//  double arr[len];
//  fillArr(arr, len, -100.5, 45.5);
//  cout << endl;
//  printArr(arr, len);
//
//  cout << endl;
//
//  double maxElement = maxElementArr(arr, len);
//  cout << "Максимален елемент: " << maxElement << "\n\n";
//
//  cout << "Индекс/и на максималните елементи: ";
//  printindexMaxElemens(arr, len, maxElement);
//  cout << endl;
//
//  double minEl;
//  int minElCount;
//  findMinElAndCount(arr, len, minEl, minElCount);
//  cout << "Минимален елемент: " << minEl << " (" << minElCount << " път/и)\n\n";
//
//  cout << "Сума на отрицателните: " << negElementsSum(arr, len) << endl;
//}