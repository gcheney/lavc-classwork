/*
Name:Glendon Cheney
CSIT 840
Assignment #4
*/
//test.cpp

#include <iostream>
#include<string>
using namespace std;
#include "account.h"
#include "checking.h"
#include "savings.h"
const int MAX = 4;
void doTransactions(Account*);

int main()
{
	Account* acctsPtr[MAX];
	char acctType;
	bool validType = true;
	string custName;			//char custName[NAME_SIZE];  
	string acctID;				//char acctID[ID_SIZE];    
	double startBal;

	int aNum;
	for (aNum = 0; aNum < MAX && validType; aNum++)
	{
		cout << "Enter c for checking; s for savings; any other character to quit: ";
		cin >> acctType;
		acctType = tolower(acctType);

		if (acctType == 'c' || acctType == 's')
		{
			cout << "Enter customer name: ";
			cin >> custName;
			cout << "Enter account number: ";
			cin >> acctID;
			cout << "Enter account beginning balance: ";
			cin >> startBal;

		}

		switch (acctType)
		{
			case 'c':
			{
					char response;
					bool overdraftOk;
					cout << "Does this account have overdraft protection? ";
					cin >> response;
					overdraftOk = (tolower(response) == 'y') ? true : false;
					Customer c(custName, acctID);
					acctsPtr[aNum] = new Checking(c, startBal, overdraftOk);
					doTransactions(acctsPtr[aNum]);
					acctsPtr[aNum]->adjustBalance();
					cout << "Balance after service charge (if any): " <<
						acctsPtr[aNum]->getBalance() << endl;
					break;
			}

			case 's':
			{
					double intRate;
					cout << "Enter current monthly interest rate: ";
					cin >> intRate;
					Customer c(custName, acctID);
					acctsPtr[aNum] = new Savings(c, startBal, intRate);
					doTransactions(acctsPtr[aNum]);
					acctsPtr[aNum]->adjustBalance();
					cout << "Balance after interest: " <<
						acctsPtr[aNum]->getBalance() << endl;
					break;
			}

			default:
				validType = false;
				aNum--;
				break;
		}
	}

	int totalAccts = aNum;
	cout << "\nAccounts:\n";
	for (int i = 0; i < totalAccts; i++)
	{
		acctsPtr[i]->view();
		cout << "\n";
	}

	for (int i = 0; i < totalAccts; i++)
		delete acctsPtr[i];
}

void doTransactions(Account * aPtr)
{
	double depAmt, withdAmt;

	cout << "Enter total deposits: ";
	cin >> depAmt;
	aPtr->makeDeposit(depAmt);
	cout << "Balance after deposits: "
		<< aPtr->getBalance() << endl;

	cout << "Enter total withdrawals: ";
	cin >> withdAmt;
	if (aPtr->makeWithdrawal(withdAmt))
		cout << "Balance after withdrawals: "
		<< aPtr->getBalance() << endl;
	else
		cout << "Withdrawal not made -- balance too low\n"
		<< " and no overdraft protection\n";
}
