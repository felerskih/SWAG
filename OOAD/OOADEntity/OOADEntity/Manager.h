#pragma once
#include "Dealer.h"
#include "Gambler.h"

class Manager
{
private:
	Gambler * flagged;

private:
	//Similar to Dealer's method, cannot complete at this time.
	Message SendMessage(string m, string r);

	//Find username in file and load in corresponding messages
	bool LoadMessages(Message);

	//What does this take?
	WorkSchedule CreatSchedule();

	//TODO
	WorkSchedule Checkschedule();
};