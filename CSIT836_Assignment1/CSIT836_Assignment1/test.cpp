/*
Name: Glendon Cheney
Class: CSIT 836
Assignment #1
*/

#include<iostream>
using namespace std;
#include"date.h";

int main()
{
	Date d1;
	int m, d, y;
	cout << "Enter month, day, and year seperated by spaces: ";
	cin >> m >> d >> y;
	d1.setDate(m, d, y);
	d1.printDate();
	return 0;
}