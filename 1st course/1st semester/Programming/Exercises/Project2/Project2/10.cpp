#include <iostream>
#include <iomanip>
using namespace std;

int main() {
  system("chcp 1251>null");
  srand((unsigned)time(nullptr));

  int last, prev, count{}, sumPos{}, countPos{}, countNeg{}, minOddPos{ INT_MAX };

  do
  {
    last = rand() % 41 - 20;
    ++count;
    cout << last << " ";

    if (last > 0) sumPos += last, ++countPos;
    else if (last < 0) ++countNeg;

    if (last > 0 && last % 2)
      minOddPos = min(minOddPos, last);

    if (count > 1)
      if (last % 2 == 0 && prev % 2 == 0) break;

    prev = last;

  } while (true);

  cout << endl;

  cout << "Брой числа: " << count << endl;

  if (!countPos) cout << "Няма положителни числа!" << endl;
  else cout << "Средно аритметично на положителни: " << (double)sumPos / countPos << endl;

  if (!countNeg) cout << "Няма отрицателни числа!" << endl;
  else cout << "Процент на отрицателни числа: " << ((double)countNeg / count) * 100 << " %" << endl;

  if (minOddPos == INT_MAX) cout << "Няма нечетно положително число!" << endl;
  else cout << "Най-малко нечетно положително число: " << minOddPos << endl;

}