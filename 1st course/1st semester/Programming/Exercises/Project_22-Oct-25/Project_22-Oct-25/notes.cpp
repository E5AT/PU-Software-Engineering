#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
  system("chcp 1251 > nul");

  /*auto a{ 10 }, b{ 20 }, c{ 30 };
  cout << max(a, max(b, c));*/

  /*cout << '*' << setw(10)<<left << "Esat" << '*';*/

  int a, b;

  cout << "Въведете първото число: "; cin >> a;
  cout << "Въведете второто число: "; cin >> b;

  /*cout << "Сумата на числата(";

  if (int sum{ a + b }; sum % 2 == 0) cout << sum << ") е четно.";
  else cout << sum << ") не е четно";

  cout << endl;*/

  int sum{ a + b };

  cout << "Сумата на числата(" << sum << ") "<< (sum%2==0? "" : "не ") << "е четно\n";
}