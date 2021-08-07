//*****
//solution(1)
//*****
//using System.Collections.Generic;
//using Models;

//namespace Data
//{

//	public class CommandRepository : object, ICommandRepository
//	{
//		IEnumerable<Command> ICommandRepository.GetAll()
//		{
//			throw new System.NotImplementedException();
//		}

//		Command ICommandRepository.GetById(int id)
//		{
//			throw new System.NotImplementedException();
//		}
//	}
//}
//***************************************************************
////*****
////solution(2)
////*****
//using System.Collections.Generic;
//using Models;

//namespace Data
//{ 
//	public class CommandRepository : object, ICommandRepository
//	{
//		IEnumerable<Command> ICommandRepository.GetAll()
//		{
//			return null;
//		}

//		Command ICommandRepository.GetById(int id)
//		{
//			return null;
//		}
//	}
//}
//***************************************************************
////*****
////solution(3)
////*****
//using System.Linq;

//namespace Data
//{
//	public class CommandRepository : object, ICommandRepository
//	{
//		public CommandRepository() : base()
//		{

//		}

//		private System.Collections.Generic.List<Models.Command> _commands;

//		protected virtual System.Collections.Generic.List<Models.Command> Commands
//		{
//			get
//			{
//				if (_commands == null)
//				{
//					_commands =
//						new System.Collections.Generic.List<Models.Command>();
//				}

//				if (_commands.Any() == false)
//				{
//					for (int index = 1; index <= 10; index++)
//					{
//						Models.Command newCommand =
//							new Models.Command
//							{
//								Id = index,
//								Line = $"Line { index }",
//								HowTo = $"How To { index }",
//								Platform = $"Platform { index }",
//							};
//						_commands.Add(newCommand);
//					}
//				}
//				return _commands;
//			}
//		}

//		public System.Collections.Generic.IEnumerable<Models.Command> GetAll()
//		{
//			return Commands;
//		}

//		public Models.Command GetById(int id)
//		{
//			Models.Command foundedCommand =
//				Commands
//				.Where(current => current.Id == id)
//				.FirstOrDefault();

//			return foundedCommand;
//		}
//	}
//}
//***************************************************************
//*****
//solution(4)
//*****
using System.Linq;

namespace Data
{
	public class CommandRepository : object, ICommandRepository
	{
		public CommandRepository() : base()
		{

		}
		private System.Collections.Generic.List<Models.Command> _commands;

		protected virtual System.Collections.Generic.List<Models.Command> Commands
		{
			get
			{
				if (_commands == null)
				{
					_commands =
						new System.Collections.Generic.List<Models.Command>();
				}

				if (_commands.Any() == false)
				{
					for (int index = 1; index <= 10; index++)
					{
						Models.Command newCommand =
							new Models.Command
							{
								Id = index,
								Line = $"Line { index }",
								HowTo = $"How To { index }",
								Platform = $"Platform { index }",
							};
						_commands.Add(newCommand);
					}
				}
				return _commands;
			}
		}
		public async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Models.Command>> GetAllAsync()
		{
			//solution(1)
			//return Commands;
			//solution(1)

			//solution(2)
			//var result =
			//	await MyDatabaseContext.Command
			//	.ToListAsync();
			//solution(2)

			System.Collections.Generic.IEnumerable<Models.Command> result = null;

			await System.Threading.Tasks.Task.Run(() =>
			{
				result = Commands;
			});

			return result;
		}

		public async System.Threading.Tasks.Task<Models.Command> GetByIdAsync(int id)
		{
			//Solution(1)

			//Models.Command foundedCommand =
			//	Commands
			//	.Where(current => current.Id == id)
			//	.FirstOrDefault();

			//return foundedCommand; 

			//solution(1)


			//solution(2)

			//Models.Command foundedCommand =
			//	 MyDatabaseContext.Commands
			//	.where(current => current.Id == id)
			//	.firstOrDefault();

			//return foundedCommand;

			//solution(2)


			//solution(3)

			//Models.Command foundedCommand =
			//	await MyDatabaseContext.Commands
			//	.where(current => current.Id == id)
			//	.firstOrDefaultAsync();

			//return foundedCommand;

			//solution(3)

			//solution(4)

			//My Notes : with writing "Result" in the end of the code
			//and deleting "await" in the first of the code
			//you make this code Sync not Async,
			//so with writing firstOrDefaultAsync you will see some errors
			//because actually your code is not Async!

			//Models.Command foundedCommand =
			//	 MyDatabaseContext.Commands
			//	.where(current => current.Id == id)
			//	.firstOrDefaultAsync().Result;

			//return foundedCommand;

			//solution(4)


			//solution(5)

			Models.Command foundedCommand = null;

			await System.Threading.Tasks.Task.Run(() =>
			{
				foundedCommand =
				 Commands
				.Where(current => current.Id == id)
				.FirstOrDefault();
			});

			return foundedCommand;

			//solution(5)
		}
	}
}




