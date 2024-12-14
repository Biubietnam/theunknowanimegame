using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001012 RID: 4114
	public static class RogueTournSaveListReflection
	{
		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600B701 RID: 46849 RVA: 0x001EAE53 File Offset: 0x001E9053
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournSaveListReflection.descriptor;
			}
		}

		// Token: 0x04004A20 RID: 18976
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZVRvdXJuU2F2ZUxpc3QucHJvdG8aF1JvZ3VlVG91cm5DdXJJbmZv",
			"LnByb3RvGhpSb2d1ZVRvdXJuU2Vhc29uSW5mby5wcm90bxoRTkJBUExKREJP",
			"Q0IucHJvdG8i1QEKElJvZ3VlVG91cm5TYXZlTGlzdBIMCgR0aW1lGAUgASgD",
			"EhAKCGVuZF90aW1lGA8gASgDEgwKBG5hbWUYDCABKAkSMAoUcm9ndWVfdG91",
			"cm5fY3VyX2luZm8YByABKAsyEi5Sb2d1ZVRvdXJuQ3VySW5mbxIRCgltYXhf",
			"dGltZXMYDSABKA0SMAoRcm9ndWVfc2Vhc29uX2luZm8YBCABKAsyFS5Sb2d1",
			"ZVRvdXJuU2Vhc29uSW5mbxIaCgRkYXRhGAEgASgLMgwuTkJBUExKREJPQ0JC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournCurInfoReflection.Descriptor,
			RogueTournSeasonInfoReflection.Descriptor,
			NBAPLJDBOCBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSaveList), RogueTournSaveList.Parser, new string[]
			{
				"Time",
				"EndTime",
				"Name",
				"RogueTournCurInfo",
				"MaxTimes",
				"RogueSeasonInfo",
				"Data"
			}, null, null, null, null)
		}));
	}
}
