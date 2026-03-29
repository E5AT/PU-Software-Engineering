//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void fillArr(int arr[], int len, int min, int max) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    arr[i] = rand() % (max - min + 1) + min;
//}
//
//void printArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//}
//
//void printArr(const int arr[], int startIndex, int elementsToDisplayAfterStart, int len) {
//  if (!arr || len < 1 || startIndex+elementsToDisplayAfterStart>len) return;
//  int elementsDisplayed{};
//  while (true) {
//    cout << arr[startIndex++] << " ";
//    if (++elementsDisplayed == elementsToDisplayAfterStart)
//      break;
//  }
//}
//
//void longestIncreasing(const int arr[], int len, int& bestStart, int& bestLen) {
//  if (!arr || len < 1) {
//    bestStart = -1;
//    bestLen = 0;
//    return;
//  }
//  int currStart{}, currLen{ 1 };
//
//  for (int i{1}; i < len; i++) {
//    if (arr[i] > arr[i - 1])
//      currLen++;
//    else {
//      if (currLen > bestLen)
//        bestLen = currLen, bestStart = currStart;
//      currStart = i;
//      currLen = 1;
//    }
//  }
//}
//
//void findMode(const int arr[], int len, int& mode, int& modeCount) {
//  if (!arr || len < 1) return;
//  mode = arr[0];
//  modeCount = 1;
//  for (int i{ 1 }; i < len; i++) {
//    int currentCount{ 0 };
//    for (int j{}; j < len; j++)
//      if (arr[i] == arr[j])
//        currentCount++;
//    if (currentCount > modeCount)
//      mode = arr[i], modeCount = currentCount;
//  }
//}
//
//double averageArr(const int arr[], int len) {
//  if (!arr || len < 1) return NAN;
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//int countElement20prHigherThanAverage(const int arr[], int len, double average) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] > average * 1.2)
//      count++;
//  return count;
//}
//
//void printLocMinAndCount(const int arr[], int len) {
//  int count{};
//  if (!arr || len < 3) return;
//  for (int i{ 1 }; i < len - 1; i++)
//    if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
//      cout << arr[i] << " ", count++;
//  cout << endl << "Count: " << count << "\n\n";
//}
//
//int countElements1000to3000(const int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 1000 && arr[i] <= 3000)
//      count++;
//  return count;
//}
//
//void newArr1000to3000(const int arr[], int len, int newArr[]) {
//  if (!arr || len < 1) return;
//  int index{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 1000 && arr[i] <= 3000)
//      newArr[index++] = arr[i];
//}
//
//int indexFirstLow200(const int arr[], int len) {
//  if (!arr || len < 1) return -1;
//  for (int i{}; i < len; i++)
//    if (arr[i] < 200) return i;
//  return -1;
//}
//
//void placeDiv6End(int arr[], int len) {
//  if (!arr || len < 1) return;
//  int* temp = new int[len];
//  int index{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 6 != 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 6 == 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    arr[i] = temp[i];
//
//  delete[] temp;
//}
//
//void UniqArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++) {
//    bool seenBefore = false;
//    for (int j{}; j < i; j++)
//      if (arr[i] == arr[j]) {
//        seenBefore = true;
//        break;
//      }
//    if (!seenBefore) cout << arr[i] << " ";
//  }
//}
//
//int countPairsSumGreater10000(const int arr[], int len) {
//  if (!arr || len < 2) return 0;
//  int count{};
//  for (int i{}; i < len - 1; i++)
//    if (arr[i] + arr[i + 1] > 10000)
//      count++;
//  return count;
//}
//
//int main() {
//  system("chcp 1251 > null");
//  srand((unsigned)time(nullptr));
//
//  const int len = 15;
//  int arr[len];
//  fillArr(arr, len, 50, 9000);
//  printArr(arr, len);
//  cout << endl;
//
//  int bestStart, bestLen;
//  longestIncreasing(arr, len, bestStart, bestLen);
//  printArr(arr, bestStart, bestLen, len);
//  cout << endl;
//
//  int mode, modeCount;
//  findMode(arr, len, mode, modeCount);
//  cout << mode << " - " << modeCount << " times";
//  cout << endl;
//
//  double average = averageArr(arr, len);
//  cout << "Average: " << average << endl;
//  cout << "Count 20% higher than average: " << countElement20prHigherThanAverage(arr, len, average) << "\n\n";
//
//  cout << "Local minimums: \n";
//  printLocMinAndCount(arr, len);
//
//  int newLen = countElements1000to3000(arr, len);
//  int* newArr = new int[newLen];
//  newArr1000to3000(arr, len, newArr);
//  printArr(newArr, newLen);
//  cout << "\n\n";
//
//  cout << "First lower 200: " << indexFirstLow200(arr, len) << "\n\n";
//
//  cout << "Div6 in end: \n";
//  placeDiv6End(arr, len);
//  printArr(arr, len);
//  cout << "\n\n";
//
//  cout << "Unique: \n";
//  UniqArr(arr, len);
//  cout << "\n\n";
//
//  cout << "Count pairs sum greater than 10 000: " << countPairsSumGreater10000(arr, len);
//  cout << "\n\n";
//
//  delete[] newArr;
//}