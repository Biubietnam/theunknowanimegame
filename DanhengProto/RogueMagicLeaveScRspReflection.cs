using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EEC RID: 3820
	public static class RogueMagicLeaveScRspReflection
	{
		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0600AAB7 RID: 43703 RVA: 0x001CBDDE File Offset: 0x001C9FDE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicLeaveScRspReflection.descriptor;
			}
		}

		// Token: 0x040045AE RID: 17838
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljTGVhdmVTY1JzcC5wcm90bxocUm9ndWVNYWdpY0N1clNj",
			"ZW5lSW5mby5wcm90byJkChRSb2d1ZU1hZ2ljTGVhdmVTY1JzcBIPCgdyZXRj",
			"b2RlGAIgASgNEjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGA4gASgL",
			"MhcuUm9ndWVNYWdpY0N1clNjZW5lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicLeaveScRsp), RogueMagicLeaveScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
