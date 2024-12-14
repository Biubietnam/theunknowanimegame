using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000576 RID: 1398
	public static class FinishEmotionDialoguePerformanceCsReqReflection
	{
		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06003E65 RID: 15973 RVA: 0x000AA8FD File Offset: 0x000A8AFD
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishEmotionDialoguePerformanceCsReqReflection.descriptor;
			}
		}

		// Token: 0x040018E7 RID: 6375
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitGaW5pc2hFbW90aW9uRGlhbG9ndWVQZXJmb3JtYW5jZUNzUmVxLnByb3Rv",
			"ImQKJUZpbmlzaEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlQ3NSZXESEwoL",
			"ZGlhbG9ndWVfaWQYAiABKA0SEQoJc2NyaXB0X2lkGAMgASgNEhMKC0ZQUEVG",
			"QktCRkREGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishEmotionDialoguePerformanceCsReq), FinishEmotionDialoguePerformanceCsReq.Parser, new string[]
			{
				"DialogueId",
				"ScriptId",
				"FPPEFBKBFDD"
			}, null, null, null, null)
		}));
	}
}
