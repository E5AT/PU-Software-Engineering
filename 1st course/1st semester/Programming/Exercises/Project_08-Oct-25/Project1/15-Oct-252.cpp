#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > null");

  int dayNum;
  string dayName;

  cout << "Въведете ден: ";
  cin >> dayNum;
  switch (dayNum) {
  case 1: dayName = "Понеделник"; break;
  case 2: dayName = "Вторник"; break;
  case 3: dayName = "Сряда"; break;
  case 4: dayName = "Четвъртък"; break;
  case 5: dayName = "Петък"; break;
  case 6: dayName = "Събота"; break;
  case 7: dayName = "Неделя"; break;
  default: cout << "Несъществуващ ден" << endl;
  }
  if (dayNum > 0 && dayNum <= 7) cout << dayName;
}