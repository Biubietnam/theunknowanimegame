using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D8 RID: 4312
	public static class SetClientPausedCsReqReflection
	{
		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600C050 RID: 49232 RVA: 0x002058A0 File Offset: 0x00203AA0
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetClientPausedCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004E00 RID: 19968
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRDbGllbnRQYXVzZWRDc1JlcS5wcm90byImChRTZXRDbGllbnRQYXVz" + "ZWRDc1JlcRIOCgZwYXVzZWQYDyABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetClientPausedCsReq), SetClientPausedCsReq.Parser, new string[]
			{
				"Paused"
			}, null, null, null, null)
		}));
	}
}
