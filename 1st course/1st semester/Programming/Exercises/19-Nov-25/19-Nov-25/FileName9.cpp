//#include <iostream>
//using namespace std;
//
//void fillArrWithPosDivnt3(int arr[], int len) {
//  if (!arr || len < 1) return;
//  int index{};
//  do {
//    for (int i{}; index!=len; i++) {
//      if (i % 3 != 0) arr[index++] = i;
//    }
//    break;
//  } while (true);
//}
//
//void printArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{ len - 1 }; i > 0; i--)
//    cout << arr[i] << ",";
//  cout << arr[0];
//  cout << endl;
//}
//
//void printOddNums(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    if (arr[i] % 2 != 0) cout << arr[i] << " ";
//  cout << endl;
//}
//
//int countEvenNums(const int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] % 2 == 0) count++;
//  return count;
//}
//
//int main() {
//  system("chcp 1251 > null");
//
//  const int len{ 10 };
//  int arr[len];
//  fillArrWithPosDivnt3(arr, len);
//  printArr(arr, len);
//  cout << "\n";
//
//  printOddNums(arr, len);
//  cout << endl;
//
//  cout << countEvenNums(arr, len) << endl;
//}