/*
Name: Glendon Cheney
CSIT 836
Assignment #2
*/

#include"cstack.h"
#include<iostream>
#include<cstring>
using namespace std;

bool isValidExpression(CStack&, char*);

int main() {
	char expression[21];
	cout << "Enter an expression: ";
	cin >> expression;

	CStack stack1;
	
	if (isValidExpression(stack1, expression))
		cout << "It's a valid expression\n";
	else
		cout << "It's NOT a valid expression\n";

	return 0;
}

bool isValidExpression(CStack& stackA, char* strExp) {
	bool isValid = true;
	int numOpen = 0;

	for (int i = 0; i < 21; i++){
		if (strExp[i] == '{' || strExp[i] == '[' || strExp[i] == '(') {
			stackA.Push(strExp[i]);
			numOpen++;
		}
		else 
		{
			if (strExp[i] == '}')
			{
				if (stackA.Top() != '{')
					isValid = false;
				else {
					stackA.Pop();
					numOpen--;
				}
			}

			else if (strExp[i] == ']') 
			{
				if (stackA.Top() != '[')
					isValid = false;
				else {
					stackA.Pop();
					numOpen--;
				}
			}

			else if (strExp[i] == ')') 
			{
				if (stackA.Top() != '(')
					isValid = false;
				else {
					stackA.Pop();
					numOpen--;
				}
			}
		}
	}

	if (numOpen > 0)
		isValid = false;

	return isValid;
}