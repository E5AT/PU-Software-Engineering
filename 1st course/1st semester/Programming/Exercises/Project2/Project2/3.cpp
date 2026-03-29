//#include <iostream>
//using namespace std;
//
//int main() {
//  system("chcp 1251>null");
//  srand((unsigned)time(nullptr));
//
//
//  int current, firstPos{}, count{}, minPos{INT_MAX}, maxNeg{INT_MIN};
//
//  for (int i = 0; i < 200; i++) {
//    current = rand() % 101 - 50;
//    cout << current << " ";
//    count++;
//
//    if (current > 0) {
//      if (minPos == INT_MAX) firstPos = current;
//      minPos = min(minPos, current);
//    }
//    else if (current < 0) maxNeg = max(maxNeg, current);
//
//    if (firstPos == -current && count>1) break;
//  }
//  cout << endl;
//
//  if (minPos == INT_MAX) cout << "Няма генерирани положителни числа." << endl;
//  else cout << "Минимално положително: " << minPos << endl;
//
//  if (maxNeg == INT_MIN) cout << "Няма генерирано отрицателно число." << endl;
//  else cout << "Максимално отрицателно: " << maxNeg << endl;
//
//  cout << "Общо генерирани числа: " << count;
//}