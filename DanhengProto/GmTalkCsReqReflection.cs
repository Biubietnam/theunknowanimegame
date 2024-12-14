using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000868 RID: 2152
	public static class GmTalkCsReqReflection
	{
		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x000FD09C File Offset: 0x000FB29C
		public static FileDescriptor Descriptor
		{
			get
			{
				return GmTalkCsReqReflection.descriptor;
			}
		}

		// Token: 0x040024CD RID: 9421
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHbVRhbGtDc1JlcS5wcm90byIaCgtHbVRhbGtDc1JlcRILCgNtc2cYCSAB" + "KAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GmTalkCsReq), GmTalkCsReq.Parser, new string[]
			{
				"Msg"
			}, null, null, null, null)
		}));
	}
}
