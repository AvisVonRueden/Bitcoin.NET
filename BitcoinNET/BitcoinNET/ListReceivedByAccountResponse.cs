﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET
{
	public struct ListReceivedByAccountResponse
	{
		public string account;
		public decimal amount;
		public long confirmations;
	}
}