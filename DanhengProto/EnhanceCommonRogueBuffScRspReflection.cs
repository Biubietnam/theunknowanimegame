using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000424 RID: 1060
	public static class EnhanceCommonRogueBuffScRspReflection
	{
		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x0008229D File Offset: 0x0008049D
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnhanceCommonRogueBuffScRspReflection.descriptor;
			}
		}

		// Token: 0x040012E5 RID: 4837
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFFbmhhbmNlQ29tbW9uUm9ndWVCdWZmU2NSc3AucHJvdG8aFVJvZ3VlQ29t",
			"bW9uQnVmZi5wcm90byJoChtFbmhhbmNlQ29tbW9uUm9ndWVCdWZmU2NSc3AS",
			"JAoKcm9ndWVfYnVmZhgPIAEoCzIQLlJvZ3VlQ29tbW9uQnVmZhIPCgdyZXRj",
			"b2RlGAkgASgNEhIKCmlzX3N1Y2Nlc3MYBSABKAhCHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnhanceCommonRogueBuffScRsp), EnhanceCommonRogueBuffScRsp.Parser, new string[]
			{
				"RogueBuff",
				"Retcode",
				"IsSuccess"
			}, null, null, null, null)
		}));
	}
}
