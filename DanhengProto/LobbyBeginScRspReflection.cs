using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A2C RID: 2604
	public static class LobbyBeginScRspReflection
	{
		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x060073BC RID: 29628 RVA: 0x00133CDE File Offset: 0x00131EDE
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyBeginScRspReflection.descriptor;
			}
		}

		// Token: 0x04002C7C RID: 11388
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVMb2JieUJlZ2luU2NSc3AucHJvdG8aEUNDSENQTkxQQkRLLnByb3RvIkUK" + "D0xvYmJ5QmVnaW5TY1JzcBIPCgdyZXRjb2RlGA8gASgNEiEKC0VCTU9LUEJL" + "TU1EGAogAygLMgwuQ0NIQ1BOTFBCREtCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			CCHCPNLPBDKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyBeginScRsp), LobbyBeginScRsp.Parser, new string[]
			{
				"Retcode",
				"EBMOKPBKMMD"
			}, null, null, null, null)
		}));
	}
}
