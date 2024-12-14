using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000314 RID: 788
	public static class CommonRogueQueryScRspReflection
	{
		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x0006461A File Offset: 0x0006281A
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonRogueQueryScRspReflection.descriptor;
			}
		}

		// Token: 0x04000E86 RID: 3718
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtDb21tb25Sb2d1ZVF1ZXJ5U2NSc3AucHJvdG8aEUVJR0NKUEdQSU9DLnBy",
			"b3RvImMKFUNvbW1vblJvZ3VlUXVlcnlTY1JzcBITCgtLQUFHSUVLRU9ORBgK",
			"IAEoDRIkCg5yb2d1ZV9nZXRfaW5mbxgCIAEoCzIMLkVJR0NKUEdQSU9DEg8K",
			"B3JldGNvZGUYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			EIGCJPGPIOCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CommonRogueQueryScRsp), CommonRogueQueryScRsp.Parser, new string[]
			{
				"KAAGIEKEOND",
				"RogueGetInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
