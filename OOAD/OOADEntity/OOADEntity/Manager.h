#pragma once
#include "Dealer.h"
#include "Gambler.h"

class Manager
{
private:
	Gambler * flagged;

private:
	//Similar to Dealer's method, cannot complete at this time. Need the manager!!
	Message SendMessage(string m, string r);

	//What does this take?
	WorkSchedule CreatSchedule();
};