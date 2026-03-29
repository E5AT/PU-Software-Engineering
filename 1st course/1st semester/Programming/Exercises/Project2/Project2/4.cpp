//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//  srand((unsigned)time(nullptr));
//
//  int countEven{}, countOdd{}, countNeg{}, sumPos{}, countPos{}, maxOdd{ -11 };
//
//  do
//  {
//    int last = rand() % 41 - 10;
//    cout << last << " ";
//
//    if (last % 2) {
//      ++countOdd;
//      maxOdd = max(maxOdd, last);
//    }
//    else ++countEven;
//
//    if (last > 0) {
//      sumPos += last;
//      ++countPos;
//    }
//    else if(last<0) ++countNeg;
//  } while (countEven!=countOdd);
//
//  cout << endl;
//
//  cout << "Брой отрицателни: " << countNeg << endl;
//
//  if (!countPos) cout << "Няма генерирани положителни числа!" << endl;
//  else cout << "Средно аритметично на положителни: " << (double)sumPos / countPos << endl;
//
//  if (maxOdd == -11)cout << "Няма генерирано отрицателно нечетно число!" << endl;
//  else cout << "Най-голямо нечетно: " << maxOdd << endl;
//}