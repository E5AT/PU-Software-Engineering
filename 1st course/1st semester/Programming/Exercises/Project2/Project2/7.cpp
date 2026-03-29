//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//  srand((unsigned)time(nullptr));
//
//  int current, prev, prevPrev, count{}, sumNeg{}, countNeg{}, maxEvenPos{ INT_MIN }, countMult3{};
//
//  do {
//    current = rand() % 46 - 15;
//    cout << current << " ";
//    ++count;
//
//    if (current < 0) {
//      sumNeg += current;
//      ++countNeg;
//    }
//    else if (current > 0 && current%2==0) maxEvenPos = max(maxEvenPos, current);
//
//    if (current % 3 == 0) ++countMult3;
//
//    if (count > 2 && current > prev && prev > prevPrev) break;
//    else {
//      if (count > 1) prevPrev = prev;
//      prev = current;
//    }
//
//  } while (true);
//
//  cout << endl;
//
//  cout << "Брой генерирани числа: " << count << endl;
//
//  if (countNeg == 0) cout << "Не беше генерирано отрицателно число!" << endl;
//  else cout << "Средно аритметично на отрицателните числа: " << (double)sumNeg / countNeg << endl;
//
//  if (maxEvenPos == INT_MIN) cout << "Не беше генерирано четно положително число!" << endl;
//  else cout << "Най-голямото четно положително число: " << maxEvenPos << endl;
//
//  if (countMult3 == 0) cout << "Не бяха генерирани числа, кратни на 3!" << endl;
//  else cout << "Процент на числата, кратни на 3: " << ((double)countMult3/count)*100 << " %" << endl;
//}