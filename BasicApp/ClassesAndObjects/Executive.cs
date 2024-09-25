namespace CollegeManagement;
public class Executive(string name, DateTime dob, char gender) : Person(name, dob, gender), IAdmin
{
    public List<string> GetRoles()
    {
        throw new NotImplementedException();
    }
}