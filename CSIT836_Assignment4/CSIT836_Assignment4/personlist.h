/*
Name: Glendon Cheney
CSIT 836
Assignment 4
*/

#ifndef PERSON_H
#define PERSON_H

struct PersonRec {
	char name[20];
	int bribe;
	PersonRec* link;
};

class PersonList {

public:
	PersonList();
	~PersonList();
	void ViewList();
	void AddToList();

private:
	PersonRec* head;
	bool IsEmpty();
	bool EndOfList(PersonRec*);
	void Reset(PersonRec*);
	PersonRec* PrevPtr(PersonRec*);
	void InsertFront(PersonRec*);
	void InsertBefore(PersonRec*, PersonRec*);
	void InsertAfter(PersonRec*, PersonRec*);
	PersonRec* CurrRec(PersonRec*);
};
#endif