/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//savings.cpp

#include"savings.h"
#include<iostream>
using namespace std;

Savings::Savings(){
	interestRate = 0;
}

Savings::Savings(Customer c, double b, double rate) : Account(b, c){
	interestRate = rate;
}

void Savings::makeDeposit(double deposit){
	Account::makeDeposit(deposit);
}

bool Savings::makeWithdrawal(double withdrawal){
	bool withdrawMade = true;
	double currBalance = Account::getBalance();

	if ((currBalance - withdrawal) < 0)
		withdrawMade = false;
	else
		Account::makeWithdrawal(withdrawal);

	return withdrawMade;
}

void Savings::adjustBalance(){
	double currBalance = Account::getBalance();
	double interestAmt = currBalance*interestRate;
	makeDeposit(interestAmt);
}

void Savings::view(){
	cout << "Savings Account: " << endl;
	Account::view();
}