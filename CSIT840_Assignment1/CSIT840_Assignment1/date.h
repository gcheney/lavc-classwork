/*
Name: Glendon Cheney
Class: CSIT 840
Assignment #1
*/

#include<string>
using namespace std;

enum DateFormat{numeric, standard, alternative};
const int MIN_YEAR = 1900;
const int MAX_YEAR = 2015;
const string monthSTR[] = { "January", "Febuary", "March", "April", "May",
"June", "July", "August", "September", "October", "November", "December" };
const int monthDays[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

class Date
{
	private:
		int month, day, year;
		bool isValidDate(int, int, int);
	public:
		Date(int, int, int);
		void printDate(DateFormat);
};