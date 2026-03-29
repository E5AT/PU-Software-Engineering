//#include <iostream>
//using namespace std;
//
////void input(int& age) {
////  cout << "Въведете вашата възраст: ";
////  cin >> age;
////}
////
////bool IsValidAge(int age) {
////  return age > 0 && age < 120;
////}
//
////int input() {
////  int n;
////  cout << "Въведете число: ";
////  if (!(cin >> n)) {
////    cout << "Не е число";
////    return 0;
////  }
////  return n;
////}
//
//void input(int& n) {
//  cout << "Въведете число: ";
//    if (!(cin >> n)) {
//      cout << "Не е число";
//      exit(0);
//    }
//}
//
//int main() {
//  system("chcp 1251 > nul");
//  //int i = 35;
//  //if (i % 7 == 0)//<, ==, !=, <=, ||, &&
//  //  cout << "Здравей" << endl;
//  //cout << "Край" << endl;
//
//  /*while (true) {
//    int age;
//    cout << "Въведете вашата възраст: ";
//    cin >> age;
//    if (age > 0 && age < 120) {
//      cout << "Коректна възраст" << endl;
//      break;
//    }
//    else
//      cout << "Некоректна възраст" << endl;
//  }*/
//
//  /*int age;
//  input(age);
//  if (IsValidAge(age))
//    cout << "Валидна възраст" << endl;
//  else
//    cout << "Невалидна възраст" << endl;*/
//
//    /*int num;
//    cout << "Въведете число: ";
//    cin >> num;
//    if (num > 0 && num % 2 == 0)
//      cout << "Да";
//    else cout << "Не";*/
//
//  int num;
//  input(num);
//
//  /*auto IsPositiveAndEven = [](int n) {
//    return n > 0 && n % 2 == 0;
//    };*/
//
//  auto IsPositiveAndEven = [num]() {
//    return num > 0 && num % 2 == 0;
//    };
//
//    if (IsPositiveAndEven())
//      cout << "Да";
//    else
//      cout << "Не";
//}