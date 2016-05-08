#include<string>
using namespace std;

class Student
{
	private:
		static int totalStudents; //private staic variables accessed through public static functions
		int studentNumber;
		string name;
		float gpa;
		bool isValidGPA(float);//private helper function declaration
	public:
		Student();				//no-arg Constructor
		Student(string, float); //two-arg construstor
		void getValues();
		void setValues();
		static int getTotalStudents();
};