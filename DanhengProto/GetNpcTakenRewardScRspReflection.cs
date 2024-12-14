using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000752 RID: 1874
	public static class GetNpcTakenRewardScRspReflection
	{
		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x060053CC RID: 21452 RVA: 0x000E1906 File Offset: 0x000DFB06
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetNpcTakenRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040020ED RID: 8429
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXROcGNUYWtlblJld2FyZFNjUnNwLnByb3RvIlIKFkdldE5wY1Rha2Vu" + "UmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIOCgZucGNfaWQYAyABKA0S" + "FwoPdGFsa19ldmVudF9saXN0GAsgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcTakenRewardScRsp), GetNpcTakenRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"NpcId",
				"TalkEventList"
			}, null, null, null, null)
		}));
	}
}
