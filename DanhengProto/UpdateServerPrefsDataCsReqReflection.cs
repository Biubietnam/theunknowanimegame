using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F8 RID: 5112
	public static class UpdateServerPrefsDataCsReqReflection
	{
		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x0025E3A8 File Offset: 0x0025C5A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateServerPrefsDataCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005A96 RID: 23190
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVTZXJ2ZXJQcmVmc0RhdGFDc1JlcS5wcm90bxoRU2VydmVyUHJl" + "ZnMucHJvdG8iQAoaVXBkYXRlU2VydmVyUHJlZnNEYXRhQ3NSZXESIgoMc2Vy" + "dmVyX3ByZWZzGAsgASgLMgwuU2VydmVyUHJlZnNCHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ServerPrefsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateServerPrefsDataCsReq), UpdateServerPrefsDataCsReq.Parser, new string[]
			{
				"ServerPrefs"
			}, null, null, null, null)
		}));
	}
}
