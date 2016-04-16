/*
Name: Glendon Cheney
CSIT 836
Assignment 4
*/

#include "personlist.h"
#include<iostream>
using namespace std;

PersonList::PersonList(){
	head = NULL;
}

PersonList::~PersonList(){
	while (!IsEmpty())
	{
		PersonRec *currPtr = head;
		head = currPtr->link;
		delete currPtr;
	}
}

void PersonList::AddToList(){
	char aName[20];
	int aBribe;
	cout << "Enter the person's name: ";
	cin.getline(aName, 20);
	cout << "Enter the person's contribution: ";
	cin >> aBribe;

	PersonRec* newRec = new PersonRec;
	strcpy_s(newRec->name, 20, aName);
	newRec->bribe = aBribe;

	PersonRec *currPtr = head;

	if (IsEmpty())
		InsertFront(newRec);
	else if (newRec->bribe > currPtr->bribe)
		InsertFront(newRec);
	else 
	{
		Reset(currPtr);
		PersonRec* currentRecord = CurrRec(currPtr);
		bool end = EndOfList(currPtr);
		bool currentLarger = true, sameValue = false;

		while (currentLarger && !sameValue && !end)
		{
			currPtr = currPtr->link;
			currentRecord = CurrRec(currPtr);

			if (currentRecord->bribe < newRec->bribe)
				currentLarger = false;
			else if (currentRecord->bribe = newRec->bribe)
				sameValue = true;
			else 
				end = EndOfList(currPtr);
		}

		if (end || sameValue) 
			InsertAfter(newRec, currPtr);
		else 
			InsertBefore(newRec, currPtr);
	}
}

void PersonList::ViewList() {
	if (!IsEmpty()) 
	{
		PersonRec *currPtr = head;
		int num = 1;
		cout << endl << "# Name Contribution\n";
		cout << "=======================================\n" << endl;
		while (currPtr != NULL)
		{
			cout << num << " " << currPtr->name << " $" << currPtr->bribe << endl;
			num++;
			currPtr = currPtr->link;
		}
	}
	else 
		cout << "\nList is Empty\n";
}

bool PersonList::IsEmpty(){
	bool empty = false;
	if (head == NULL)
		empty = true;
	
	return empty;
}

bool PersonList::EndOfList(PersonRec *p){
	bool EOL = false;
	if (IsEmpty() || p->link == NULL)
		EOL = true;
	
	return EOL;
}

void PersonList::Reset(PersonRec *p) {
	p = head;
}

PersonRec* PersonList::PrevPtr(PersonRec *p){
	PersonRec* i = head;
	while (i->link != p)
		i = i->link;
	
	return i;
}

void PersonList::InsertFront(PersonRec* toInsert) {
	toInsert->link = head;
	head = toInsert;
}

void PersonList::InsertBefore(PersonRec* toInsert, PersonRec* location) {
	PersonRec* prev = PrevPtr(location);
	prev->link = toInsert;
	toInsert->link = location;
}

void PersonList::InsertAfter(PersonRec* toInsert, PersonRec* location) {
	toInsert->link = location->link;
	location->link = toInsert;
}

PersonRec* PersonList::CurrRec(PersonRec* p){
	PersonRec *rec = new PersonRec;
	rec->bribe = p->bribe;
	strcpy_s(rec->name, 20, p->name);

	return rec;
}
