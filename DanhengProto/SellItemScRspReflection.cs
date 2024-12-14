using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B8 RID: 4280
	public static class SellItemScRspReflection
	{
		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x002021C3 File Offset: 0x002003C3
		public static FileDescriptor Descriptor
		{
			get
			{
				return SellItemScRspReflection.descriptor;
			}
		}

		// Token: 0x04004D89 RID: 19849
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWxsSXRlbVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJFCg1TZWxs" + "SXRlbVNjUnNwEg8KB3JldGNvZGUYByABKA0SIwoQcmV0dXJuX2l0ZW1fbGlz" + "dBgLIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SellItemScRsp), SellItemScRsp.Parser, new string[]
			{
				"Retcode",
				"ReturnItemList"
			}, null, null, null, null)
		}));
	}
}
