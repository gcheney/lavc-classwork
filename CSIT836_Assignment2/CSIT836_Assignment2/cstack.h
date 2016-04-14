/*
Name: Glendon Cheney
CSIT 836
Assignment #2
*/

class CStack {
	public:
		CStack();//constructor
		void Push(char);
		void Pop();
		char Top();
		bool isEmpty();
		bool isFull();

	private:
		int top;
		char data[21];
};	