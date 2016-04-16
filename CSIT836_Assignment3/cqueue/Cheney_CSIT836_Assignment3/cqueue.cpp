/*
Name: Glendon Cheney
CSIT 836
Assignment #3
*/

#include"cqueue.h"
#include<iostream>
using namespace std;

CQueue::CQueue(void) {
	front = MAX - 1;
	rear = MAX - 1;
	MAXCHAR = 40;
	word = new char[MAX];
	for (int i = 0; i < 21; i++)
		word[i] = 0;
}

CQueue::CQueue(int max){
	front = MAX - 1;
	rear = MAX - 1;
	MAXCHAR = max;
	for (int i = 0; i < MAX; i++){
		passengers[i].name = new char[MAXCHAR];
		for (int j = 0; j < 80; j++){
			passengers[i].name[j] = ' ';
		}
	}
}

CQueue::~CQueue() {
	for (int i = 0; i < MAX; i++) {
		delete[] passengers[i].name;
	}
}

bool CQueue::IsEmpty(void) const{
	return front == rear;
}

bool CQueue::IsFull(void) const{
	if ((rear + 1) % MAX == front)
		return true;
	else
		return false;
}

void CQueue::Enqueue(Passenger p){
	rear = (rear + 1) % MAX;
	passengers[rear] = p;
}

Passenger CQueue::Front(void){
	Passenger frontP = passengers[(front + 1) % MAX];
	return frontP;
}

void CQueue::Dequeue(void){
	front = (front + 1) % MAX;
}

void CQueue::MakeEmpty(void) {
	front = MAX - 1;
	rear = MAX - 1;
}