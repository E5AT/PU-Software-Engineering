//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251 > null");
//
//  int prev, last, count{}, sumNegEven{}, sumPos{}, countPos{}, maxNum, minNum;;
//
//  do
//  {
//    cout << "Въведете число: "; cin >> last;
//    ++count;
//
//    if (count == 1) maxNum = minNum = last;
//    else {
//      maxNum = max(maxNum, last);
//      minNum = min(minNum, last);
//    }
//
//    if (last < 0 && last % 2 == 0) sumNegEven += last;
//    if (last > 0) sumPos += last, ++countPos;
//
//    if(count>1)
//      if (abs(last - prev) == 5) break;
//
//    prev = last;
//  } while (true);
//
//  cout << "Брой числа: " << count << endl;
//
//  cout << "Сумата на отрицателните числа: " << sumNegEven << endl;
//
//  if (countPos) cout << "Средно аритметично на положителните: " << (double)sumPos / countPos << endl;
//  else cout << "Няма положителни числа!" << endl;
//
//  cout << "Разликата между най-голямото и най-малкото число: " << maxNum - minNum << endl;
//}