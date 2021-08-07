using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carolina.ViewModels
{
	public class BaseCreateViewModel<TModel> where TModel : class
	{
		public TModel Model { get; set; }
	}
}
