#include "Dealer.h"

Message Dealer::SendMessage(string m, string p)
{
	
	return Message(m, this, //search for manager with username p--);
}

bool Dealer::AddFunds(float amt, Gambler g)
{
	//if gambler exists
	g.AddFunds(amt);
	return true;
}

bool Dealer::RemoveFunds(float amt, Gambler g)
{
	//if gambler exists
	g.WithdrawFunds(amt);
	return true;
}