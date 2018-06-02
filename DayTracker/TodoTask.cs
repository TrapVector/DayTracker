using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTracker
{
	internal class TodoTask
	{
		public string Description { get; set; }

		public bool Completed { get; set; }

		public TodoTask( string Description )
		{
			this.Description = Description;
			this.Completed = false;
		}

		public static string Serialize( TodoTask TodoTask )
		{
			return ( TodoTask.Completed ? "1" : "0" ) + TodoTask.Description;
		}

		public static TodoTask Deserialize( string Data )
		{
			var TaskDescription = Data.Substring( 1 ).Trim();
			var TaskCompleted   = Data[ 0 ] == '1';
			var NewTask = new TodoTask( TaskDescription );
			NewTask.Completed = TaskCompleted;

			return NewTask;
		}
	}
}
