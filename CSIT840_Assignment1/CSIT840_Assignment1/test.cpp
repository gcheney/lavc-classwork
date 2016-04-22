/*
Name: Glendon Cheney
Class: CSIT 840
Assignment #1
*/

#include<iostream>
using namespace std;
#include"date.h";
void setDateValues(int&, int&, int&);

int main() {
	int mth, day, yr;
	setDateValues(mth, day, yr);
	Date date(mth, day, yr);
	cout << "Date is:\n";
	date.printDate(numeric);
	date.printDate(standard);
	date.printDate(alternative);
	return 0;
}

void setDateValues(int& m, int& d, int& y) {
	cout << "Enter month: ";
	cin >> m;
	cout << "Enter day: ";
	cin >> d;
	cout << "Enter year: ";
	cin >> y;
}