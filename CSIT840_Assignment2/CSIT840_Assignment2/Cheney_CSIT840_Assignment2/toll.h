/*
Name:Glendon Cheney
Course: CSIT 840
Assignment#2
*/

using namespace std;

const float toll = .5;

class TollBooth
{
private:
	int m_nPayingStus, m_nDeadbeatStus;
	static int m_nCourseCount;

public:
	TollBooth();
	void setCourseData(int, int);
	int getTotalStus();
	int getDeadbeatStus();
	static int getCourseCount();
	float getTollAmt();
};