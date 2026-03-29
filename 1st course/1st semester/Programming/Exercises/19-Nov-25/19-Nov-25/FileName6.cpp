//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//void enterDaysCount(int& len) {
//  do {
//    cout << "N = ";
//    cin >> len;
//  } while (len<7 || len>60);
//}
//
//void fillArr(int arr[], int len) {
//  if (!arr || len < 1) return;
//  int entered;
//  for (int i{}; i < len; i++){
//      do
//      {
//        cout << i << ". елемент: ";
//        cin >> entered;
//      } while (entered < -2000 || entered>8000);
//    arr[i] = entered;
//  }
//}
//
//void findMinTurnoverAndCount(const int arr[], int len, int& minTurnover, int& minTurnoverCount) {
//  if (!arr || len < 1) return;
//  minTurnover = arr[0];
//  minTurnoverCount = 1;
//  for (int i{ 1 }; i < len; i++)
//    if (minTurnover == arr[i])
//      minTurnoverCount++;
//    else if (minTurnover > arr[i])
//      minTurnover = arr[i], minTurnoverCount = 1;
//}
//
//void findMaxTurnoverAndCount(const int arr[], int len, int& maxTurnover, int& maxTurnoverCount) {
//  if (!arr || len < 1) return;
//  maxTurnover = arr[0];
//  maxTurnoverCount = 1;
//  for (int i{ 1 }; i < len; i++)
//    if (maxTurnover == arr[i])
//      maxTurnoverCount++;
//    else if (maxTurnover < arr[i])
//      maxTurnover = arr[i], maxTurnoverCount = 1;
//}
//
//double averageTurnover(const int arr[], int len) {
//  if (!arr || len < 1) return NAN;
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//int countDaysUnderAverageTurnover(const int arr[], int len, double average) {
//  if (!arr || len < 1) return 0;
//  int count{0};
//  for (int i{}; i < len; i++)
//    if (arr[i] < average)
//      count++;
//  return count;
//}
//
//void printLocalMaxs(const int arr[], int len) {
//  if (!arr || len < 3) return;
//  for (int i{ 1 }; i < len - 1; i++)
//    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
//      cout << arr[i] << " ";
//}
//
//int findCountPosTurnovers(int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] > 0) count++;
//  return count;
//}
//
//void newArrWithPosTurnovers(const int arr[], int len, int newArr[]) {
//  if (!arr || len < 1) return;
//  int index{};
//  for (int i{}; i < len; i++)
//    if (arr[i] > 0)
//      newArr[index++] = arr[i];
//}
//
//void printUniqTurnovers(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++) {
//    bool isUnique = true;
//    for (int j{}; j < i; j++)
//      if (arr[i] == arr[j])
//        isUnique = false;
//    if (isUnique)
//      cout << arr[i] << " ";
//  }
//}
//
//void placeDiv7InTheEnd(int arr[], int len) {
//  if (!arr || len < 1) return;
//  int* temp = new int[len];
//  int index{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 7 != 0)
//      temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 7 == 0)
//      temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    arr[i] = temp[i];
//
//  delete[] temp;
//}
//
//int findIndexFirstDayWithLoss(const int arr[], int len) {
//  if (!arr || len < 1) return -1;
//  for (int i{}; i < len; i++)
//    if (arr[i] < 0) return i;
//  return -1;
//}
//
//int countDaysBetween1000and3000(const int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 1000 && arr[i] <= 3000)
//      count++;
//  return count;
//}
//
//void printArr(int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//}
//
//int main() {
//  system("chcp 1251 > null");
//  
//  int len;
//  enterDaysCount(len);
//
//  int* arr = new int[len];
//  fillArr(arr, len);
//
//  cout << endl;
//
//  int min, minCount;
//  findMinTurnoverAndCount(arr, len, min, minCount);
//  cout << "Минимум: " << min << " (" << minCount << " път/и)\n";
//
//  int max, maxCount;
//  findMaxTurnoverAndCount(arr, len, max, maxCount);
//  cout << "Максимум: " << max << " (" << maxCount << " път/и)\n\n";
//
//  double average = averageTurnover(arr, len);
//  cout << "Среден оборот: " << fixed << setprecision(1) << average << "\n";
//  cout << "Брой дни под средния: " << countDaysUnderAverageTurnover(arr, len, average) << "\n\n";
//
//  cout << "Локални максимуми: "; printLocalMaxs(arr, len); cout << "\n\n";
//
//  int newArrLen = findCountPosTurnovers(arr, len);
//  int* newArr = new int[newArrLen];
//  newArrWithPosTurnovers(arr, len, newArr);
//  cout << "Нов масив (положителни): ";
//  printArr(newArr, newArrLen);
//  cout << "\n\n";
//
//  cout << "Уникални обороти: ";
//  printUniqTurnovers(arr, len);
//  cout << "\n\n";
//
//  cout << "Първият отрицателен: индекс " << findIndexFirstDayWithLoss(arr, len);
//  cout << "\n\n";
//
//  cout << "Дни в интервала [1000;3000]: " << countDaysBetween1000and3000(arr, len);
//  cout << "\n\n";
//
//  cout << "След преместване на кратните на 7 в края:\n";
//  placeDiv7InTheEnd(arr, len);
//  printArr(arr, len);
//
//  delete[] arr;
//  delete[] newArr;
//}