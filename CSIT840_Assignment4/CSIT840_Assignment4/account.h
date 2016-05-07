/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//account.h

#ifndef ACCOUNT_H
#define ACCOUNT_H
#include"customer.h"

class Account
{
private:
	double balance;
	Customer cust;

public:
	Account();
	Account(double, Customer);
	virtual void makeDeposit(double);
	virtual bool makeWithdrawal(double);
	double getBalance();
	virtual void view();
	virtual void adjustBalance() = 0;
};
#endif