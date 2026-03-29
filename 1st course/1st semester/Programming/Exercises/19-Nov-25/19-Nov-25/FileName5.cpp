//#include <iostream>
//#include <ctime>
//using namespace std;
//
//void fillArrWithRandNums(int arr[], int len, int min, int max) {
//  if (!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    arr[i] = rand() % (max - min + 1) + min;
//}
//
//void printArr(const int arr[], int len) {
//  if (!arr || len < 1) return;
//  for(int i{};i<len;i++)
//    cout << arr[i] << " ";
//  cout << endl;
//}
//
//void findMinMax(const int arr[], int len, int& minVal, int& maxVal) {
//  if (!arr || len < 1) return;
//  minVal = maxVal = arr[0];
//  for (int i{ 1 }; i < len; i++)
//    minVal = min(minVal, arr[i]),
//    maxVal = max(maxVal, arr[i]);
//}
//
//int countStableMeasurement(const int arr[], int len) {
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] >= -5 && arr[i] <= 5) count++;
//  return count;
//}
//
//double calculateAverageArr(const int arr[], int len) {
//  if (!arr || len < 1) return NAN;
//  int sum{};
//  for (int i{}; i < len; i++)
//    sum += arr[i];
//  return (double)sum / len;
//}
//
//int IndexFirstBelowAverage(const int arr[], int len) {
//  if (!arr || len < 1) return -1;
//  double average = calculateAverageArr(arr, len);
//  for (int i{}; i < len; i++)
//    if (arr[i] < average) return i;
//  return -1;
//}
//
//void allNegsToZero(int arr[], int len) {
//  if(!arr || len < 1) return;
//  for (int i{}; i < len; i++)
//    if (arr[i] < 0)
//      arr[i] = 0;
//}
//
//int countNumsOverAverage(const int arr[], int len) {
//  double average = calculateAverageArr(arr, len);
//  if (!arr || len < 1) return 0;
//  int count{};
//  for (int i{}; i < len; i++)
//    if (arr[i] > average)
//      count++;
//  return count;
//}
//
//void newArrWithValsOverAverage(const int arr[], int len, int newArr[]) {
//  if (!arr || len < 1) return;
//  double average = calculateAverageArr(arr, len);
//  int index{};
//  for (int i{}; i < len; i++)
//    if (arr[i] > average)
//      newArr[index++] = arr[i];
//}
//
//void placeDiv3InTheEnd(int arr[], int len) {
//  int* temp = new int[len];
//  int index{};
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 3 != 0) temp[index++] = arr[i];
//
//  for (int i{}; i < len; i++)
//    if (arr[i] % 3 == 0) temp[index++] = arr[i];
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
//  const int len = 12;
//  int arr[len];
//  fillArrWithRandNums(arr, len, -20, 40);
//
//  cout << "Масив: ";
//  printArr(arr, len);
//  int min, max;
//  findMinMax(arr, len, min, max);
//  cout << "Минимум: " << min << endl;
//  cout << "Максимум: " << max << endl << endl;
//
//  cout << "Стабилни измервания ([-5..5]): " << countStableMeasurement(arr, len) << "\n\n";
//
//  int indexFirstBelowAverage = IndexFirstBelowAverage(arr, len);
//  cout << "Първи под средното: индекс " << indexFirstBelowAverage << " (стойност " << arr[indexFirstBelowAverage] << ")\n\n";
//
//  cout << "След зануляване на отрицателните:\n";
//  allNegsToZero(arr, len);
//  printArr(arr, len);
//  cout << endl;
//
//  cout << "Нов масив с елементи над средното: \n";
//  int lenNewArr = countNumsOverAverage(arr, len);
//  int* newArr = new int[lenNewArr];
//  newArrWithValsOverAverage(arr, len, newArr);
//  printArr(newArr, lenNewArr);
//  cout << endl;
//
//  cout << "След преместване на кратните на 3 в края : \n";
//  placeDiv3InTheEnd(arr, len);
//  printArr(arr, len);
//
//
//  delete[] newArr;
//}