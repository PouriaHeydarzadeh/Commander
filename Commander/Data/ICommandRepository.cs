//namespace Data
//{
//	// My Notes : 
//	//1)when you make an interface, you can only add 3 members :  method,event,property
//	//2)when you make an interface, you can not add accesmodifier
//	//3)when you make an interface, you can not add body for your methods

//	public interface ICommandRepository 
//	{
//		System.Collections.Generic.IEnumerable<Models.Command> GetAll();

//		Models.Command GetById(int id);
//	}
//}
namespace Data
{
	public interface ICommandRepository
	{
		System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Models.Command>> GetAllAsync();
		System.Threading.Tasks.Task<Models.Command> GetByIdAsync(int id);
	
	}
}
