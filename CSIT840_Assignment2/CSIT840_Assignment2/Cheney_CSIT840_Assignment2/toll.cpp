/*
Name:Glendon Cheney
Course: CSIT 840
Assignment#2
*/

#include<iostream>
using namespace std;
#include"toll.h"

int TollBooth::m_nCourseCount = 0;

TollBooth::TollBooth() { 
	cout << "Now creating an uninitialized course element...." << endl;
}

void TollBooth::setCourseData(int t, int p){
	m_nPayingStus = p;
	m_nDeadbeatStus = t - p;
	m_nCourseCount++;
}

int TollBooth::getTotalStus(){
	int total = m_nPayingStus + m_nDeadbeatStus;
	return total;
}

int TollBooth::getDeadbeatStus(){
	return m_nDeadbeatStus;
}

int TollBooth::getCourseCount(){
	return m_nCourseCount;
}

float TollBooth::getTollAmt(){
	float tollAmount = m_nPayingStus*toll;
	return tollAmount;
}