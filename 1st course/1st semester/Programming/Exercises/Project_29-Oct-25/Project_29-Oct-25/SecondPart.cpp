#include <iostream>
using namespace std;

int main() {
  system("chcp 1251 > nul");

  try {
    int k = 0;
    cout << 20 / k << endl;
  }
  catch (...) {
    cout << "Error";
  }
}