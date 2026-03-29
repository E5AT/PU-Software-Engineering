//#include <iostream>
//using namespace std;
//#include <iomanip>
//int m4in() {
//  system("chcp 1251 > nul");
//
//  //2.7
//  /*bool b = 0;
//  cout << "b -> " << b
//  << boolalpha << "b -> " << b << endl;
//  cout << "Въведете булева стойност като 1 или 0: ";
//  cin >> noboolalpha >> b;
//  cout << noboolalpha << "b -> " << b << endl
//  << boolalpha << "b -> " << b << endl;
//  cout << "Въведете булева стойност като true или false: ";
//  cin >> boolalpha >> b;
//  cout << noboolalpha << "b -> " << b << endl
//  << boolalpha << "b -> " << b << endl;*/
//
//  //2.8
//  //(x∨y)∧z∨x∧y∧¬z
//  //∨ - OR(||)
//  //∧ - AND(&&)
//  //¬ - NOT(!)
//  /*bool x, y, z;
//  cout << "Въведете три булеви стойности като true или false: ";
//  cin >> boolalpha >> x >> y >> z;
//  cout << boolalpha << "(" << x << " u " << y << ")n " << z << " u " << x << " n " << y << " n -" << z << " = "
//    << (x || y) && z || x && y && !z;*/
//
//  //2.9
//  /*char x, y, z;
//  cout << "Въведете три знака от тип char: ";
//  cin >> x >> y >> z;
//  cout << '\'' << z << "'  '" << y << "'  '" << x << "'" << endl;
//  cout << string(2, x) << endl
//    << string(4, y) << endl
//    << string(6, z) << endl;*/
//
//  //2.10
//  /*char x, y, z;
//  cout << "Въведете три знака от тип char: ";
//  cin >> x >> y >> z;
//  cout << "char с най-голям код: " << max(x, max(y, z)) << "\n"
//    << "char с най-малък код:" << min(x, min(y, z)) << endl;*/
//
//  //2.11
//  /*string str;
//  cout << "Въведете низ без бели полета: ";
//  cin >> str;
//  string line = string(2 + str.length(), '=');
//  cout << line << "\n\"" << str << "\"\n" << line << endl;*/
//
//  //11-Oct-25
//  //2.12
//  //short g = +32768; // това може,
//  // но +32768 е извън обхвата на short
//  // и съдържанието на паметта се интерпретира
//  // като код на числото -32768 (което е в обхвата на short)
//  //cout << "g -> " << g << endl; // тук g има стойност -32768
//  //short h{ 32767 }; // това може, защото е в обхвата на short
//  ///cout << "h -> " << h << endl;
//  //// не може short j{ 32768 }; // литералът е над максимума за short
//  //string s{ "12" + "34"s }; // литералите са от тип string
//  ////// плюсът е конкатенация на низовете
//  ////cout << s << endl;  
//  //cout << '|' << setw(6) << s << "|\n"
//  //  << left << '|' << setw(6) << s << "|\n"
//  //  << right << '|' << setw(6) << s << "|\n"
//  //  << left << '|' << setw(6) << s << "|"<<endl;
//  ////  // тук все още е валидно left
//  //cout<< '|' << setw(6) << s << "|\n";
//  //cout << string(8,  '=') << "\n\n";
//  //double d{ 12345.6789012345 };
//  ////cout << d << endl
//  ////  << fixed << d << endl
//  //////  // тук все още е валидно fixed
//  ////  << d << endl
//  ////  << scientific << d << endl
//  ////  << defaultfloat << d << "\n\n";
//  //d = 1e20;
//  //cout << d << endl // тук все още е валидно defaultfloat
//  //  << fixed << d << endl
//  //  << scientific << d << endl
//  ////  // тук все още е валидно scientific
//  //  << d << endl
//  //  << defaultfloat << d << "\n\n";
//
//  //2.13
//  /*string s1, s2;
//  cout << "Въведете два низа без бели полета: ";
//  cin >> s1 >> s2;
//  int length = max(s1.length(), s2.length()) + 2;
//  cout << setw(length) << "\"" + s1 + "\"" << endl;
//  cout << setw(length) << "\"" + s2 + "\"" << endl;*/
//  /*cout << "  d:\n";
//  const double d{ -123.4 };
//  cout << "d -> " << d << endl;
//  const_cast<double&>(d) = 9999.1;
//  cout << "d -> " << d << endl;
//  cout << "d -> " << const_cast<double&>(d) << endl;
//  cout << "  r:\n";
//  constexpr double r{ -123.4 };
//  cout << "r -> " << r << endl;
//  const_cast<double&>(r) = 9999.1;
//  cout << "r -> " << r << endl;
//  cout << "r -> " << const_cast<double&>(r) << endl;*/
////const string name = "Esat";
////cout << name << endl;
////const_cast<string&>(name) = "Enes";
////cout << name << endl;
// /*int x = 10;
// const int y = 20;
// constexpr int z = 30;
//
// int& refX = x;
// const int& refY = y;
// const int& refZ = z;
//
// cout << "x - " << x << endl;
// cout << "y - " << y << endl;
// cout << "z - " << z << endl;
//
// cout << "&x - " << refX << endl;
// cout << "&y - " << refY << endl;
// cout << "&z - " << refZ << endl;
//
// x = 999;
// const_cast<int&>(y) = 999;
// const_cast<int&>(z) = 999;
//
// cout << "x - " << x << endl;
// cout << "y - " << y << endl;
// cout << "z - " << z << endl;
//
// cout << "y - " << y << endl;
// cout << "z - " << z << endl;
//
// cout << "const_cast(y)" << const_cast<int&>(y) << endl;
// cout << "const_cast(z)" << const_cast<int&>(z) << endl;
//
// cout << "y - " << y << endl;
// cout << "z - " << z << endl;*/
// /*cout << "----- signed int -----\n"
//<< "брой байтове: " << sizeof(signed int) << endl
//<< "уникално име: " << typeid(signed int).name() << endl;
//cout << "----- int -----\n"
//<< "брой байтове: " << sizeof(int) << endl
//<< "уникално име: " << typeid(int).name() << endl;
//cout << "----- unsigned int -----\n"
//<< "брой байтове: " << sizeof(unsigned int) << endl
//<< "уникално име: " << typeid(unsigned int).name() << endl;
//cout << "----- unsigned -----\n"
//<< "брой байтове: " << sizeof(unsigned) << endl
//<< "уникално име: " << typeid(unsigned).name() << endl;
//cout << "----- long -----\n"
//<< "брой байтове: " << sizeof(long) << endl
//<< "уникално име: " << typeid(long).name() << endl;
//cout << "----- long long -----\n"
//<< "брой байтове: " << sizeof(long long) << endl
//<< "уникално име: " << typeid(long long).name() << endl;
//cout << "----- double -----\n"
//<< "брой байтове: " << sizeof(double) << endl
//<< "уникално име: " << typeid(double).name() << endl;
//cout << "----- long double -----\n"
//<< "брой байтове: " << sizeof(long double) << endl
//<< "уникално име: " << typeid(long double).name() << endl;
//cout << "----- int& -----\n"
//<< "брой байтове: " << sizeof(int&) << endl
//<< "уникално име: " << typeid(int&).name() << endl;
//string name = "Esat";
//cout << "----- Esat -----\n"
//<< "брой байтове: " << sizeof(name) << endl
//<< "уникално име: " << typeid(name).name() << endl;
//cout << "----- string -----\n"
//<< "брой байтове: " << sizeof(string) << endl
//<< "уникално име: " << typeid(string).name() << endl;
//
//cout << endl << boolalpha
//<< "is_fundamental_v<short> -> " << is_fundamental_v<short> << endl
//<< "is_fundamental_v<long double> -> " << is_fundamental_v<long double> << endl
//<< "is_fundamental_v<string> -> " << is_fundamental_v<string> << endl
//<< "is_fundamental_v<short&> -> " << is_fundamental_v<short&> << endl;*/
//  
//int num;
//cout << "Въведете едно число от тип int: ";
//cin >> num;
//cout << "Типът заема " << sizeof(num) << " байта място в паметта" << endl;
//cout << "Уникалното име на типа е: " << typeid(num).name() << endl;
//cout << "Типът " << (is_fundamental_v<decltype(num)>?"":"не") << "е фундаментален" << endl;
//
//string name;
//cout << "Въведете едно име: ";
//cin >> name;
//cout << "Типът заема " << sizeof(name) << " байта място в паметта" << endl;
//cout << "Уникалното име на типа е: " << typeid(name).name() << endl;
//cout << "Типът " << (is_fundamental_v<decltype(name)> ? "" : "не ") << "е фундаментален" << endl;
//}