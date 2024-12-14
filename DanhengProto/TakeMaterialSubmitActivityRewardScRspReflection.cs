using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E8 RID: 4840
	public static class TakeMaterialSubmitActivityRewardScRspReflection
	{
		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600D800 RID: 55296 RVA: 0x00240086 File Offset: 0x0023E286
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeMaterialSubmitActivityRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005631 RID: 22065
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitUYWtlTWF0ZXJpYWxTdWJtaXRBY3Rpdml0eVJld2FyZFNjUnNwLnByb3Rv",
			"Gg5JdGVtTGlzdC5wcm90byJoCiVUYWtlTWF0ZXJpYWxTdWJtaXRBY3Rpdml0",
			"eVJld2FyZFNjUnNwEhkKBnJld2FyZBgNIAEoCzIJLkl0ZW1MaXN0Eg8KB3Jl",
			"dGNvZGUYCyABKA0SEwoLTkNFSk5GRk1HR0YYAyABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeMaterialSubmitActivityRewardScRsp), TakeMaterialSubmitActivityRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode",
				"NCEJNFFMGGF"
			}, null, null, null, null)
		}));
	}
}
