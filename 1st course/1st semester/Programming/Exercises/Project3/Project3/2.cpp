//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251 > null");
//  int last, count{}, minNum, maxNum;
//
//  do {
//    cout << "Въведете число: "; cin >> last;
//    count++;
//
//    if (count == 1) minNum = maxNum = last;
//    else minNum = min(minNum, last), maxNum = max(maxNum, last);
//
//    if (last == -1 || count == 5) break;
//  } while (true);
//
//  cout << "Max num: " << maxNum<<endl;
//  cout << "Min num: " << minNum<<endl;
//
//}