using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200066C RID: 1644
	public static class GetCurAssistScRspReflection
	{
		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x000C8DEE File Offset: 0x000C6FEE
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetCurAssistScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D53 RID: 7507
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdHZXRDdXJBc3Npc3RTY1JzcC5wcm90bxoWUGxheWVyQXNzaXN0SW5mby5w",
			"cm90byJbChFHZXRDdXJBc3Npc3RTY1JzcBIPCgdyZXRjb2RlGAEgASgNEjUK",
			"GkZSSUVORF9BUFBMWV9TT1VSQ0VfQVNTSVNUGA8gASgLMhEuUGxheWVyQXNz",
			"aXN0SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			PlayerAssistInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetCurAssistScRsp), GetCurAssistScRsp.Parser, new string[]
			{
				"Retcode",
				"FRIENDAPPLYSOURCEASSIST"
			}, null, null, null, null)
		}));
	}
}
