using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006FE RID: 1790
	public static class GetLoginActivityScRspReflection
	{
		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06005009 RID: 20489 RVA: 0x000D7D22 File Offset: 0x000D5F22
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetLoginActivityScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F7C RID: 8060
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRMb2dpbkFjdGl2aXR5U2NSc3AucHJvdG8aF0xvZ2luQWN0aXZpdHlE",
			"YXRhLnByb3RvIlkKFUdldExvZ2luQWN0aXZpdHlTY1JzcBIPCgdyZXRjb2Rl",
			"GAUgASgNEi8KE2xvZ2luX2FjdGl2aXR5X2xpc3QYBiADKAsyEi5Mb2dpbkFj",
			"dGl2aXR5RGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			LoginActivityDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetLoginActivityScRsp), GetLoginActivityScRsp.Parser, new string[]
			{
				"Retcode",
				"LoginActivityList"
			}, null, null, null, null)
		}));
	}
}
