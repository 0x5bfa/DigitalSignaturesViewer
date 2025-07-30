// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignaturesVisualizer
{
	public class DigitalSignatureItem
	{
		public string? Issuer { get; set; }

		public string? DigestAlgorithm { get; set; }

		public string? Timestamp { get; set; }
	}
}
