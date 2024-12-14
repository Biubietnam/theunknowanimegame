using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200132A RID: 4906
	public static class TakeRogueEventHandbookRewardScRspReflection
	{
		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600DAF4 RID: 56052 RVA: 0x002472F8 File Offset: 0x002454F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeRogueEventHandbookRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400572F RID: 22319
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidUYWtlUm9ndWVFdmVudEhhbmRib29rUmV3YXJkU2NSc3AucHJvdG8aDkl0",
			"ZW1MaXN0LnByb3RvImQKIVRha2VSb2d1ZUV2ZW50SGFuZGJvb2tSZXdhcmRT",
			"Y1JzcBIPCgdyZXRjb2RlGA8gASgNEhkKBnJld2FyZBgIIAEoCzIJLkl0ZW1M",
			"aXN0EhMKC0RQT0FIS01MQUtLGAQgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueEventHandbookRewardScRsp), TakeRogueEventHandbookRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"Reward",
				"DPOAHKMLAKK"
			}, null, null, null, null)
		}));
	}
}
