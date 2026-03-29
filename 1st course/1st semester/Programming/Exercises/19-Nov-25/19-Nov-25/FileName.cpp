//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void GenRandNums(long arr[], long n, long min, long max) {
//  if (!arr) return;
//  if (max < min) swap(max, min);
//  //-5 до 20
//  for (int i{}; i < n; i++)
//    arr[i] = rand() % (max - min + 1) + min;
//}
//
//void printArray(const long arr[], int len) {
//  if (!arr || len < 1) return;
//    for (int i{}; i < len; i++)
//      cout << arr[i] << "  ";
//  cout << endl;
//}
//
//int countPairs(const long arr[], int len) {
//  if (!arr || len < 2) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (abs(arr[i - 1] % 2) != abs(arr[i] % 2))
//      ++count;
//  return count;
//}
//
//long maxSum(const long arr[], int len) {
//  if (!arr || len < 2) return LONG_MIN;
//  long maxSum = arr[0] + arr[1];
//  for (int i{ 2 }; i < len; i++)
//    maxSum = max(maxSum, arr[i - 1] + arr[i]);
//  return maxSum;
//}
//
//void incEvenAfterOdd(long arr[], int len) {
//  if (arr)
//    for (int i{ len-1 }; i > 0; i--)
//      if (arr[i] % 2 == 0 && arr[i - 1] % 2)
//        arr[i]++;
//}
//
//void viewPairs(long arr[],int len) {
//  if (!arr || len < 1) return;
//  cout << "Двойки елементи симетрични спрямо средата и с еднаква четност: \n";
//
//  for (int L{}, R{ len - 1 }; L < R; L++, R--)
//    if (abs(arr[L] % 2) == abs(arr[R] % 2))
//      cout << "  индекси  " << L << ", " << R << "  ;  стойности  "
//      << arr[L] << ", " << arr[R] << endl;
//
//  cout << " (край на двойките)\n";
//}
//
//void printParity(const long arr[], int len) {
//  if (arr)
//    for (int i{ 0 }; i < len; i++) {
//      cout << " " << arr[i];
//      if (len-1==i || abs(arr[i + 1] % 2) != abs(arr[i] % 2))
//        cout << endl;
//  }
//}
//
//int indexLastSamePare(const long arr[], int len) {
//  if (!arr || len<1) return -1;
//
//  /*int i{ len - 1 };
//  while (i && arr[i] % 2 != 0 == (arr[i - 1] % 2 != 0)) --i;
//  return i;*/
//
//  for (int i{ len - 1 }; i >= 0; i--)
//    if (arr[i] % 2 != 0 != (arr[i - 1] % 2 != 0))
//      return i;
//  return 0;
//}
//int main() {
//  system("chcp 1251 > null");
//
//  srand((unsigned)time(nullptr));
//  const int len = 15;
//
//  long arr[len];
//  GenRandNums(arr, len, -5, 20);
//
//  printArray(arr, len);
//
//  //9:45 - 11:15
//  //1 - 53:30
//
//  cout << "Брой на двойките съседни елементи с различна четност: "
//    << countPairs(arr, len) << endl;
//
//  cout << "Максимална сума: " << maxSum(arr, len) << endl;
//
//  incEvenAfterOdd(arr, len);
//
//  printArray(arr, len);
//
//  viewPairs(arr, len);
//
//  printParity(arr, len);
//  //52:30
//
//  int k = indexLastSamePare(arr, len);
//  cout << "Последен елемент, след който има елементи с неговата четност: "
//    << k << ". " << arr[k] << endl;
//
//  void viewUnsortedDistinct(const long[], int),
//       viewSortedDistinct(const long[],int);
//
//  viewUnsortedDistinct(arr, len);
//  viewSortedDistinct(arr, len);
//}
//
//void viewUnsortedDistinct(const long arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++) {
//    int first{};
//    while (arr[first] != arr[i]) first++;
//    if (first == i) cout << " " << arr[i];
//  }
//  cout << endl;
//}
//
//void viewSortedDistinct(const long arr[], int len) {
//  for (int i{}; i < len; i++)
//    if (0 == i || arr[i - 1] != arr[i])
//      cout << " " << arr[i];
//  cout << endl;
//}