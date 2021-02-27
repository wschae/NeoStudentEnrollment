using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

[assembly: ContractTitle("Student Enrollment")]
[assembly: Features(ContractPropertyState.HasStorage)]

public class StudentEnrollment : SmartContract
{
    public static object Main(string operation, params object[] args)
    {
        switch (operation)
        {
            case "register" when args.Length == 2:
                Storage.Put(Storage.CurrentContext, (string)args[0], (string)args[1]);
                return true;

            case "query":
                return Storage.Get(Storage.CurrentContext, (string)args[0]);

            case "find":
                return Storage.Find(Storage.CurrentContext, (string)args[0]);

            default:
                return false;
        }
    }
}



