//Returns if a C-string meets designated requirements, 
//such as where the password has to be at least n number of characters, 
//have at least one digit, upper case letter and/or lower case letter, etc.

#include<iostream>
using namespace std;
bool isValid(char *arr);

int main () 
{
	char password[20];
	bool valid;
	cout << "Please enter your password." << endl
		<<"Passwords must be 8 to 16 characters long, have at least one digit," <<endl
		<< " one upper case letter and one lower case letter and consist of only " << endl
		<< "letters or digits: " << endl;
	cin >> password;
	valid = isValid(password);
	if(valid)					//isValid return true
		cout << "Thanks! Your new password is " << password << endl;
	else
		cout << "Error! the password you entered was not in the correct format!" << endl;
	
	return 0;
}

bool isValid(char Array[])
{
	int len = strlen(Array);
	bool hasDigit = false, hasLower = false, hasUpper = false;
	if(len >= 8 || len <= 16){					//if string len is more than 8 or less then 16
		for(int i = 0; i < len; i++) {
			if(isalnum(Array[i])){				//If char is a letter or number							
				if(isdigit(Array[i]))		
					hasDigit = true;
				if(islower(Array[i]))
					hasLower = true;
				if(isupper(Array[i]))
					hasUpper = true;
			}//if isalnum
			else
				return false;
		}//for
		if(hasDigit && hasLower && hasUpper)
			return true;
	}//if len 
	else 
		return false;
}