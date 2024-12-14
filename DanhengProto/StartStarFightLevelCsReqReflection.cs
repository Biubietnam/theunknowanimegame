using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C8 RID: 4552
	public static class StartStarFightLevelCsReqReflection
	{
		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600CB74 RID: 52084 RVA: 0x00222240 File Offset: 0x00220440
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartStarFightLevelCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005215 RID: 21013
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5TdGFydFN0YXJGaWdodExldmVsQ3NSZXEucHJvdG8aEUlQQ01FTUNIQ1BJ",
			"LnByb3RvImQKGFN0YXJ0U3RhckZpZ2h0TGV2ZWxDc1JlcRIQCghncm91cF9p",
			"ZBgOIAEoDRITCgtBSEZOR1BMREFJSRgKIAEoDRIhCgthdmF0YXJfbGlzdBgH",
			"IAMoCzIMLklQQ01FTUNIQ1BJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			IPCMEMCHCPIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartStarFightLevelCsReq), StartStarFightLevelCsReq.Parser, new string[]
			{
				"GroupId",
				"AHFNGPLDAII",
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
