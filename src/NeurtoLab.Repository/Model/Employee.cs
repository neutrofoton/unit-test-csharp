namespace NeurtoLab.Repository.Model;
public class Employee : BaseModel<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public int Age {get;set;}

}
