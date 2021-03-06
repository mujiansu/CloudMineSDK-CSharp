﻿using System;
using Newtonsoft.Json;
using CloudmineSDK.Model;

namespace CloudMineSDKNUnitTests
{
	[JsonObject(MemberSerialization.OptIn)]
	public class HCPMock: CMObject
	{
		[JsonProperty("ProviderName", NullValueHandling=NullValueHandling.Ignore)]
		public string ProviderName { get; set; }

		[JsonProperty("ProviderAddress", NullValueHandling=NullValueHandling.Ignore)]
		public string ProviderAddress { get; set; }

		[JsonProperty("ProviderEmployeeCount", NullValueHandling=NullValueHandling.Ignore)]
		public int ProviderEmployeeCount { get; set; }

		public HCPMock (): base()
		{
		}
	}
}

