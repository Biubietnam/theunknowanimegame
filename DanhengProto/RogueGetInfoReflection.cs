using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E98 RID: 3736
	public static class RogueGetInfoReflection
	{
		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600A6F1 RID: 42737 RVA: 0x001C1A54 File Offset: 0x001BFC54
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGetInfoReflection.descriptor;
			}
		}

		// Token: 0x04004447 RID: 17479
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJSb2d1ZUdldEluZm8ucHJvdG8aE1JvZ3VlQWVvbkluZm8ucHJvdG8aGlJv",
			"Z3VlU2NvcmVSZXdhcmRJbmZvLnByb3RvGhNSb2d1ZUFyZWFJbmZvLnByb3Rv",
			"GhVSb2d1ZVNlYXNvbkluZm8ucHJvdG8aHVJvZ3VlR2V0VmlydHVhbEl0ZW1J",
			"bmZvLnByb3RvIoACCgxSb2d1ZUdldEluZm8SOQoXcm9ndWVfdmlydHVhbF9p",
			"dGVtX2luZm8YBCABKAsyGC5Sb2d1ZUdldFZpcnR1YWxJdGVtSW5mbxI2Chdy",
			"b2d1ZV9zY29yZV9yZXdhcmRfaW5mbxgKIAEoCzIVLlJvZ3VlU2NvcmVSZXdh",
			"cmRJbmZvEicKD3JvZ3VlX2FyZWFfaW5mbxgOIAEoCzIOLlJvZ3VlQXJlYUlu",
			"Zm8SJwoPcm9ndWVfYWVvbl9pbmZvGAwgASgLMg4uUm9ndWVBZW9uSW5mbxIr",
			"ChFyb2d1ZV9zZWFzb25faW5mbxgNIAEoCzIQLlJvZ3VlU2Vhc29uSW5mb0Ie",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueAeonInfoReflection.Descriptor,
			RogueScoreRewardInfoReflection.Descriptor,
			RogueAreaInfoReflection.Descriptor,
			RogueSeasonInfoReflection.Descriptor,
			RogueGetVirtualItemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGetInfo), RogueGetInfo.Parser, new string[]
			{
				"RogueVirtualItemInfo",
				"RogueScoreRewardInfo",
				"RogueAreaInfo",
				"RogueAeonInfo",
				"RogueSeasonInfo"
			}, null, null, null, null)
		}));
	}
}
