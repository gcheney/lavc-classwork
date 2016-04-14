/*
Name: Glendon Cheney
CSIT 836
Assignment #2
*/

#include"cstack.h"
#include<iostream>
using namespace std;

CStack::CStack(){
	top = -1;
	for (int i = 0; i < 21; i++)
		data[i] = 0;
}

bool CStack::isEmpty() {
	return top == -1;
}

bool CStack::isFull(){
	return top == 20;
}

void CStack::Push(char c){
	if (!isFull()){
		data[top + 1] = c;
		top++;
	}
	else
		cout << "Cannot complete operation. The stack is full.\n";
}

void CStack::Pop(){
	if (!isEmpty())
		top--;
	else
		cout << "Cannot complete operation. The stack is empty.\n";
}

char CStack::Top(){
	if (!isEmpty())
		return data[top];
	else
		cout << "Cannot complete operation. The stack is empty.";
}