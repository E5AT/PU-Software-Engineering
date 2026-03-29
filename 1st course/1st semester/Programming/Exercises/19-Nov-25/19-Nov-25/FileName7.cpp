//#include <iostream>
//using namespace std;
//
//void enterLength(int& n) {
//  do {
//    cout << "N = ";
//    cin >> n;
//  } while (n < 10 || n>60);
//}
//
//void enterArr(int arr[], int len, int min, int max) {
//  if (!arr || len < 1) return;
//  cout << "Масив: ";
//  int num;
//  for (int i{}; i < len; i++) {
//    do
//    {
//      cin >> num;
//    } while (num<min||num>max);
//    arr[i] = num;
//  }
//}
//
//void findModeAndCount(const int arr[], int len, int& mode, int& maxCount) {
//  if (!arr || len < 1) return;
//  mode = arr[0];
//  maxCount = 1;
//
//  for (int i{}; i < len; i++) {
//    int current = arr[i];
//    int count = 0;
//
//    for (int j{}; j < len; j++)
//      if (arr[j] == current)
//        count++;
//
//    if (count > maxCount)
//      maxCount = count, mode = current;
//  }
//}
//
//double findAverage(const int arr[], int len) {
//  if (!arr || len < 1) return NAN;
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//int findDaysLowerThanAverage(const int arr[], int len, double average) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] < average)
//      count++;
//  return count;
//}
//
//void printPlateau(const int arr[], int len) {
//  if (!arr || len < 3) return;
//  for (int i{ 1 }; i < len - 1; i++)
//    if (arr[i] == arr[i - 1] && arr[i]==arr[i+1])
//      cout << arr[i] << " ";
//  cout << endl;
//}
//
//int countDaysBetween30and70(const int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int newLen{};
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 30 && arr[i] <= 70)
//      newLen++;
//  return newLen;
//}
//
//void createNewArr(const int arr[], int len, int newArr[]) {
//  if (!arr || len < 1) return;
//  int index{};
//  for (int i{}; i < len; i++)
//    if (arr[i] >= 30 && arr[i] <= 70)
//      newArr[index++] = arr[i];
//}
//
//void div10InTheEnd(int arr[], int len) {
//  int* temp = new int[len];
//  int index{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 10 != 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 10 == 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    arr[i] = temp[i];
//
//  delete[] temp;
//}
//
//void uniqueElements(const int arr[], int len) {
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
//int findIndexFirstDayWith100(const int arr[], int len) {
//  if (!arr || len < 1) return -1;
//  for (int i{}; i < len; i++)
//    if (arr[i] == 100) return i;
//  return -1;
//}
//
//int countPairSumDiv5(const int arr[], int len) {
//  if (!arr || len < 2) return 0;
//  int count{};
//  for (int i{}; i < len - 1; i++)
//    if ((arr[i] + arr[i + 1]) % 5 == 0)
//      count++;
//  return count;
//}
//
//void printArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    cout << arr[i] << " ";
//}
//
//int main() {
//  system("chcp 1251 > null");
//
//  int len{};
//  enterLength(len);
//
//  int* arr = new int[len];
//  enterArr(arr, len, 0, 100);
//
//  int mode, modeCount;
//  findModeAndCount(arr, len, mode, modeCount);
//  cout << "Най-често срещана стойност: " << mode << " (" << modeCount << " път/и)\n";
//
//  double average = findAverage(arr, len);
//  cout << "Средна влажност: " << average << endl;
//  cout << "Дни под средната: " << findDaysLowerThanAverage(arr, len, average) << endl;
//
//  cout << "Плато елементи: ";
//  printPlateau(arr, len);
//  cout << endl;
//
//  int newLen = countDaysBetween30and70(arr, len);
//  int* newArr = new int[newLen];
//  createNewArr(arr, len, newArr);
//  cout << "Нов масив [30..70]: ";
//  printArr(newArr, newLen);
//  cout << endl;
//
//  cout << "Уникални стойности: ";
//  uniqueElements(arr, len);
//
//  cout << "Индекс на първия ден със 100%: " << findIndexFirstDayWith100(arr, len) << endl;
//
//  cout << "Брой двойки със сума кратна на 5: " << countPairSumDiv5(arr, len) << endl;
//
//  cout << "След преместване на кратните на 10 в края:\n";
//  div10InTheEnd(arr, len);
//  printArr(arr, len);
//  cout << endl;
//
//  delete[] arr;
//}