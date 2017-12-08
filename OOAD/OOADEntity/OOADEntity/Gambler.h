#pragma once
#include "User.h"

class Gambler : public User
{
private:
	float funds = 0;

public:
	Gambler(string u, string p, float f) { User(u, p); funds = f; }

	bool AddFunds(float amt) { funds += amt; }

	bool WithdrawFunds(float amt) { funds -= amt; }
};