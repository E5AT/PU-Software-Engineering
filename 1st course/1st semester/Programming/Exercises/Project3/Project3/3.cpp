//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251 > null");
//
//  int last, prev, count{}, sumPosDiv5{}, sumNeg{}, countNeg{}, countPosEnd3{}, maxNum, minNum;
//
//  do {
//    cout << "Въведете число: "; cin >> last;
//    ++count;
//
//    if (count == 1) maxNum = minNum = last;
//    else minNum = min(minNum, last), maxNum = max(maxNum, last);
//
//    if (last > 0 && last % 5 == 0) sumPosDiv5 += last;
//    else if (last < 0) sumNeg += last, ++countNeg;
//    else if (last > 0 && last % 10 == 3) ++countPosEnd3;
//
//    if(count>1)
//      if ((prev + last) % 2 == 0) break;
//
//    prev = last;
//  } while (true);
//
//  cout << "Брой числа: " << count << endl;
//
//  cout << "Сума положителни, кратни на 5: " << sumPosDiv5 << endl;
//
//  if (countNeg) cout << "Средно аритметично отрицателни: " << (double)sumNeg / countNeg << endl;
//  else cout << "Няма отрицателни!" << endl;
//
//  cout << "Брой положителни, завършващи на 3: " << countPosEnd3 << endl;
//
//  cout << "Разликата между най-голямото и най-малкото число: " << maxNum - minNum << endl;
//}