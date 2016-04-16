/*
Name: Glendon Cheney
CSIT 836
Assignment #3
*/

using namespace std;
#include"cqueue.h"

CQueue::CQueue(){
	front = MAX - 1;
	rear = MAX - 1;
	for (int i = 0; i < MAX; i++){
		for (int j = 0; j < 80; j++){
			passengers[i].name[j] = ' ';
		}
	}
}

bool CQueue::IsEmpty(void){
	bool empty;

	if (front == rear)
		empty = true;
	else
		empty = false;

	return empty;
}

bool CQueue::IsFull(void){
	bool full;

	if ((rear + 1) % MAX == front)
		full = true;
	else
		full = false;

	return full;
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