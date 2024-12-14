using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000402 RID: 1026
	public static class EIGCJPGPIOCReflection
	{
		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x0007E0FB File Offset: 0x0007C2FB
		public static FileDescriptor Descriptor
		{
			get
			{
				return EIGCJPGPIOCReflection.descriptor;
			}
		}

		// Token: 0x04001259 RID: 4697
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFFSUdDSlBHUElPQy5wcm90bxoRS0lBTkVMUExDTUYucHJvdG8aEUxNUE9K",
			"R0VIRklQLnByb3RvIlcKC0VJR0NKUEdQSU9DEiUKD3JvZ3VlX2FyZWFfaW5m",
			"bxgIIAEoCzIMLkxNUE9KR0VIRklQEiEKC09KRkpGRUpNSlBHGAsgASgLMgwu",
			"S0lBTkVMUExDTUZCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			KIANELPLCMFReflection.Descriptor,
			LMPOJGEHFIPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EIGCJPGPIOC), EIGCJPGPIOC.Parser, new string[]
			{
				"RogueAreaInfo",
				"OJFJFEJMJPG"
			}, null, null, null, null)
		}));
	}
}
