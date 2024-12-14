using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE8 RID: 4072
	public static class RogueTournLeaveScRspReflection
	{
		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600B545 RID: 46405 RVA: 0x001E6848 File Offset: 0x001E4A48
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournLeaveScRspReflection.descriptor;
			}
		}

		// Token: 0x04004982 RID: 18818
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVRvdXJuTGVhdmVTY1JzcC5wcm90bxocUm9ndWVUb3VybkN1clNj",
			"ZW5lSW5mby5wcm90byJkChRSb2d1ZVRvdXJuTGVhdmVTY1JzcBIPCgdyZXRj",
			"b2RlGAEgASgNEjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGA4gASgL",
			"MhcuUm9ndWVUb3VybkN1clNjZW5lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLeaveScRsp), RogueTournLeaveScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
