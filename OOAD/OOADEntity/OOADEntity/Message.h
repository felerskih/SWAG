#pragma once
#include "User.h"
#include <string>
using namespace std;

class Message
{
private:
	string text;
	User sender;
	User receiver;

public:
	Message(string m, User  s, User r);
};