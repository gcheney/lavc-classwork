/*
Name: Glendon Cheney
Class: CSIT 840
Assignment #1
*/

#include<iostream>
using namespace std;
#include"date.h";

Date::Date(int m, int d, int y)
{
	if (isValidDate(m, d, y)){
		month = m;
		day = d;
		year = y;
	}
	else {
		month = 1;
		day = 1;
		year = 2001;
	}
}

bool Date::isValidDate(int mon, int dy, int yr) {
	bool isValid = true;

	if (mon < 1 || mon > 12)
		isValid = false;
	else if (dy < 1 || dy > monthDays[mon - 1])
		isValid = false;
	else if (yr < MIN_YEAR || yr > MAX_YEAR)
		isValid = false;
	
	return isValid;
}

void Date::printDate(DateFormat df) {
	string mo = monthSTR[month-1] + " ";

	if (df == numeric) 
		cout << month << "-" << day << "-" << year << endl;
	else if (df == standard)
		cout << mo << day << ", " << year << endl;
	else if (df == alternative)
		cout << day << " " << mo << year << endl;
}