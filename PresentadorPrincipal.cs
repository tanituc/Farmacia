using System;

public class PresentadorPrincipal : IPresentadorPrincipal
{
	public PresentadorPrincipal()
	{
	}

    public void nuevoGestionMedicamento()
    {
        GestionMedicamento gm = new GestionMedicamento();
    }
}
