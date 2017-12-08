#include "ManageFunds.h"

bool ManageFunds::AddFunds(float amt, Gambler g)
{
	if (g.AddFunds(amt))
		return true;
	return false;
}

bool ManageFunds::RemoveFunds(float amt, Gambler g)
{
	if (g.WithdrawFunds(amt))
		return true;
	return false;
}