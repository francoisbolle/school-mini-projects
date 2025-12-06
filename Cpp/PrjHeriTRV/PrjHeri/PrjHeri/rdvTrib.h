#include "rdv.h"

class rdvTrib : public rdv
{
private:
	string ville;
	string juge;

public:

	rdvTrib(void)
	{
		this->set_DatRdv("0");	// Accès direct impossible à la variable privée
		this->TimRdv = "0";		// Accès direct à la variable protégée
	}

	rdvTrib(string t_ville, int t_NoD = 3) : rdv(t_NoD)
	{
		/*this->set_DatRdv("0");
		this->TimRdv = "0";*/
		rdvTrib();
		this->ville = t_ville;
	}

	~rdvTrib()
	{
		this->set_DatRdv("9");
		this->TimRdv = 9;
	}

	void set_ville(string t_ville)
	{
		this->ville = t_ville;
	}

	string get_ville(void)
	{
		return this->ville;
	}

	void set_juge(string t_juge)
	{
		this->juge = t_juge;
	}

	string get_juge(void)
	{
		return this->juge;
	}
};


