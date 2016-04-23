/*
Name:Glendon Cheney
Course: CSIT 840
Assignment#2
*/


#include"toll.h"
#include<iostream>
#include<iomanip>
using namespace std;

void inputCourseData(TollBooth*, int);
void outputCourseInfo(TollBooth*, float&);
void displayAvgToll(float);

int main(){
	int maxCourses;			//input for memory allocation
	float totalTollAmt = 0; //calculated for all courses
	cout << "How many courses maximum? ";
	cin >> maxCourses;
	TollBooth* tboothPtr;
	tboothPtr = new TollBooth[maxCourses];

	inputCourseData(tboothPtr, maxCourses);
	outputCourseInfo(tboothPtr, totalTollAmt);
	displayAvgToll(totalTollAmt);

	delete[] tboothPtr; 
	return 0;
}

void inputCourseData(TollBooth* tb, int numCourses){
	bool initCourse = true;
	char createCourse;
	int i = 0, totalStus = 0, payStus = 0;

	while (initCourse && i < numCourses) {
		bool isValid = false;
		cout << "Enter 'y' to initialize a new course; and other character to quit ";
		cin >> createCourse;

		if (createCourse == 'y'){
			cout << "For course " << i + 1 << ":\n";
			while (!isValid){
				cout << "How many students entered the room? ";
				cin >> totalStus;
				cout << "How many students paid? ";
				cin >> payStus;
				if (totalStus >= payStus){
					isValid = true;
					tb[i].setCourseData(totalStus, payStus);
				}
				else {
					cout << "***Invalid input: more paying than entered!***\n";
				}
			}	 //end isValid while loop
			i++; //increment i
		}		//end ctreateCourse if statement
		else 
			initCourse = false;
	} // end initCourse while loop
}

void outputCourseInfo(TollBooth* tb, float& totalToll) {
	int numCourse = TollBooth::getCourseCount();

	if (numCourse == 0)
		cout << "No actual courses\n" << endl;
	else
	{
		for (int i = 0; i < numCourse; i++){
			float tollAmt = tb[i].getTollAmt();
			totalToll += tollAmt;
			cout << "For course " << i + 1 << ": \n";
			cout << tb[i].getTotalStus() << " students are in the course\n";
			cout << "The toll collected is $" << fixed << setprecision(2) << tollAmt << endl;
			cout << tb[i].getDeadbeatStus() << " students didn't pay\n";
		} //end for loop
	}	//end numCourse else statement
}

void displayAvgToll(float totalToll){
	int nCourses = TollBooth::getCourseCount();
	if (nCourses > 0){
		float avgToll = totalToll / nCourses;
		cout << "The average toll per course is: $" << fixed << setprecision(2) << avgToll << endl << endl;
	}
}