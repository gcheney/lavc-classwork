#include<iostream>
#include<string>
using namespace std;

class Student
{
	//declare private member variables
	private:
		string name;
		float gpa;

	//Declare public member functions
	public:
		//call 'setter' function to set the values
		void setValues() {						
			cout << "Enter the students name: ";
			getline(cin, name);
			cout << "Enter GPA: ";
			cin >> gpa;
			cin.ignore();
		}
		//call 'getter' functions to get, or return, the values
		string getName(){						
			string sName = "Student's name is " + name
				+ " and GPA is ";
			return sName;
		}

		float getGPA(){
			return gpa;
		}
};

int main() {
	Student s1;					//Create a new Student Object
	s1.setValues();				//call the setValues function on s1
	cout << "Outputting the student data...\n";
	string s = s1.getName();	//Save the return from getName;
	float gpa = s1.getGPA();	//Save the return from getGPA
	cout << s << gpa << endl;	//Output values together;
	return 0;					//return 0 to end program
}	