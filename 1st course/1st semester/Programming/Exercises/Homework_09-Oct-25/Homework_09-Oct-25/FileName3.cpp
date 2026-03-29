#include <iostream>
using namespace std;

//string print = "Hello World!";

void /*HelloWorld*/print(/*string*/int text) {
  cout << text << endl;
}

int main(){
  system("chcp 1251 > nul");

  /*HelloWorld(print);*/

  int a = 0;
  print(a);

  int* b = &a;
  print(*b);

  *b = 1;
  print(*b);
  print(a);
}