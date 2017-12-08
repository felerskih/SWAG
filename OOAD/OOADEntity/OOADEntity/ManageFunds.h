#pragma once
#include "Gambler.h"

class ManageFunds
{
private:

public:
	bool AddFunds(float amt, Gambler g);
	bool RemoveFunds(float amt, Gambler g);
};