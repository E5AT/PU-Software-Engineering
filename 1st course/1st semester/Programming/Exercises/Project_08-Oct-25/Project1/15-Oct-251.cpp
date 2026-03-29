//#include <iostream>
//#include <set>
//using namespace std;
//
////int Max(int a, int b) {
////  return a > b ? a : b;
////}
//
//void input(char& letter) {
//  cout << "Въведете буква: ";
//  cin >> letter;
//  if (!isalpha(letter)) {
//    cout << "Не е буква";
//    exit(0);
//  }
//}
//
////bool IsVowel(char letter) {
////  return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
////}
//
//
//int main() {
//  system("chcp 1251 > null");
//  /*int a, b;
//
//  cout << "Въведете първото число: ";
//  cin >> a;
//
//  cout << "Въведете второто число: ";
//  cin >> b;*/
//
//  /*if (a > b) cout << "a е по-голямо";
//  else if (a < b) cout << "b е по-голямо";
//  else cout << "а и b са равни";*/
//  
// /*int max = a > b ? a : b;
//  if (a == b) cout << "Равни са";
//  else cout << "По-голямото число е " << max;*/
//
//  /*int max = Max(a, b);
//  if (a == b) cout << "Равни са";
//  else cout << "По-голямото число е " << max;*/
//
//  char letter;
//  /*cout << "Въведете буква: ";
//  cin >> letter;
//  if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
//    cout << "Гласна";
//  else cout<<"Съгласна";*/
//
//  input(letter);
//
//  letter = tolower(letter);
//
//  /*if (IsVowel(letter)) cout << "Гласна";
//  else cout << "Съгласна";*/
//
//  set <char> vowels = { 'a', 'e', 'i', 'o', 'u' };
//  if (vowels.find(letter) != vowels.end())
//    cout << "Гласна";
//  else cout << "Съгласна";
//}