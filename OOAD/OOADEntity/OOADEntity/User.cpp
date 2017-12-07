#include "User.h"

User::User(string u, string p)
{
	username = u;
	username = p;
}

bool User::LogIn(string u, string p)
{
	if (u == username && p == password)
		return true;
	return false
}