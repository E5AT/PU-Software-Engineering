#include <iostream>
using namespace std;

int main() {
  system("chcp 1251 > nul");

  srand((unsigned)time(nullptr));

  int n;
  do {
    cout << "Въведете число от 2 до 5: ";
    cin >> n;
  } while (n < 2 || n>5);
  
  int countDiv3{}, maxSum{ INT_MIN }, prev, last{}, countAll{}, countRem1{};

  do {
    prev = last;
    last = rand() % 20 * 2 - 19;
    countAll++;
    if (abs(last%3)==1) countRem1++;
    if (last % 3 == 0) ++countDiv3;
    if (maxSum < prev + last && countAll>=1) maxSum = prev + last;
  } while (n!=countDiv3);
  cout << "Брой даващи 1 или -1 при делене с три: " << countRem1 <<endl;
  cout << "Максимална сума на две поредни: " << maxSum << endl;
  //50:00

}