﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Unicode
{
	/// <summary>Represents the different numeric types from the Unihan database.</summary>
	public enum UnihanNumericType : byte
	{
		None = 0,
		[ValueName("kPrimaryNumeric")]
		Primary = 1,
		[ValueName("kAccountingNumeric")]
		Accounting = 2,
		[ValueName("kOtherNumeric")]
		Other = 3,
	}
}