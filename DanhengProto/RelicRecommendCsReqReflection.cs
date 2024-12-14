using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DAC RID: 3500
	public static class RelicRecommendCsReqReflection
	{
		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x06009C81 RID: 40065 RVA: 0x001A0D5D File Offset: 0x0019EF5D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicRecommendCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003CD2 RID: 15570
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSZWxpY1JlY29tbWVuZENzUmVxLnByb3RvIigKE1JlbGljUmVjb21tZW5k" + "Q3NSZXESEQoJYXZhdGFyX2lkGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicRecommendCsReq), RelicRecommendCsReq.Parser, new string[]
			{
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
