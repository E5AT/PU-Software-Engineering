//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//  srand((unsigned)time(nullptr));
//
//  int prev{}, current, count{}, sum{}, minPosOdd{27}, sumNeg{};
//
//  do {
//    current = rand() % 51 - 25;
//    cout << current << " ";
//    ++count;
//    sum += current;
//
//      if (current > 0 && current % 2==1) minPosOdd = min(minPosOdd, current);
//      else if (current < 0) sumNeg += current;
//
//      if ((prev > 0 && current > 0) || (prev < 0 && current < 0))
//        break;
//
//      prev = current;
//
//  } while (true);
//
//  cout << endl;
//  
//  cout << "Общ брой: " << count << endl;
//  cout << "Средно аритметично: " << fixed << setprecision(3) << (double)sum / count << endl;
//  if (minPosOdd == 27) cout << "Няма генерирано положително нечетно число!" << endl;
//  else cout << "Най-малкото положително нечетно число: " << minPosOdd << endl;
//  cout << "Сумата на всички отрицателни числа: " << sumNeg << endl;
//}