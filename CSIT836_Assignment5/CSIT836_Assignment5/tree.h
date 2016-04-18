/*
Name: Glendon Cheney
CSIT 836
Assignment 5
*/
//tree.h

#ifndef TREE_H
#define TREE_H

struct PersonRec {
	char name[20];
	int bribe;
	PersonRec* lChild;
	PersonRec* rChild;
	//4-arg constructor
	PersonRec(char* n, int b, PersonRec* left, PersonRec* right) 
	{ 
		strcpy_s(name, sizeof(name), n);
		bribe = b;
		lChild = left;
		rChild = right;
	}
};

class CTree {

public:
	CTree();
	~CTree();
	void View();
	void Add();

private:
	PersonRec* root;
	bool isEmpty();
	bool isFull();
	void BuildRoot(char*, int);
	void AddItem(PersonRec*&, char*, int);
	void DisplayTree(PersonRec*);
	void DeleteTree(PersonRec*&);
};
#endif