using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000598 RID: 1432
	public static class FinishSectionIdScRspReflection
	{
		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x000AE246 File Offset: 0x000AC446
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishSectionIdScRspReflection.descriptor;
			}
		}

		// Token: 0x04001964 RID: 6500
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpGaW5pc2hTZWN0aW9uSWRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8i" + "VgoURmluaXNoU2VjdGlvbklkU2NSc3ASEgoKc2VjdGlvbl9pZBgIIAEoDRIP" + "CgdyZXRjb2RlGAwgASgNEhkKBnJld2FyZBgNIAEoCzIJLkl0ZW1MaXN0Qh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishSectionIdScRsp), FinishSectionIdScRsp.Parser, new string[]
			{
				"SectionId",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
