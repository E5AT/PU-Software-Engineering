//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//  srand((unsigned)time(nullptr));
//
//  int last, prev, count{}, sumPos{}, countPos{}, maxNegOdd{ -21 }, maxNum{INT_MIN}, minNum{INT_MAX};
//
//  do
//  {
//    last = rand() % 61 - 20;
//    cout << last << " ";
//    ++count;
//
//    if (last > 0) {
//      sumPos += last;
//      ++countPos;
//    }
//    else if (last < 0) {
//      if (last % 2) maxNegOdd = max(maxNegOdd, last);
//    }
//
//    maxNum = max(maxNum, last);
//    minNum = min(minNum, last);
//
//    if (count>1 && (prev + last) % 7 == 0) break;
//
//    prev = last;
//
//  } while (true);
//
//  cout << endl;
//
//  cout << "Общо генерирани числа: " << count << endl;
//
//  if (!countPos) cout << "Няма генерирано положително число!" << endl;
//  else cout << "Средно аритметично на всички генерирани положителни: " << (double)sumPos / countPos << endl;
//
//  if (maxNegOdd == -21) cout << "Няма генерирано отрицателно нечетно число!" << endl;
//  else cout << "Максимално отрицателно нечетно: " << maxNegOdd << endl;
//
//  cout << "Разликата между най-голямото и най-малкото число: " << maxNum - minNum << endl;
//}