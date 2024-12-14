using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000428 RID: 1064
	public static class EnhanceRogueBuffScRspReflection
	{
		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x0008295A File Offset: 0x00080B5A
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnhanceRogueBuffScRspReflection.descriptor;
			}
		}

		// Token: 0x040012F3 RID: 4851
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtFbmhhbmNlUm9ndWVCdWZmU2NSc3AucHJvdG8aD1JvZ3VlQnVmZi5wcm90" + "byJcChVFbmhhbmNlUm9ndWVCdWZmU2NSc3ASHgoKcm9ndWVfYnVmZhgGIAEo" + "CzIKLlJvZ3VlQnVmZhIPCgdyZXRjb2RlGAcgASgNEhIKCmlzX3N1Y2Nlc3MY" + "DSABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RogueBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnhanceRogueBuffScRsp), EnhanceRogueBuffScRsp.Parser, new string[]
			{
				"RogueBuff",
				"Retcode",
				"IsSuccess"
			}, null, null, null, null)
		}));
	}
}
