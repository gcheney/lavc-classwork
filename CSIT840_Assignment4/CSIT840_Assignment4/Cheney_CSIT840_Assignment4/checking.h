/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//checking.h

#ifndef CHECKING_H
#define CHECKING_H
#include"account.h"

class Checking : public Account
{
private:
	bool overdraftProtection;

public:
	Checking();
	Checking(Customer, double, bool);
	void makeDeposit(double);
	bool makeWithdrawal(double);
	void adjustBalance();
	void view();
};
#endif