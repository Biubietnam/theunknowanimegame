using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007CE RID: 1998
	public static class GetRogueShopBuffInfoScRspReflection
	{
		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x000EDD31 File Offset: 0x000EBF31
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueShopBuffInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x040022A5 RID: 8869
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRSb2d1ZVNob3BCdWZmSW5mb1NjUnNwLnByb3RvGhFKRktMSUVIS0RE",
			"RS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIowBChlHZXRSb2d1ZVNob3BC",
			"dWZmSW5mb1NjUnNwEhMKC05HT0dGRURMTE9PGAggASgIEiIKC0JETkxHRUFO",
			"R0FPGAMgASgLMg0uSXRlbUNvc3REYXRhEiUKD3JvZ3VlX2J1ZmZfaW5mbxgC",
			"IAEoCzIMLkpGS0xJRUhLRERFEg8KB3JldGNvZGUYDiABKA1CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			JFKLIEHKDDEReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopBuffInfoScRsp), GetRogueShopBuffInfoScRsp.Parser, new string[]
			{
				"NGOGFEDLLOO",
				"BDNLGEANGAO",
				"RogueBuffInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
