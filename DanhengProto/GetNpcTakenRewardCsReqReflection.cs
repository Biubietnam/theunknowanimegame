using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000750 RID: 1872
	public static class GetNpcTakenRewardCsReqReflection
	{
		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x000E1697 File Offset: 0x000DF897
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetNpcTakenRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x040020E8 RID: 8424
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXROcGNUYWtlblJld2FyZENzUmVxLnByb3RvIigKFkdldE5wY1Rha2Vu" + "UmV3YXJkQ3NSZXESDgoGbnBjX2lkGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcTakenRewardCsReq), GetNpcTakenRewardCsReq.Parser, new string[]
			{
				"NpcId"
			}, null, null, null, null)
		}));
	}
}
