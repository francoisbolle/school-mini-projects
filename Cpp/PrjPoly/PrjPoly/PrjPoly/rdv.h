#include "stdafx.h"

class rdv
{
private:
	int NoD;		// contrainte imposée: >0
	string DatRdv;
	
protected:
	string TimRdv;
	string typRdv; // rdv - rdvTrib - rdvPlaid

public:
	rdv(void)
	{
		this->NoD = 0;
		this->typRdv = "rdv";
	}

	rdv(int t_NoD)
	{
		this->NoD = t_NoD;
		this->typRdv = "rdv";
	}

	~rdv()
	{
		this->NoD = 9;
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

	string get_typRdv(void)
	{
		return this->typRdv;
	}

	virtual void setP_string(string t_string, bool VIju)
	{

	}

	virtual string getP_string(bool VIju)
	{
		return "";
	}

	//virtual void setP_bool(bool t_bool) = 0;	==> CLASSE ABSTRAITE DE PAR LA PRESENCE D'UNE METHODE VIRTUELLE PURE
	
	virtual void setP_bool(bool t_bool)
	{

	}

	virtual bool getP_bool(void)
	{
		return true;
	}
};