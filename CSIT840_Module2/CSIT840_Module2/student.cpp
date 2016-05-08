#include<iostream>
using namespace std;
#include"student.h";

int Student::totalStudents = 0; //initialize outside constructor to keep as a counter

//no-argument constructor
Student::Student() :name("Youngjae Lee"), gpa(4.0) { 
	totalStudents++; 
	studentNumber = totalStudents; 
}

//two-argument constructor
Student::Student(string n, float grade) {
	totalStudents++;
	studentNumber = totalStudents;
	name = n;
	if (isValidGPA(grade))
		gpa = grade;
	else
		gpa = 0.0;
}

void Student::setValues(){
	cin.ignore();
	cout << "Enter the student's name: ";
	getline(cin, name);
	cout << "Enter GPA: ";
	cin >> gpa;
	if (!isValidGPA(gpa))
		gpa = 0.0;
}

void Student::getValues() {
	cout << "Student #" << studentNumber << "s name is " << name
		<< " and their GPA is " << gpa << endl;
}

bool Student::isValidGPA(float f) {
	if (f >= 0 && f <= 4)
		return true;
	else 
		return false;
}

int Student::getTotalStudents(){
	return totalStudents;
}
