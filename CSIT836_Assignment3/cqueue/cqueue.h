/*
Name: Glendon Cheney
CSIT 836
Assignment #3
*/

const int MAX = 4;  //To do: determine appropriate number

struct Passenger {
	char name[80];
};

class CQueue {
private:
	int front;
	int rear;
	Passenger passengers[MAX];

public:
	CQueue();
	bool IsEmpty(void);
	bool IsFull(void);
	void Enqueue(Passenger);
	Passenger Front(void);
	void Dequeue(void);
};


