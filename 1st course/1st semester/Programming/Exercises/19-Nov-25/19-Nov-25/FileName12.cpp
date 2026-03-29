//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void fillArr(int arr[], int len, int min, int max) {
//  if (!arr) return;
//  if (min > max) swap(min, max);
//  int x;
//  for (int i{}; i < len; i++) {
//    do
//    {
//      x = rand() % (max - min + 1) + min;
//    } while (x % 2 == 0);
//    arr[i] = x;
//  }
//}
//
//void printArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//  cout << endl;
//}
//
//void findXinArr(const int arr[], int len, int x) {
//  if (!arr || len < 1) return;
//  bool found = false;
//  for(int i{};i<len;i++)
//    if (arr[i] == x) {
//      found = true;
//      break;
//    }
//
//  if (!found) cout << "Не е намерено това число!";
//  else {
//    cout << "Индекси на " << x << ": ";
//    for (int i{}; i < len; i++)
//      if (arr[i] == x)
//        cout << i << " ";
//  }
//  cout << endl;
//}
//
//void findFirstAndLastGreaterX(int arr[], int len, int x) {
//  if (!arr || len < 1) return;
//  int indexFirstGreater, indexLastGreater;
//  indexFirstGreater = indexLastGreater = -1;
//  for (int i{}; i < len; i++)
//    if (arr[i] > x) {
//      if (indexFirstGreater == -1)
//        indexFirstGreater =  i;
//      indexLastGreater = i;
//    }
//
//  if (indexFirstGreater == -1)
//    cout << "Няма елементи по-големи от " << x << "!";
//  else cout << "По-големи от " << x << ": първи: " << indexFirstGreater << ". ;последен: " << indexLastGreater << ".!";
//  cout << endl;
//}
//
//void printBeginSeq(const int arr[], int len, int x) {
//  if (!arr || len < 1) return;
//  cout << "Най-дълго начало от елементи, под " << x << ": ";
//  for (int i{}; i < len; i++) {
//    if (arr[i] >= x) break;
//    cout << arr[i] << " ";
//  }
//  cout << endl;
//}
//
//void showLastSequenceOdd(const int a[], int L) {
//  if (!a || L<1) return;
//  int startIndex{ L };
//  cout << "Най-дълга редица от последни нечетни елементи: ";
//  for (int i{L-1}; i > 0; i--) {
//    if (a[i - 1] % 2 == 0)
//      startIndex = i;
//      break;
//    }
//
//  for (; startIndex < L; startIndex++)
//    cout << a[startIndex] << " ";
//  cout << endl;
//}
//
//void showLastSequenceOdd(const long a[], int L) {
//  if (!a) return;
//  int Last{ L };
//  while (Last > 0 && a[Last - 1] % 2) --Last;
//  cout << "Най-дълга редица от последни нечетни елементи: ";
//  while (Last < L) cout << " " << a[Last++];
//  cout << "  (край)\n";
//}
//
//int main() {
//  system("chcp 1251 > null");
//  srand((unsigned)time(nullptr));
//
//  const int len = 10;
//  int arr[len];
//  fillArr(arr, len, -6, 11);
//  printArr(arr, len);
//
//  int x;
//  cout << "Число за търсене: ";
//  cin >> x;
//  findXinArr(arr, len, x);
//
//  findFirstAndLastGreaterX(arr, len, x);
//
//  printBeginSeq(arr, len, x);
//  arr[6] = 2;
//  showLastSequenceOdd(arr, len);
//}