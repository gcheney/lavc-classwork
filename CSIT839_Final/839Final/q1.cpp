/*
Name:Glen Cheney
Class: CSIT 839
Final Exam Question #1
*/

#include<iostream>
using namespace std;
bool isValidUserName(char *arr);

int main()
{
	char name[80];
	bool result;
	cout << "Input user name: ";
	cin >> name;

	result = isValidUserName(name);
	if(result == true)
		cout << "User name is valid\n";
	else
		cout << "User name is not valid\n";
	return 0;
}

bool isValidUserName(char Array[])
{
	bool isValid = true;
	int len = strlen(Array);
	if(len >= 2 && len <= 10) {					
		for(int i = 0; i < len; i++) {
			if(isalnum(Array[i]) || Array[i] == '_'){										
				if(isdigit(Array[0]))		
					isValid = false;
				if(isupper(Array[i]))
					isValid = false;
			}
			else
				isValid = false;
		}
	}
	else 
		isValid = false;

	return isValid;
}