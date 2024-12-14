using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000470 RID: 1136
	public static class EnterSummonActivityStageScRspReflection
	{
		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x0008B546 File Offset: 0x00089746
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSummonActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x0400142C RID: 5164
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNFbnRlclN1bW1vbkFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVC",
			"YXR0bGVJbmZvLnByb3RvIn4KHUVudGVyU3VtbW9uQWN0aXZpdHlTdGFnZVNj",
			"UnNwEhAKCGdyb3VwX2lkGAsgASgNEiUKC2JhdHRsZV9pbmZvGAIgASgLMhAu",
			"U2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYAyABKA0SEwoLQUhGTkdQTERB",
			"SUkYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSummonActivityStageScRsp), EnterSummonActivityStageScRsp.Parser, new string[]
			{
				"GroupId",
				"BattleInfo",
				"Retcode",
				"AHFNGPLDAII"
			}, null, null, null, null)
		}));
	}
}
