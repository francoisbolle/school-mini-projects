#include "stdafx.h"

class rdv
{
private:
	int NoD;		// contrainte imposée: >0
	string DatRdv;
	string TimRdv;

public:
	rdv(void)
	{
		this->NoD = 0;
	}

	void set_NoD(int t_NoD)
	{
		if(t_NoD > 0) this->NoD = t_NoD;
		else throw 2;	// levée d'exception
	}

	int get_NoD(void)
	{
		return this->NoD;
	}

	void set_DatRdv(string t_DatRdv)
	{
		this->DatRdv = t_DatRdv;
	}

	string get_DatRdv(void)
	{
		return this->DatRdv;
	}

	void set_TimRdv(string t_TimRdv)
	{
		this->TimRdv = t_TimRdv;
	}

	string get_TimRdv(void)
	{
		return this->TimRdv;
	}
};