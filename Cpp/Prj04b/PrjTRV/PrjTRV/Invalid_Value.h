#pragma once
#include "stdafx.h"

class Invalid_Value
{
public:
	string Mess;

	Invalid_Value(void)
	{
	}

	Invalid_Value(string t_Mess)
	{
		this->Mess = t_Mess;
	}
};