/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//account.cpp

#include "account.h"
#include<iostream>
using namespace std;

Account::Account() : cust() {
	balance = 0;
}

Account::Account(double b, Customer c) {
	balance = b;
	cust = c;
}

void Account::makeDeposit(double deposit){
	balance += deposit;
}

bool Account::makeWithdrawal(double withdrawal) {
	balance -= withdrawal;

	return true;
}

double Account::getBalance(){
	return balance;
}

void Account::view() {
	cust.view();
	cout << "Balance: $ " << balance << endl;
}