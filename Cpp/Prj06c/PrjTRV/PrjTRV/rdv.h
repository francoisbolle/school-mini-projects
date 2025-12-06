#pragma once
#include "stdafx.h"
#include "Invalid_Value.h"

class rdv
{
private:
	int NoD;		// contrainte imposée: >0
	string DatRdv;
	string TimRdv;

public:
	rdv(void);
	void set_NoD(int t_NoD);
	int get_NoD(void);
	void set_DatRdv(string t_DatRdv);
	string get_DatRdv(void);
	void set_TimRdv(string t_TimRdv);
	string get_TimRdv(void);
	
};