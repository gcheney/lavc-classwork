/*
Name:Glendon Cheney
Course: CSIT 840
Assignment#3
*/

//test.cpp
#include "date.h"
#include <iostream>
using namespace std;

int main()
{
	Date date1;
	Date date2 = date1; //copy constructor called

	cout << "Initial date values\n";
	cout << "Date 1 is ";
	cout << date1 << endl;
	cout << "Date 2 is ";
	cout << date2 << endl;
	cout << "Enter a date no earlier than 1800\n";
	cin >> date1;
	cout << "Enter another date no earlier than 1800\n";
	cin >> date2;
	cout << "Revised date values\n";
	cout << "Date 1 is ";
	cout << date1 << endl;
	cout << "Date 2 is ";
	cout << date2 << endl;

	if (date1 == date2)
		cout << "The two input dates are the same\n";
	else if (date1 > date2)
	{
		cout << "Date 1 is later in time than Date 2 by ";
		Date temp = date1 - date2;
		cout << temp << endl;
	}
	else
	{
		cout << "Date 2 is later in time than Date 1 by ";
		Date temp = date2 - date1;
		cout << temp << endl;
	}

	Date date3, date4;
	date4 = date3 = date2; //overloaded assignment operator called
	cout << "After the assignment date4 = date3 = date2\n";
	cout << " Date 3 is " << date3 << " and Date 4 is " << date4 << endl;
	return 0;
}
