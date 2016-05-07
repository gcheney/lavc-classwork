#include<iostream>
#include<string>
#include "student.h"
using namespace std;

void Student::setvalues(){
	cout << "Enter the student name: ";
	getline(cin, name);
	cout << "Enter the student gpa: ";
	cin >> gpa;
	cin.ignore();
	
}

void Student::getvalues(){
	cout << "Student name is " << name << " and their GPA is " << gpa << endl; 
}