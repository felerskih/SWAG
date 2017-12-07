#pragma once
#include "User.h"

class Gambler : public User
{
private:
	float funds = 0;

public:
	bool AddFunds(float amt) { funds += amt; }

	bool WithdrawFunds(float amt) { funds -= amt; }
};