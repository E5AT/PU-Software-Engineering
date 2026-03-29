//#include <iostream>
//using namespace std;
//int main() {
//  system("chcp 1251 > null");
//
//  /*const int tCLen{ 8 };
//    long t[][tCLen]{
//      {1,2,3},
//      {11,22,33,44},
//      {},
//      {-1,-2,-3,-4,-5,-6},
//      1,2,3,4,5,6,7,8,9,10
//    };
//  
//    const int tRLen{ sizeof(t) / sizeof(t[0]) };
//  
//    for (int i = 0; i < tRLen; i++) {
//      for (int j = 0; j < tCLen; j++)
//        cout <<t[i][j] << " ";
//      cout << endl;
//    }*/
//
//  const int length = 7;
//  long ar[length];
//  cout << "Въведете масив от " << length << " елемента: ";
//  for (int i{}; i < length; i++) {
//    cout << " за индекст " << i << ": ";
//    cin >> ar[i];
//  }
//
//  long minNum{ ar[0] }, maxNum{ ar[0] };
//  for (int i{}; i < length; ++i) {
//    if (ar[i] < minNum) minNum = ar[i];
//    if (ar[i] > maxNum) maxNum = ar[i];
//  }
//
//  cout << "Минимум: " << minNum << "\nМаксимум: " << maxNum << endl;
//
//
//}