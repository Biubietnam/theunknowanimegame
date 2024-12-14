using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CBC RID: 3260
	public static class PlayerHeartBeatCsReqReflection
	{
		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600912C RID: 37164 RVA: 0x001803E2 File Offset: 0x0017E5E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerHeartBeatCsReqReflection.descriptor;
			}
		}

		// Token: 0x040037ED RID: 14317
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpQbGF5ZXJIZWFydEJlYXRDc1JlcS5wcm90bxoWQ2xpZW50VXBsb2FkRGF0",
			"YS5wcm90byJrChRQbGF5ZXJIZWFydEJlYXRDc1JlcRIWCg5jbGllbnRfdGlt",
			"ZV9tcxgGIAEoBBITCgtDQU5EUEpNREVBRBgBIAEoDRImCgtMRkVJT0ZJSEpB",
			"QhgLIAEoCzIRLkNsaWVudFVwbG9hZERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ClientUploadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerHeartBeatCsReq), PlayerHeartBeatCsReq.Parser, new string[]
			{
				"ClientTimeMs",
				"CANDPJMDEAD",
				"LFEIOFIHJAB"
			}, null, null, null, null)
		}));
	}
}
