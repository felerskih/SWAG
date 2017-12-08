#pragma once
#include <string>
using namespace std;

class User
{
private:

	string username;
	string password;

public:
	User();

	User(string u, string p);
};