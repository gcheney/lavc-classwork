/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//savings.h

#ifndef SAVINGS_H
#define SAVINGS_H
#include"account.h"

class Savings : public Account 
{
private :
	double interestRate;

public:
	Savings();
	Savings(Customer, double, double);
	void makeDeposit(double);
	bool makeWithdrawal(double);
	void adjustBalance();
	void view();
};
#endif