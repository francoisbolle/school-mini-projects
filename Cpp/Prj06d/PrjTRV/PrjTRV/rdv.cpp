#include "rdv.h"


rdv::rdv(void)
{
	this->NoD = 0;
}

void rdv::set_NoD(int t_NoD)
{
	if (t_NoD > 0) this->NoD = t_NoD;
	//else throw Invalid_Value();	// levée d'exception
	else throw Invalid_Value("Valeurs positives uniquement pour NoD");	// levée d'exception
}

int rdv::get_NoD(void)
{
	return this->NoD;
}

void rdv::set_DatRdv(string t_DatRdv)
{
	this->DatRdv = t_DatRdv;
}

string rdv::get_DatRdv(void)
{
	return this->DatRdv;
}

void rdv::set_TimRdv(string t_TimRdv)
{
	this->TimRdv = t_TimRdv;
}

string rdv::get_TimRdv(void)
{
	return this->TimRdv;
}
