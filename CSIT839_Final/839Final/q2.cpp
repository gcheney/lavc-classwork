/*
Name:Glen Cheney
Class: CSIT 839
Final Exam Question #2
*/

#include<iostream>
using namespace std;

struct Info {
	int pos;
	int neg;
	Info()
   {
      pos = 0;
      neg = 0;
   }
};

void inputArray (float[], int);
void calcPosNeg (float*, Info*, int);
void displayPosNeg (Info);

int main()
{
	int size;
	Info inf;
	float *arr;
	cout << "Enter number of elements of array: ";
	cin >> size;
	arr = new float[size]; 
	inputArray(arr, size);
	calcPosNeg(arr, &inf, size);
	displayPosNeg(inf);
	return 0;
}

void inputArray (float val[], int s)
{
	for (int i = 0; i < s; i++)
	{
	  cout << "Enter value: ";
	  cin >> val[i];
	}
}

void calcPosNeg (float* val, Info* in, int s)
{
	int p = 0, n = 0;
	for (int i = 0; i < s; i++)
	{
	  if (val[i] > 0)
		  p += 1;
	  else if (val[i] < 0)
		  n += 1;
	}
	in->pos = p;
	in->neg = n;
}

void displayPosNeg(Info i)
{
	cout << "Array has " << i.pos << " positive numbers and " << i.neg << " negative numbers\n" << endl;
}