using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200103E RID: 4158
	public static class RotateMapCsReqReflection
	{
		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600B8FB RID: 47355 RVA: 0x001F098B File Offset: 0x001EEB8B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RotateMapCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004AEF RID: 19183
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRSb3RhdGVNYXBDc1JlcS5wcm90bxoQTW90aW9uSW5mby5wcm90bxoRSE1C",
			"TElBRE5LRU8ucHJvdG8idAoOUm90YXRlTWFwQ3NSZXESEwoLR01DRkJMRkFG",
			"Rk8YAyABKA0SEAoIZ3JvdXBfaWQYCSABKA0SGwoGbW90aW9uGA4gASgLMgsu",
			"TW90aW9uSW5mbxIeCghyb29tX21hcBgHIAEoCzIMLkhNQkxJQUROS0VPQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor,
			HMBLIADNKEOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RotateMapCsReq), RotateMapCsReq.Parser, new string[]
			{
				"GMCFBLFAFFO",
				"GroupId",
				"Motion",
				"RoomMap"
			}, null, null, null, null)
		}));
	}
}
