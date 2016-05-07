/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//checking.cpp

#include"checking.h"
#include<iostream>
using namespace std;

Checking::Checking(){
	overdraftProtection = false;
}

Checking::Checking(Customer c, double b, bool overdraft) : Account(b, c){
	overdraftProtection = overdraft;
}

void Checking::makeDeposit(double deposit){
	Account::makeDeposit(deposit);
}

bool Checking::makeWithdrawal(double withdrawal){
	bool withdrawMade = true;
	double currBalance = Account::getBalance();

	if ((currBalance - withdrawal) > 0 || overdraftProtection)
		Account::makeWithdrawal(withdrawal);
	else
		withdrawMade = false;

	return withdrawMade;
}

void Checking::adjustBalance(){
	const int serviceCharge = 10;
	const int minBalance = 1000;
	double currBal = Account::getBalance();

	if (currBal < minBalance)
		makeWithdrawal(serviceCharge);	
}

void Checking::view(){
	cout << "Checking Account: " << endl;
	Account::view();
}