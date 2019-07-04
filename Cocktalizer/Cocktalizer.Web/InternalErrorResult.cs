using Microsoft.AspNetCore.Mvc;

namespace Cocktalizer.Web
{
	public class InternalErrorResult : StatusCodeResult
	{
		public InternalErrorResult() : this(500)
		{
		}

		private InternalErrorResult(int statusCode) : base(statusCode)
		{
			
		}
		
	}
}