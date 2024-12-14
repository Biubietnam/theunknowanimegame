using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011DE RID: 4574
	public static class StartWolfBroGameScRspReflection
	{
		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600CC82 RID: 52354 RVA: 0x00224E06 File Offset: 0x00223006
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartWolfBroGameScRspReflection.descriptor;
			}
		}

		// Token: 0x04005275 RID: 21109
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTdGFydFdvbGZCcm9HYW1lU2NSc3AucHJvdG8aFVdvbGZCcm9HYW1lRGF0" + "YS5wcm90byJWChVTdGFydFdvbGZCcm9HYW1lU2NSc3ASDwoHcmV0Y29kZRgH" + "IAEoDRIsChJ3b2xmX2Jyb19nYW1lX2RhdGEYCiABKAsyEC5Xb2xmQnJvR2Ft" + "ZURhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartWolfBroGameScRsp), StartWolfBroGameScRsp.Parser, new string[]
			{
				"Retcode",
				"WolfBroGameData"
			}, null, null, null, null)
		}));
	}
}
