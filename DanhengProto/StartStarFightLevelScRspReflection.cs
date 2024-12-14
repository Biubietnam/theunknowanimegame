using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011CA RID: 4554
	public static class StartStarFightLevelScRspReflection
	{
		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600CB8C RID: 52108 RVA: 0x00222662 File Offset: 0x00220862
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartStarFightLevelScRspReflection.descriptor;
			}
		}

		// Token: 0x0400521F RID: 21023
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5TdGFydFN0YXJGaWdodExldmVsU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxl",
			"SW5mby5wcm90byJ5ChhTdGFydFN0YXJGaWdodExldmVsU2NSc3ASEAoIZ3Jv",
			"dXBfaWQYByABKA0SEwoLQUhGTkdQTERBSUkYCCABKA0SDwoHcmV0Y29kZRgE",
			"IAEoDRIlCgtiYXR0bGVfaW5mbxgNIAEoCzIQLlNjZW5lQmF0dGxlSW5mb0Ie",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartStarFightLevelScRsp), StartStarFightLevelScRsp.Parser, new string[]
			{
				"GroupId",
				"AHFNGPLDAII",
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
