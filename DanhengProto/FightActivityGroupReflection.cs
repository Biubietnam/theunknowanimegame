using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000524 RID: 1316
	public static class FightActivityGroupReflection
	{
		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x000A1B5B File Offset: 0x0009FD5B
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightActivityGroupReflection.descriptor;
			}
		}

		// Token: 0x040017A4 RID: 6052
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhGaWdodEFjdGl2aXR5R3JvdXAucHJvdG8ihwEKEkZpZ2h0QWN0aXZpdHlH",
			"cm91cBIPCgdHcm91cElkGA8gASgNEhYKDkVuZGxlc3NNYXhXYXZlGAMgASgN",
			"EiAKGFBhc3NlZE1heERpZmZpY3VsdHlMZXZlbBgJIAEoDRImCh5UYWtlbkRp",
			"ZmZpY3VsdHlMZXZlbFJld2FyZExpc3QYBCADKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightActivityGroup), FightActivityGroup.Parser, new string[]
			{
				"GroupId",
				"EndlessMaxWave",
				"PassedMaxDifficultyLevel",
				"TakenDifficultyLevelRewardList"
			}, null, null, null, null)
		}));
	}
}
