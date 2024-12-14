using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200131E RID: 4894
	public static class TakeRogueAeonLevelRewardScRspReflection
	{
		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600DA63 RID: 55907 RVA: 0x00245B05 File Offset: 0x00243D05
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeRogueAeonLevelRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040056F8 RID: 22264
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNUYWtlUm9ndWVBZW9uTGV2ZWxSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxp",
			"c3QucHJvdG8iawodVGFrZVJvZ3VlQWVvbkxldmVsUmV3YXJkU2NSc3ASDQoF",
			"bGV2ZWwYDCABKA0SDwoHYWVvbl9pZBgKIAEoDRIZCgZyZXdhcmQYAyABKAsy",
			"CS5JdGVtTGlzdBIPCgdyZXRjb2RlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueAeonLevelRewardScRsp), TakeRogueAeonLevelRewardScRsp.Parser, new string[]
			{
				"Level",
				"AeonId",
				"Reward",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
