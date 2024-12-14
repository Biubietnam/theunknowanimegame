using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FC2 RID: 4034
	public static class RogueTournGetAllArchiveScRspReflection
	{
		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600B3C2 RID: 46018 RVA: 0x001E2A32 File Offset: 0x001E0C32
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournGetAllArchiveScRspReflection.descriptor;
			}
		}

		// Token: 0x040048EE RID: 18670
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZVRvdXJuR2V0QWxsQXJjaGl2ZVNjUnNwLnByb3RvGhhSb2d1ZVRv",
			"dXJuU2F2ZUxpc3QucHJvdG8iWQocUm9ndWVUb3VybkdldEFsbEFyY2hpdmVT",
			"Y1JzcBIoCgtBTUZEQVBCTURBTRgBIAMoCzITLlJvZ3VlVG91cm5TYXZlTGlz",
			"dBIPCgdyZXRjb2RlGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournSaveListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetAllArchiveScRsp), RogueTournGetAllArchiveScRsp.Parser, new string[]
			{
				"AMFDAPBMDAM",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
