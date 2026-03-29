//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//
//  int current, count{}, first, sumLowerFirst{}, sumPosEven{}, countPosEven{}, minNum{}, maxNum{};
//
//  do {
//    cout << "Въведете число(0 за край): "; cin >> current;
//
//    if (!current) break;
//
//    ++count;
//
//    if (count == 1) {
//      first = current;
//      maxNum = minNum = current;
//    }
//    else {
//      if (current < first) sumLowerFirst += current;
//      maxNum = max(maxNum, current);
//      minNum = min(minNum, current);
//    }
//
//    if (current > 0 && current % 2) {
//      sumPosEven += current;
//      ++countPosEven;
//    }
//
//  } while (true);
//
//  cout << "Брой числа: " << count << endl;
//
//  cout << "Сума на числата, по-малки от първото: " << sumLowerFirst << endl;
//
//  if (!countPosEven) cout << "Не бяха въведени положителни нечетни числа!" << endl;
//  else cout << "Средно аритметично на положителните нечетни числа: " << fixed << setprecision(3) << (double)sumPosEven / countPosEven << endl;
//
//  cout << "Разликата между най-голямото и най-малкото число: " << maxNum - minNum << endl;
//}