/*
Name: Glendon Cheney
CSIT 836
Assignment 5
*/
//tree.cpp

#include<iostream>
using namespace std;
#include"tree.h"

CTree::CTree(){
	root = NULL;
}

CTree::~CTree(){
	DeleteTree(root);
}

void CTree::View(){
	if (!isEmpty()) {
		cout << endl << "Name Contribution\n";
		cout << "=======================================\n" << endl;
	}
	DisplayTree(root);
}

void CTree::Add(){
	char aName[40];
	int aBribe;
	cout << "Enter the person's name: ";
	cin >> aName; //assumes no embedded spaces
	cout << "Enter the person's contribution: ";
	cin >> aBribe;
	if (isEmpty())
		BuildRoot(aName, aBribe);
	else if (!isFull())
		AddItem(root, aName, aBribe);
}

bool CTree::isEmpty(){
	if (root == NULL)
		return true;
	else
		return false;
}

bool CTree::isFull(){
	PersonRec* temp;
	try
	{
		temp = new PersonRec("temp", 0, NULL, NULL);
		delete temp;
		return false;
	}
	catch (bad_alloc exception) 
	{
		return true;
	}
}

void CTree::BuildRoot(char* name, int bribe){
	root = new PersonRec(name, bribe, NULL, NULL);
}

void CTree::AddItem(PersonRec*& ptr, char* name, int bribe){
	if (ptr != NULL)
	{
		if (bribe > ptr->bribe) {
			AddItem(ptr->rChild, name, bribe);
		}
		else if (bribe < ptr->bribe) {
			AddItem(ptr->lChild, name, bribe);
		}
		else 
		{
			cout << "\nThis bribe amount has already been paid.\n";
			return;
		}
	}
	else //ptr == NULL
	{
		ptr = new PersonRec(name, bribe, NULL, NULL);
	}
}

void CTree::DisplayTree(PersonRec* ptr){
	if (isEmpty())
		cout << "\nList is empty\n";
	else 
	{
		if (ptr != NULL) {
			DisplayTree(ptr->rChild);
			cout << ptr->name << " $" << ptr->bribe << endl;
			DisplayTree(ptr->lChild);
		}
	}
}

void CTree::DeleteTree(PersonRec*& ptr) {
	if (ptr != NULL) {
		DeleteTree(ptr->lChild);
		DeleteTree(ptr->rChild);
		delete ptr;
	}
}