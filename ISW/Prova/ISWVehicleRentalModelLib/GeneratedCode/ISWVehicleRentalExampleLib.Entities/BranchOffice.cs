﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
namespace ISWVehicleRentalExampleLib.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public partial class BranchOffice
	{
		public string address
		{
			get;
			set;
		}

		public int Id
		{
			get;
			set;
		}

		public virtual ICollection<Reservation> PickUpReservations
		{
			get;
			set;
		}

		public virtual ICollection<Reservation> ReturnReservations
		{
			get;
			set;
		}

	}
}

