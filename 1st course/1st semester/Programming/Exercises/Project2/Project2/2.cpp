//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//
//  int firstSum{}, maxSum{}, prev, current, count{}, countNegEven{};
//
//  do
//  {
//    cout << "Въведете число: "; cin >> current;
//    count++;
//    if (!current) break;
//    if (count <= 2) {
//      firstSum += current;
//      maxSum = firstSum;
//    }
//    else {
//      if (current > firstSum) break;
//      maxSum = max(maxSum, prev + current);
//      if (current < 0 && current%2==0) countNegEven++;
//    }
//    prev = current;
//  } while (true);
//
//  cout << "Най-голяма сума на две поредни числа: ";
//  if (count < 2) cout << "въведени са по-малко от две числа!";
//  else cout << maxSum;
//  cout << endl;
//
//  cout << "Брой въведени отрицателни четни числа: " << countNegEven;
//}