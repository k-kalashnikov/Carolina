using Carolina.Data;
using Carolina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carolina.Controllers
{
	public class UsersController : BaseCRUDController<User>
	{
		public UsersController(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}
