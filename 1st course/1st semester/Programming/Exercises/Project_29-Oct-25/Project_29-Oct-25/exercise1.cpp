#include <iostream>
using namespace std;

int main() {
  system("chcp 1251 > nul");

  //-10 до 20
  //брой  четни == нечетни => спира генерирането
  //извеждаме:
  // средно аритметично на отрицателни
  // минимум положителни

  srand((unsigned)time(nullptr));

  int countEven{}, countOdd{}, sumNeg{}, minPos{INT_MAX}, countNeg{};

  do {
    int Last = rand() % 31 - 10;

    if (Last % 2) countOdd++;
    else countEven++;
    
    if (Last < 0) countNeg++, sumNeg += Last;
    if (Last > 0 && minPos > Last) minPos = Last;
  } while (countEven != countOdd);

  if (!countNeg) cout << "Няма отрицателно.\n";
  else cout << "Средно аритметично на отрицателните: " << sumNeg / (double)countNeg << endl;

  if (minPos == INT_MAX) cout << "Няма положително.\n";
  else cout << "Минимално положително: " << minPos << endl;
}