//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//
//  int current, first, prev, count{}, maxDiff{}, sumPos{}, countPos{};
//
//  do
//  {
//    cout << "Въведете число: "; cin >> current;
//    
//    if (!current) break;
//
//    if(count>1)
//      if (first == current || ((prev < 0) && (current < 0))) break;
//
//    ++count;
//
//    if (count == 1) {
//      first = current;
//    }
//
//    if (current > 0) {
//      sumPos += current;
//      ++countPos;
//    }
//
//    if (count > 1) {
//      maxDiff = max(maxDiff, max(abs(prev - current), abs(current - prev)));
//    }
//
//    prev = current;
//
//
//  } while (true);
//  
//  cout << "Брой числа: " << count << endl;
//
//  if (!maxDiff) cout << "Бяха въведени по-малко от две числа!" << endl;
//  else cout << "Най-голяма разлика между две поредни числа: " << maxDiff << endl;
//
//  if (!countPos) cout << "Няма положителни числа!" << endl;
//  else cout << "Средноаритметично на положителните: " << fixed << setprecision(2) << (double)sumPos / countPos << endl;
//
//}