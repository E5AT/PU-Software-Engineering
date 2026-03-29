//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//void readArray(int* arr, int n) {
//  for (int i{}; i < n; i++)
//    cin >> arr[i];
//}
//
//void sumAndAvg(const int* arr, int n, int& sum, double& avg) {
//  int count{};
//  for (int i{}; i < n; i++)
//    sum += arr[i], count++;
//  avg = (double)sum / count;
//}
//
//int countInRange(const int* arr, int n, int a, int b) {
//  int count{};
//  for (int i{}; i < n; i++)
//    if (arr[i] >= a && arr[i] <= b)
//      count++;
//  return count;
//}
//
//int main() {
//  int n;
//  cout << "n = "; cin >> n;
//
//  int* arr = new int[n];
//  readArray(arr, n);
//
//  int sum{};
//  double avg;
//  sumAndAvg(arr, n, sum, avg);
//
//  int a, b;
//  cout << "a = ", cin >> a;
//  cout << "b = ", cin >> b;
//  int countRange = countInRange(arr, n, a, b);
//
//  cout
//    << "Sum: " << sum << endl
//    << "Avg: " << setprecision(2) << avg << endl
//    << "Count [" << a << ";" << b << "]: " << countRange << endl;
//  
//}