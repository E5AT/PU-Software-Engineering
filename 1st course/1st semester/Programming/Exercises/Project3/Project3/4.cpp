//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//  system("chcp 1251 > null");
//
//	int last, prev, count{}, sumNeg{}, countNeg{}, maxDiv3{ INT_MIN }, countDiv3{}, maxNum, minNum, countBigger10{};
//
//	do
//	{
//		cout << "Въведете число: "; cin >> last;
//		++count;
//
//		if (count == 1) maxNum = minNum = last;
//		else {
//			maxNum = max(maxNum, last);
//			minNum = min(minNum, last);
//		}
//
//		if (last < 0) sumNeg += last, ++countNeg;
//
//		if (last % 3 == 0) maxDiv3 = max(maxDiv3, last), ++countDiv3;
//
//		if (last > 10) ++countBigger10;
//
//		if (count>1)
//			if (prev == last) break;
//
//		prev = last;
//
//	} while (true);
//
//	cout << "Брой числа: " << count << endl;
//
//	if (countNeg) cout << "Средно на отрицателните: " << (double)sumNeg / countNeg << endl;
//	else cout << "Няма отрицателни числа!" << endl;
//
//	if (countDiv3 && maxDiv3 != INT_MIN) cout << "Максимално, кратно на 3: " << maxDiv3 << endl;
//	else cout << "Няма кратно на 3!" << endl;
//
//	cout << "Разликата между най-голямото и най-малко число: " << maxNum - minNum << endl;
//
//	cout << "Процент по-големи 10: " << fixed << setprecision(4) << ((double)countBigger10 / count) * 100 << " %" << endl;
//
//}