/*
Name:Glendon Cheney
Course: CSIT 840
Assignment#3
*/

//date.cpp
#include<iostream>
using namespace std;
#include"date.h"


Date::Date() {
	day = 1;
	month = 1;
	year = 2001;
}

Date::Date(const Date& d) {
	day = d.day;
	month = d.month;
	year = d.year;
}

Date operator-(Date a, Date b){
	const int daysOfMonth[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	int monthsA = 0, monthsB = 0, yearDiff = 0, monthDiff = 0, dayDiff = 0;

	//Calculate total of days in each month for each date
	for (int i = 0; i < a.month-1; i++){
		monthsA += daysOfMonth[i];
	}

	for (int i = 0; i < b.month-1; i++){
		monthsB += daysOfMonth[i];
	}

	//Add totals and find difference
	int totalA = (a.year * 365) + monthsA + a.day;
	int totalB = (b.year * 365) + monthsB + b.day;
	int totalDifference = totalA - totalB;

	//calculate the date of the difference
	yearDiff = totalDifference / 365;
	totalDifference -= yearDiff*365;
	
	int	month = b.month-1;

	while (totalDifference / daysOfMonth[month] != 0){
		monthDiff++;
		totalDifference -= daysOfMonth[month];
		if (month == 11) {
			month = 0;
		}
		else {
			month++;
		}
	}
	
	dayDiff = totalDifference;

	Date difference; //new Date object: To be returned

	difference.year = yearDiff;
	difference.month = monthDiff;
	difference.day = dayDiff;

	return difference;
}

bool operator >(Date a, Date b){
	bool greaterThan = false;

	if (a.year > b.year) {
		greaterThan = true;
	}
	else if (a.year == b.year) 
	{
		if (a.month > b.month) {
			greaterThan = true;
		}
		else if (a.month == b.month) 
		{
			if (a.day > b.day) {
				greaterThan = true;
			}
		}
	}

	return greaterThan;
}

bool operator==(Date a, Date b){
	bool sameDate = false;
	if (a.day == b.day && a.month == b.month && a.year == b.year)
		sameDate = true;

	return sameDate;
}

Date Date::operator=(const Date& d) {
	day = d.day;
	month = d.month;
	year = d.year;
	return *this;
}

istream& operator>>(istream& strm, Date& p){
	cout << "Enter month (1-12): ";
	strm >> p.month;
	cout << "Enter day (1 to maximum days in month): ";
	strm >> p.day;
	cout << "Enter year (>= 1800): ";
	strm >> p.year;

	return strm;
}

ostream& operator<<(ostream& strm, Date& p){
	strm << p.month << "/" << p.day << "/" << p.year;
	return strm;
}

