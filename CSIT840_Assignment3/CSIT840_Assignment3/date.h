/*
Name:Glendon Cheney
Course: CSIT 840
Assignment#3
*/

//date.h
#include<iostream>
using namespace std;

class Date
{
private:
	int month, day, year;

public:
	Date();
	Date(const Date&);
	Date operator=(const Date&);
	friend Date operator-(Date, Date);
	friend bool operator>(Date, Date);
	friend bool operator== (Date, Date);
	friend istream& operator>>(istream&, Date&);
	friend ostream& operator<<(ostream&, Date&);
};