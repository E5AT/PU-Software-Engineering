#include <iostream>
using namespace std;

int main() {
  system("chcp 1251 > nul");

  cout << RAND_MAX << endl << SHRT_MAX << endl;

  srand((unsigned)time(nullptr));

  for (int i = 0; i < 10; i++) cout << rand() % 21 << " ";
  cout << endl;

  for (int i = 0; i < 10; i++) cout << rand() % 16 - 5 << " "; // -5 до 10
  cout << endl;

  for (int i = 0; i < 10; i++) cout << rand() % 15 * 2 - 6<< " "; //четни -4 до 10
  cout << endl;

  for (int i = 0; i < 10; i++) cout << rand() % 15 * 2 - 9 << " "; //нечетно -9 до 19
  cout << endl;

  //17:00


}