#include <iostream>
using namespace std;

int main() {
  system("chcp 1251 > null");

  /*Вариант 3

    Задача
    Да се напише приложение на езика C++, което извършва следните обработки :
  а) въвежда цели числа, докато два пъти подред бъде прочетено число, което се дели
  на четири;
  б) след прекратяването на въвеждането съобщава, колко пъти е прочетено число,
  по - голямо от - 22, и извежда най - голямото нечетно число, делящо се на три, или
    съобщение, че всяко прочетено число нарушава поне едно от тези две изисквания.*/

  int prev, last, countBiggerNeg22{}, maxOddDiv3{ INT_MIN }, count{};

  do {
    cout << "Въведете число: "; cin >> last;
    ++count;

    if (last > -22) ++countBiggerNeg22;

    if (last % 2 != 0 && last % 3 == 0)
      if (maxOddDiv3 < last) maxOddDiv3 = last;

    if (count > 1)
      if (last % 4 == 0 && prev % 4 == 0) break;

    prev = last;

  } while (true);

  cout << endl;
  cout << "Брой на числата по-големи от -22: " << countBiggerNeg22 << endl;

  cout << endl;
  if (maxOddDiv3 == INT_MIN) cout << "Не е въведено число, което е нечетно и се дели на три!" << endl;
  else cout << "Най-голямо нечетно число, което се дели на три: " << maxOddDiv3 << endl;


}