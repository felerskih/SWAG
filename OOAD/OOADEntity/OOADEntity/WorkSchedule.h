#pragma once
#include <fstream>
#include <iostream>
#include <map>
#include <list>
#include <iterator>
using namespace std;

//STL container?
class WorkSchedule
{
private:
	string filename = "dummySchedule.txt"; //whatever the file name is
	fstream file;
	map<string, list<string>> schedule;
	

public:
	WorkSchedule();
	bool ReadFile();

};