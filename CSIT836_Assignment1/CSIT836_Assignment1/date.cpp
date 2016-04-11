/*
Name: Glendon Cheney
Class: CSIT 836
Assignment #1
*/

#include<iostream>
using namespace std;
#include"date.h";

void Date::setDate(int m, int d, int y) {
	if (m >= 1 && m <= 12 && d >= 1 && d <= 31 && y >= 1900 && y <= 2008) {
		month = m;
		day = d;
		year = y;
	}
	else 
	{
		month = 9;
		day = 2;
		year = 2008;
	}
}

void Date::printDate() {
	cout << month << "/" << day << "/" << year << endl;
}