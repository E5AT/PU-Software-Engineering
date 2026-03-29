//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//
//  srand((unsigned)time(nullptr));
//
//  int count{ }, doublePrev, prev, current, countPos{}, sumPos{};
//  do
//  {
//    current = rand() % 61 - 30;
//    cout << current << "  ";
//    count++;
//
//    if (current > 0 && current % 3 == 0) {
//      sumPos += current;
//      ++countPos;
//    }
//
//    if (count == 1) doublePrev = current;
//    else if (count == 2) prev = current;
//    else {
//      if (doublePrev + prev + current < 0) break;
//      else {
//        swap(current, prev);
//        swap(current, doublePrev);
//      }
//    }
//  } while (true);
//
//  cout << endl << "Общо генерирани числа: " << count << endl;
//  cout << "Средноаритметичното на всички положителни числа, които се делят на три: ";
//  if (!countPos) cout << "няма";
//  else cout << fixed << setprecision(3) << (double)sumPos / countPos;
//  cout << endl;
//}