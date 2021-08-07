using System.Linq;
using System.Collections.Generic;
using Models;

namespace Commander.Controllers
{
	//public class CommandsController
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	public string GetString()
	//	{
	//		return "Hello World! ";
	//	}
	//}
	//***************************************************************
	//public class CommandsController : Microsoft.AspNetCore.Mvc.Controller
	//public class commandscontroller : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public commandscontroller() : base()
	//	{

	//	}
	//	public string getstring()
	//	{
	//		return "hello world!";
	//	}
	//}
	//***************************************************************
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}
	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public string GetString()
	//	{
	//		return "Hello World!";
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/commands")]
	////[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	////public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//public class Something : Microsoft.AspNetCore.Mvc.ControllerBase
	//{

	//	public Something() : base()
	//	{

	//	}
	//	//public CommandsController() : base()
	//	//{

	//	//}

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public Microsoft.AspNetCore.Mvc.IActionResult GetString()
	//	{
	//		return Content("Hello World!");
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public string Something()
	//	{
	//		return "Hello World!";
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/commands")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	[Microsoft.AspNetCore.Mvc.Route(template: "a/b")]
	//	public Microsoft.AspNetCore.Mvc.IActionResult Getstring()
	//	{
	//		return Content("Hello World!");
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/commands")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet(template: "a/b")]
	//	public Microsoft.AspNetCore.Mvc.IActionResult Getstring()
	//	{
	//		return Content("Hello World!");
	//	}
	//}
	//***************************************************************
	////[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	[Microsoft.AspNetCore.Mvc.Route(template: "/a/b")]
	//	public Microsoft.AspNetCore.Mvc.IActionResult Getstring()
	//	{
	//		return Content("Hello World!");
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public Models.Command GetAnObject()
	//	{
	//		Models.Command newCommand =
	//			new Models.Command
	//			{
	//				Id = 1,
	//				HowTo = $"Some How To",
	//				Line = $"Some Line",
	//				Platform = $"Some Platform",
	//			};
	//		return newCommand;
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{

	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	// Note : 
	//	// if your output is void , you should write like this : 
	//	// async System.Threading.Tasks.Task
	//	// not like this : 
	//	// async System.Threading.Tasks.Task<output>

	//	public async System.Threading.Tasks.Task<Models.Command> GetAnObjectAsync()
	//	{
	//		//Models.Command newCommand =
	//		//	new Models.Command
	//		//	{
	//		//		Id = 1,
	//		//		HowTo = $"Some How To",
	//		//		Line = $"Some Line",
	//		//		Platform = $"Some Platform",
	//		//	};

	//		// Note : with following codes we change our "sync method" To "Async method" .
	//		// in this way we should use "await".

	//		Models.Command newCommand = null;
	//		await System.Threading.Tasks.Task.Run(() =>
	//		{
	//			newCommand =
	//				new Models.Command()
	//				{
	//					Id = 1,
	//					HowTo = $"Some How To",
	//					Line = $"Some Line",
	//					Platform = $"Some Platform",
	//				};
	//		});

	//		return newCommand;
	//	}
	//}
	//***************************************************************
	// Note : Now we should go -> Data -> ThisIsNotAGoodRepository
	//***************************************************************
	//// Note : if we use following attribute ,
	//// if we dont write "Routing" we will see warning !
	///
	//[Microsoft.AspNetCore.Mvc.ApiController]
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{
	//		_repository = new Data.ThisIsNotAGoodRepository();
	//	}

	//	// if your field(or property) is a readonly field, you should give it an initial value
	//	// in constructure or in its code as soon as its possible
	//	// and you can not change it!

	//	private readonly Data.ThisIsNotAGoodRepository
	//		_repository;

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public Microsoft.AspNetCore.Mvc.ActionResult GetAll()
	//	{
	//		var result = _repository.GetAll();

	//		return Ok(result);
	//	}
	//	[Microsoft.AspNetCore.Mvc.HttpGet(template:"{id}")]
	//	public Microsoft.AspNetCore.Mvc.ActionResult GetById(int id)
	//	{
	//		Models.Command result =
	//			_repository.GetById(id);

	//		return Ok(result);
	//	}
	//}
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.ApiController]
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/[commands]")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	public CommandsController() : base()
	//	{
	//		_repository = new Data.ThisIsNotAGoodRepository();
	//	}
	//	private readonly Data.ThisIsNotAGoodRepository
	//		_repository;

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Command>>GetAll()
	//	{
	//		var result = _repository.GetAll();
	//		return Ok(result);
	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet(template: "{id}")]
	//	public Microsoft.AspNetCore.Mvc.ActionResult<Models.Command> GetById(int id)
	//	{
	//		Models.Command result =
	//			_repository.GetById(id);

	//		return Ok(result);
	//	}
	//}
	//***************************************************************
	//	// Following codes are about "(DI)Dependency Injection"
	//	// for using following codes we should go to "Startup" and write "(Automatic DI) codes"
	//***************************************************************
	//[Microsoft.AspNetCore.Mvc.ApiController]
	//[Microsoft.AspNetCore.Mvc.Route(template: "api/commands")]
	//public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	//{
	//	//public CommandsController() : base()
	//	//{

	//	//}
	//	public CommandsController(Data.ICommandRepository repository)
	//	{
	//		_repository = repository;
	//	}

	//	private readonly Data.ICommandRepository _repository;

	//	[Microsoft.AspNetCore.Mvc.HttpGet]
	//	public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Command>> GetAll()
	//	{
	//		var result = _repository.GetAll();
	//		return Ok(result);
	//	}

	//	[Microsoft.AspNetCore.Mvc.HttpGet(template: "{id}")]
	//	public Microsoft.AspNetCore.Mvc.ActionResult<Models.Command> GetById(int id)
	//	{
	//		Models.Command result =
	//			_repository.GetById(id);

	//		return Ok(result);
	//	}
	//}
	//***************************************************************
	[Microsoft.AspNetCore.Mvc.ApiController]
	[Microsoft.AspNetCore.Mvc.Route(template: "commands")]
	public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
	{
		//public CommandsController() : base()
		//{

		//}
		public CommandsController(Data.ICommandRepository repository) : base()
		{
			_repository = repository;
		}

		private readonly Data.ICommandRepository _repository;

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Command>>> GetAllAsync()
		{
			var result =
				await _repository.GetAllAsync();
			return Ok(result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet(template: "{id}")]
		public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Models.Command>> GetByIdAsync(int id)
		{
			Models.Command result =
				await _repository.GetByIdAsync(id);
			return Ok(result);
		}
	}
}

