#include <iostream>
#include <ctime>
using namespace std;

int main() {
  system("chcp 1251 > null");
  srand((unsigned)time(nullptr));

  int last, prev, prevPrev, count{}, sumPos{}, sumNegOdd{}, countNegOdd{}, countDiv3{}, maxNum{ INT_MIN }, minNum{INT_MAX};

  do
  {
    last = rand() % 61 - 30;
    cout << last << " ";
    ++count;

    if (last > 0) sumPos += last;
    else if (last < 0 && last % 2) sumNegOdd += last, ++countNegOdd;

    if (last % 3 == 0) ++countDiv3;

    maxNum = max(maxNum, last);
    minNum = min(minNum, last);

    if (count > 2)
      if (last < 0 && prev < 0 && prevPrev < 0)
        if (last > prev && prev > prevPrev)
          break;

    if (count == 1) prev = last;
    else prevPrev = prev, prev = last;

  } while (last < 0 && prev < 0);

  cout << endl;

  cout << "Брой числа: " << count << endl;

  cout << "Сума положителни: " << sumPos << endl;

  if (countNegOdd) cout << "Средно аритметично на отрицателните нечетни: " << (double)sumNegOdd / countNegOdd << endl;
  else cout << "Няма отрицателни нечетни!";

  cout << "Процент кратни на 3: " << ((double)countDiv3 / count) * 100 << " %" << endl;

  cout << "Разлика най-голямо най-малко: " << maxNum - minNum << endl;

}