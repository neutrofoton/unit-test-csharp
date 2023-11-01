using Microsoft.EntityFrameworkCore;

namespace NeurtoLab.Repository.EF;
public abstract class EFRepository
{
    private EFContext efContext;
    public EFRepository(EFContext efContext){

        this.efContext=efContext;
    }

    protected EFContext EFContext
    {
        get{return efContext;}
    }
}
