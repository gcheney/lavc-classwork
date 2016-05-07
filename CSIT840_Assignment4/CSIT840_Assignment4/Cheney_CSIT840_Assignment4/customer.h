/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//customer.h

#ifndef CUSTOMER_H
#define CUSTOMER_H
#include<string>
using namespace std;

class Customer
{
private:
	string accountID;
	string name;

public:
	Customer();
	Customer(string, string);
	void view();
	Customer operator=(const Customer&);
};
#endif