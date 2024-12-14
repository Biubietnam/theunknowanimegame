using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F4 RID: 244
	public static class BattleRogueMagicDetailInfoReflection
	{
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00020847 File Offset: 0x0001EA47
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicDetailInfoReflection.descriptor;
			}
		}

		// Token: 0x040004A2 RID: 1186
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBCYXR0bGVSb2d1ZU1hZ2ljRGV0YWlsSW5mby5wcm90bxoeQmF0dGxlUm9n",
			"dWVNYWdpY0l0ZW1JbmZvLnByb3RvIlcKGkJhdHRsZVJvZ3VlTWFnaWNEZXRh",
			"aWxJbmZvEjkKFmJhdHRsZV9tYWdpY19pdGVtX2luZm8YASABKAsyGS5CYXR0",
			"bGVSb2d1ZU1hZ2ljSXRlbUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			BattleRogueMagicItemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicDetailInfo), BattleRogueMagicDetailInfo.Parser, new string[]
			{
				"BattleMagicItemInfo"
			}, null, null, null, null)
		}));
	}
}
