#include "Message.h"

Message::Message(string m, User  s, User r)
{
	text = m;
	sender = s;
	receiver = r;
}