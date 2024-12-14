using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000152 RID: 338
	public static class BuyRogueShopBuffScRspReflection
	{
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0002CAA5 File Offset: 0x0002ACA5
		public static FileDescriptor Descriptor
		{
			get
			{
				return BuyRogueShopBuffScRspReflection.descriptor;
			}
		}

		// Token: 0x04000685 RID: 1669
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtCdXlSb2d1ZVNob3BCdWZmU2NSc3AucHJvdG8aEUpGS0xJRUhLRERFLnBy" + "b3RvIk8KFUJ1eVJvZ3VlU2hvcEJ1ZmZTY1JzcBIPCgdyZXRjb2RlGAEgASgN" + "EiUKD3JvZ3VlX2J1ZmZfaW5mbxgNIAEoCzIMLkpGS0xJRUhLRERFQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			JFKLIEHKDDEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BuyRogueShopBuffScRsp), BuyRogueShopBuffScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueBuffInfo"
			}, null, null, null, null)
		}));
	}
}
