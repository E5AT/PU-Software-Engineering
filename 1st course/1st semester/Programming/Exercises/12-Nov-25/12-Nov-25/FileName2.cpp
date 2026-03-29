//#include <iostream>
//using namespace std;
//
//void read(auto& a, int l, double min, double max) {
//  //-10 до 5
//  if (!a || l < 1) return;
//  cout << "Въведете масив от " << l << " числа:\n";
//  for (int i = 0; i < l; i++) {
//    cout << " за индекс " << i << "(от " << min << " до " << max << ")";
//    cin >> a[i];
//  }
//}
//
//void write(const double a[], int l) {
//  //извеждане на елементи
//  if (!a || l < 1) return;
//  for (int i = 0; i < l; i++) cout << a[i] << (i>l-2?"\n" : ";");
//}
//
//int countGreaterThan(const double a[], int l, double max) {
//  if (!a) return 0;
//  int count{};
//  for (int i{}; i < l; i++) if (a[i] < max) count++;
//  return count;
//}
//
//int main() {
//  system("chcp 1251 > null");
//  
//  const int len = 6;
//  double ar[len];
//
//
//  read(ar,len,-10,5);
//  
//  write(ar, len);
//
//  double max;
//  cout << "Гранична стойност: ";
//  cin >> max;
//  cout << "Брой на елементи под " << max << ":"<<countGreaterThan(ar,len,max);
//}