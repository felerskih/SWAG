#pragma once
#include "User.h"
#include "Gambler.h"
#include "Message.h"
#include "WorkSchedule.h"

class Dealer
{
private:
	string * shifts; //Possibly remove
public:
	//Needs a fix
	Message SendMessage(string m, string p);

	//2 + 2 is 4, minus is three quick maths - Andrew 12/7

	//Possible to get rid of
	bool ReceiveMessage(Message);

	//TODO
	Message FlagGambler();

	bool AddFunds(float amt, Gambler g);

	bool RemoveFunds(float amt, Gambler g);

	//TODO
	WorkSchedule Checkschedule();
};