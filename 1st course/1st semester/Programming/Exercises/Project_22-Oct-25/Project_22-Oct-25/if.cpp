//#include <iostream>
//#include <cmath>
//using namespace std;
//
//int main() {
//  system("chcp 1251 > nul");
//  /*int ar[][3]{ {1,2},{3,4},{} };
//  if (auto [a, b]:ar) cout << a << "   " << b << endl;*/
//
//  int i{ 10 }, j{ 200 };
//  /*if (i == 10)
//    if (j == 20)
//    else cout<<"";*/
//
//  /*cout << "3*i+j = " << 3 * i + j << endl;
//  if (int n{ 3 * i + j }; n % 2 == 1) cout << n << " нечетно положително";
//  else if (n % 2 == -1) cout << "нечетно отрицателно";
//  else if (n == 0) cout << "нула";
//  else cout << "четно, различно от нула";*/
//
//  /*double x, y, z;
//  cout << "Три числа: ";
//  cin >> x >> y >> z;
//  if (x > y) swap(x, y);
//  if (x > z) swap(x, z);
//  if (y > z) swap(y, z);
//  cout << x << "<=" << y << "<=" << z;*/
//
//  /*int n;
//  do
//    cout << "Четно число от -5 до 15: ", cin >> n;
//  while (n % 2 || n<-5||n>15);
//
//  do cout << (n += 2)<<"   ";
//  while (n < 30);
//  cout << endl << string(30, '=') << endl;
//
//  n = 10;
//  do {
//    if (++n & 2) continue;
//    if (n > 30) break;
//    cout << n << "   ";
//  } while (true);*/
//
//  //double a, max{ };
//  //bool first = true;
//  //do {
//  //  cout << "Въведете число: ";
//  //  cin >> a;
//  //  if (first || a > max) { max = a; first = false; }
//  //  //max = a > max ? a : max ;
//  //} while (a);
//  //cout << "Най-голямо число: " << max << endl;
//
//  /*long long firstOdd{ }, last;
//  int numberEven{};
//  do {
//    cout << "Въведете число: ";
//    cin >> last;
//    if (last % 2 == 0) ++numberEven;
//    else if (firstOdd == 0) firstOdd = last;
//  } while (last % 2 == 0 || firstOdd == last);
//  cout << "Брой четни: " << numberEven << endl <<
//          "Различни нечетни:" << firstOdd << ", " << last << endl;*/
//
//  int n, countNegative{ }, countPositive{ }, minNegative{};
//  do {
//    cout << "Въведете число от 2 до 6: ";
//    cin >> n;
//  } while (n < 2 || n > 6);
//
//  while (n!=countNegative)
//  {
//    double num;
//    cout << "Въведете число: ";
//    cin >> num;
//    if (num > 0) {
//      countPositive++;
//      countNegative = 0;
//    }
//    if(num < 0) {
//      countNegative++;
//      if (minNegative > num) minNegative = num;
//    }
//  }
//
//  cout << "Брой положителни: " << countPositive<<endl;
//  cout << "Минимално отрицателно: " << minNegative << endl;
//}