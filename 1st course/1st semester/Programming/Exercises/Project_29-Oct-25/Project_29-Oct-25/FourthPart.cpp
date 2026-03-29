#include <iostream>
using namespace std;

int main() {
  system("chcp 1251 > nul");

  int n{ 25 }, &r{ n };
  cout << n << "  " << r<<endl;

  r -= 20;
  cout << n << "  " << r;

  //check pointers and refs
};