//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void fillArrayWithRandomNums(int arr[], int len, int min, int max) {
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
//void minElAndCount(int arr[], int len, int& minEl, int& minCount) {
//  if (!arr || len < 1) return;
//  minEl = arr[0];
//  minCount = 1;
//  for (int i{ 1 }; i < len; i++) {
//    if (minEl == arr[i]) minCount++;
//    else if (minEl > arr[i]) {
//      minEl = arr[i];
//      minCount = 1;
//    }
//  }
//}
//
//bool isPrime(int num) {
//  if (num < 2) return false;
//  else if (num == 2) return true;
//  else if (num % 2 == 0) return false;
//  for (int i{ 3 }; i * i <= num; i += 2)
//    if (num % i == 0) return false;
//  return true;
//}
//
//int countPrime(int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count = 0;
//  for (int i{}; i < len; i++)
//    if (isPrime(arr[i])) count++;
//  return count;
//}
//
//double averageArray(int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//double averageGreaterThanAverage(int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int sum{}, count{};
//  double average = averageArray(arr, len);
//  for(int i{};i<len;i++)
//    if (arr[i] > average) {
//      sum += arr[i];
//      count++;
//    }
//  if (count == 0) return 0;
//  return (double)sum / count;
//}
//
//void negsFirstPlace(int arr[], int len) {
//  if (!arr || len < 1) return;
//  int* temp = new int[len];
//  int tempIndex{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] < 0) temp[tempIndex++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 0) temp[tempIndex++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    arr[i] = temp[i];
//
//  delete[] temp;
//}
//
//int indexFirstLowerThanAverage(int arr[], int len) {
//  if (!arr || len < 1) return -1;
//  double average = averageArray(arr, len);
//  for (int i{}; i < len; i++)
//    if (arr[i] < average) return i;
//  return -1;
//}
//
//void showUniqueElements(int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++) {
//    bool isUnique = true;
//    for (int j{}; j < i; j++)
//      if (arr[i] == arr[j]) isUnique = false;
//    if (isUnique) cout << arr[i] << " ";
//  }
//  cout << endl;
//}
//
//void showPrimeNums(int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    if (isPrime(arr[i]))
//      cout << arr[i] << " ";
//  cout << endl;
//}
//
//int main() {
//  system("chcp 1251 > null");
//  srand((unsigned)time(nullptr));
//
//  const int len = 12;
//  int arr[len];
//
//  fillArrayWithRandomNums(arr, len, -50, 120);
//  printArray(arr, len);
//
//  int minEl, minCount;
//
//  minElAndCount(arr, len, minEl, minCount);
//
//  cout << "\nМинимален елемент: " << minEl << "\nБрой: " << minCount << "\n\nПрости числа:\n";
//
//  showPrimeNums(arr, len);
//  cout << "Брой прости числа: " << countPrime(arr, len) << endl;
//
//  cout << "\nСредно аритметично: " << averageArray(arr, len) << endl;
//  cout << "Средно аритметично на елементите над средното: " << averageGreaterThanAverage(arr, len) << endl;
//
//  negsFirstPlace(arr, len);
//  cout << "\nОтрицателните в началото: \n";
//  printArray(arr, len);
//
//  cout << "\nИндекс на първият елемент под средното: " << indexFirstLowerThanAverage(arr, len) << endl;
//
//  cout << "\nУникални елементи: \n";
//  showUniqueElements(arr, len);
//}