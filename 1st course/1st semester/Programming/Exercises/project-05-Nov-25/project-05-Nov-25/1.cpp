//#include <iostream>
//#include <iomanip>
//using namespace std;
//int main() {
//  system("chcp 1251 > null");
//  srand((unsigned)time(nullptr));
//
//  const int tCLen{ 8 };
//  long t[][tCLen]{
//    {1,2,3},
//    {11,22,33,44},
//    {},
//    {-1,-2,-3,-4,-5,-6},
//    1,2,3,4,5,6,7,8,9,10
//  };
//
//  const int tRLen{ sizeof(t) / sizeof(t[0]) };
//
//  for (int i = 0; i < tRLen; i++) {
//    for (int j = 0; j < tCLen; j++)
//      cout <<t[i][j] << " ";
//    cout << endl;
//  }
//
//  for (long* p{ t[0] + tRLen * tCLen - 1 }; p >= t[0];)
//    *p-- = rand() % 10101 - 100;
//
//  for (int i = 0; i < tRLen; i++) {
//    for (int j = 0; j < tCLen; j++)
//      cout << setw(10)<< t[i][j];
//    cout << endl;
//  }
//
//}