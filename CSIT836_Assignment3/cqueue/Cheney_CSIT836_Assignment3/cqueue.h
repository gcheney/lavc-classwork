
#ifndef CQUEUE_H
#define CQUEUE_H
const int MAX = 4;  //To do: determine appropriate number

struct Passenger {
	char* name;
};

class CQueue {
private:
	int front;
	int rear;
	int MAXCHAR;
	Passenger passengers[MAX];

public:
	CQueue();
	CQueue(int);
	~CQueue();
	bool IsEmpty(void) const;
	bool IsFull(void) const;
	void Enqueue(Passenger);
	Passenger Front(void);
	void Dequeue(void);
	void MakeEmpty(void);
};
#endif

