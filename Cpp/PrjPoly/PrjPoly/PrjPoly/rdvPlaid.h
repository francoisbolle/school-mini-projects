#include "rdvTrib.h"

class rdvPlaid : public rdvTrib
{
private:
	bool jury;

public:
	rdvPlaid(void)
	{
		this->jury = false;
		this->typRdv = "rdvPlaid";
	}

	rdvPlaid(string t_ville) : rdvTrib(t_ville)
	{
		this->typRdv = "rdvPlaid";
	}

	rdvPlaid(string t_ville, int t_NoD) : rdvTrib(t_ville, t_NoD)
	{
		this->typRdv = "rdvPlaid";
	}

	void set_jury(bool t_jury)
	{
		this->jury = t_jury;
	}

	bool get_jury(void)
	{
		return this->jury;
	}

	virtual void setP_bool(bool t_bool)
	{
		this->set_jury(t_bool);
	}

	virtual bool getP_bool(void)
	{
		return this->get_jury();
	}
};