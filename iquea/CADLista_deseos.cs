using System;

public class CADLista_deseos
{
	private String constring;
	public CADLista_deseos()
	{
		constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
	}


}
