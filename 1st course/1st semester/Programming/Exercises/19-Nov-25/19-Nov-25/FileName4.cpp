//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void genRandArr(int arr[], int len, int min, int max) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    arr[i] = rand() % (max - min + 1) + min;
//}
//
//void printArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//  cout << endl;
//}
//
//void findMaxTempAndCount(const int arr[], int len, int& maxTemp, int& maxTempCount) {
//  if (!arr || len < 1) return;
//  maxTemp = arr[0];
//  maxTempCount = 1;
//  for (int i{1}; i < len; i++)
//    if (maxTemp == arr[i]) maxTempCount++;
//    else if (maxTemp < arr[i]) maxTemp = arr[i], maxTempCount = 1;
//}
//
//double findAverageTemp(const int arr[], int len) {
//  if (!arr || len < 1) return -31;
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//int findCountDaysHigherThanAverageTemp(const int arr[], int len) {
//  if (!arr || len < 1) return -1;
//  int count{};
//  double averageTemp = findAverageTemp(arr, len);
//  for (int i{}; i < len; i++)
//    if (arr[i] > averageTemp)
//      count++;
//  return count;
//}
//
//void printLocalMins(int arr[], int len) {
//  if (!arr || len < 3) return;
//  for (int i{ 1 }; i < len - 1; i++)
//    if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
//      cout << arr[i] << " ";
//  cout << endl;
//}
//
//int findCountNegTemps(int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] < 0) count++;
//  return count;
//}
//
//void newArrWithoutNegTemps(int arr[], int len, int newArr[]) {
//  if (!arr || len < 1) return;
//  int index{};
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 0) newArr[index++] = arr[i];
//}
//
//void printUniqTemps(int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++) {
//    bool isUnique = true;
//    for (int j{}; j < i; j++)
//      if (arr[j] == arr[i]) isUnique = false;
//    if (isUnique) cout << arr[i] << " ";
//  }
//  cout << endl;
//}
//
//void placeEvenTempsInTheEnd(int arr[], int len) {
//  if (!arr || len < 1) return;
//  int* temp = new int[len];
//  int index{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 2 != 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 2 == 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    arr[i] = temp[i];
//
//  delete[] temp;
//}
//
//int main() {
//  system("chcp 1251 > null");
//  srand((unsigned)time(nullptr));
//
//  int len;
//  do
//  {
//    cout << "Брой дни: ";
//    cin >> len;
//  } while (len<5||len>50);
//  int* arr = new int[len];
//
//  cout << endl;
//
//  genRandArr(arr, len, -30, 50);
//  printArr(arr, len);
//
//  cout << endl;
//
//  int maxTemp, maxTempCount;
//  findMaxTempAndCount(arr, len, maxTemp, maxTempCount);
//  cout << "Максимална температура: " << maxTemp << ";\nброй: " << maxTempCount << "\n\n";
//
//  cout << "Средна температура: " << findAverageTemp(arr, len) << endl;
//  cout << "Брой дни с по-високи температури от средната: " << findCountDaysHigherThanAverageTemp(arr, len) << "\n\n";
//
//  cout << "Локални минимуми: " << endl;
//  printLocalMins(arr, len);
//  cout << endl;
//
//  int newArrLen = len - findCountNegTemps(arr, len);
//  int* newArr = new int[newArrLen];
//  newArrWithoutNegTemps(arr, len, newArr);
//  cout << "Нов масив без отицателни елементи: \n";
//  printArr(newArr, newArrLen);
//  cout << endl;
//
//  cout << "Уникални температури: ";
//  printUniqTemps(arr, len);
//  cout << endl;
//
//  cout << "Четни температури в края: \n";
//  placeEvenTempsInTheEnd(arr, len);
//  printArr(arr, len);
//
//  delete[] arr, newArr;
//}