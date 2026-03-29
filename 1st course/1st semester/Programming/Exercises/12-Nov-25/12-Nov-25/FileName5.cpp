//#include <iostream>
//using namespace std;
//
//void divider() {
//  cout << string(10, '-') << endl;;
//}
//
//void readArray(int *arr, int len) {
//  for (int i = 0; i < len; i++)
//    cout << i << ". елемент: ", cin >> arr[i];
//}
//
//void minAndCount(const int* arr, int len, int& minValue, int& countMin) {
//  minValue = arr[0];
//  for (int i = 1; i < len; i++) {
//    if (minValue > arr[i])
//      minValue = arr[i], countMin = 1;
//    else if (minValue == arr[i]) countMin++;
//  }
//}
//
//void countDivisible(int *arr, int len, int k, int &countDivK) {
//  for (int i{}; i < len; i++)
//    if (!(arr[i] % k)) countDivK++;
//}
//
//int main() {
//  system("chcp 1251 > null");
//
//  int n;
//  cout << "N = "; cin >> n;
//  int* arr = new int[n];
//  
//  divider();
//
//  readArray(arr, n);
//
//  divider();
//
//  int k;
//  cout << "K = "; cin >> k;
//  divider();
//
//  int minValue, countMin{ 1 };
//  minAndCount(arr, n, minValue, countMin);
//  cout << "Минимален елемент: " << minValue << endl;
//  cout << "Брой срещания: " << countMin << endl;
//
//  divider();
//
//  int countDivK{};
//
//  countDivisible(arr, n, k, countDivK);
//  cout << "Брой, кратни на " << k << ": " << countDivK << endl;
//}