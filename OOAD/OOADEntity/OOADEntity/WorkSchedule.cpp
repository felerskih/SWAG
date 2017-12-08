#include "WorkSchedule.h"


bool WorkSchedule::ReadFile()
{
	string name = "";
	char day;
	char shift;
	string s = "";
	list<string> dummy;
	file.open(filename);
	if (!file)
	{
		cout << "Unable to find WorkSchedule.";
		return false;
	}

	while (file)
	{
		name = file.get();
		day = file.get();
		while (day != '\n')
		{
			shift = file.get();
			s = day + shift;
			dummy.push_back(s);			
			day = file.get();
		}
		schedule.insert(pair <string, list<string>> (name, dummy));
	}
	return true;
}