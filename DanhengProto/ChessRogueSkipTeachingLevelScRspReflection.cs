using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200029C RID: 668
	public static class ChessRogueSkipTeachingLevelScRspReflection
	{
		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000553A2 File Offset: 0x000535A2
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueSkipTeachingLevelScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C66 RID: 3174
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZDaGVzc1JvZ3VlU2tpcFRlYWNoaW5nTGV2ZWxTY1JzcC5wcm90bxoOSXRl",
			"bUxpc3QucHJvdG8iVgogQ2hlc3NSb2d1ZVNraXBUZWFjaGluZ0xldmVsU2NS",
			"c3ASIQoOU2tpcFJld2FyZExpc3QYASABKAsyCS5JdGVtTGlzdBIPCgdyZXRj",
			"b2RlGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueSkipTeachingLevelScRsp), ChessRogueSkipTeachingLevelScRsp.Parser, new string[]
			{
				"SkipRewardList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
