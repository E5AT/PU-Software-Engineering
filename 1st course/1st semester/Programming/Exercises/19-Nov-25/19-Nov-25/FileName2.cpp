//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void fillArrayWithRandNums(int arr[], int len, int min, int max) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    arr[i] = rand() % (max - min + 1) + min;
//}
//
//void printArray(int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//  cout << endl;
//}
//
//void findMinElAndCount(const int arr[], int len, int minEl, int minElCount) {
//  if (!arr || len < 1) return;
//  minEl = INT_MAX;
//  for (int i{}; i < len; i++)
//    minEl = min(minEl, arr[i]);
//
//  minElCount=0;
//  for (int i{}; i < len; i++)
//    if (arr[i] == minEl)
//      minElCount++;
//}
//
//bool isPrime(int num) {
//  if (num == 1) return false;
//  else if (num == 2) return true;
//  else
//    for (int i{ 3 }; i < sqrt(num); i++)
//      if (num % i == 0) return false;
//  return true;
//}
//
//int countPrimeNums(const int arr[], int len) {
//  int count{};
//  for (int i{}; i < len; i++)
//    if (isPrime(arr[i]))
//      count++;
//  return count;
//}
//
//double arrayAverage(int arr[], int len) {
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//double averageGreaterThanAverage(int arr[], int len) {
//  int count{}, sum{};
//  int average = arrayAverage(arr, len);
//  for (int i{}; i < len; i++)
//    if (arr[i] > average) sum+=arr[i],count++;
//  return (double)sum / count;
//}
//
//void replaceMultiples(int arr[], int len, int divisor, int newValue) {
//  for (int i{}; i < len; i++)
//    if (arr[i] % divisor == 0) arr[i] = newValue;
//}
//
//int countPairsMultBy5(int arr[], int len) {
//  int count{};
//  for (int i{ 1 }; i < len; i++)
//    if ((arr[i - 1] + arr[i]) % 5 == 0)
//      count++;
//  return count;
//}
//
//void Inverse(int arr[], int len) {
//  int* temp = new int[len];
//  for (int i{ len - 1 }, j{}; i >= 0; i--, j++)
//    temp[j] = arr[i];
//
//  for (int i{}; i < len; i++)
//    arr[i] = temp[i];
//
//  delete[] temp;
//}
//
//int getCountUniqueElements(int arr[], int len) {
//  int count{};
//  for (int i{}; i < len; i++) {
//    bool isUnique = true;
//    for(int j{};j<i;j++)
//      if (arr[i] == arr[j]) {
//        isUnique = false;
//        break;
//      }
//    if (isUnique) count++;
//  }
//  return count;
//}
//
//void distinctArr(int arr[], int len, int* uniqArr) {
//
//  int indexUnique{};
//  for (int i{}; i < len; i++) {
//    bool isUnique = true;
//    for(int j{};j<i;j++)
//      if (arr[i] == arr[j]) {
//        isUnique = false;
//        break;
//      }
//    if (isUnique)
//      uniqArr[indexUnique++] = arr[i];
//  }
//}
//
//int main() {
//  system("chcp 1251 > null");
//  srand((unsigned)time(nullptr));
//
//  const int len{ 10 };
//  int arr[len];
//  fillArrayWithRandNums(arr, len,10,-10);
//  printArray(arr,len);
//  Inverse(arr, len);
//  printArray(arr, len);
//
//  int uniqLen = getCountUniqueElements(arr, len);
//  int* uniqArr = new int[uniqLen];
//  distinctArr(arr, len, uniqArr);
//  printArray(uniqArr, uniqLen);
//}