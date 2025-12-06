#pragma once
#include "stdafx.h"

class Invalid_Value
{
public:
	string Mess;

	Invalid_Value(void)
	{
		this->Mess = "Valeur invalide";
	}

	Invalid_Value(string t_Mess)
	{
		this->Mess = t_Mess;
	}
};