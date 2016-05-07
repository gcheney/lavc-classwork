/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//customer.cpp

#include<iostream>
#include<string>
using namespace std;
#include"customer.h"


Customer::Customer() {
	accountID = "";
	name = "";
}

Customer::Customer(string n, string ID) {
	accountID = ID;
	name = n;
}

void Customer::view() {
	cout << "Name: " << name << endl;
	cout << "Account #: " << accountID << endl;
}

Customer Customer::operator=(const Customer& cust) {
	accountID = cust.accountID;
	name = cust.name;
	return *this;
}

