using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200114A RID: 4426
	public static class ShareScRspReflection
	{
		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600C579 RID: 50553 RVA: 0x00211E5D File Offset: 0x0021005D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ShareScRspReflection.descriptor;
			}
		}

		// Token: 0x04004FBD RID: 20413
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBTaGFyZVNjUnNwLnByb3RvGg9TaGFyZURhdGEucHJvdG8aDkl0ZW1MaXN0",
			"LnByb3RvIlkKClNoYXJlU2NSc3ASHwoLREZHTktDQ1BBQ0oYDCABKAsyCi5T",
			"aGFyZURhdGESDwoHcmV0Y29kZRgJIAEoDRIZCgZyZXdhcmQYBiABKAsyCS5J",
			"dGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			ShareDataReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ShareScRsp), ShareScRsp.Parser, new string[]
			{
				"DFGNKCCPACJ",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
