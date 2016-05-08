#include<iostream>
#include<string>
using namespace std;
#include"student.h";
void setValues(string&, float&);

int main() {
	string name;
	float gpa;
	int numStudents;

	setValues(name, gpa);
	Student s1(name, gpa);
	cout << "Outputing data...\n";
	s1.getValues();
	cout << endl;

	cout << "Enter the remaining number of Students: ";
	cin >> numStudents;
	Student* students = new Student[numStudents];

	for (int i = 0; i < numStudents; i++) 
		students[i].setValues();
	for (int i = 0; i < numStudents; i++)
		students[i].getValues();

	cout << "There are now " << Student::getTotalStudents() << " students\n" << endl;
	delete[] students;
	return 0;
}

void setValues(string& n, float& f){
	cout << "Enter the student's name: ";
	getline(cin, n);
	cout << "Enter GPA: ";
	cin >> f;
}
