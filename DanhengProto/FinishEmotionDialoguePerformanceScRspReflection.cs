using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000578 RID: 1400
	public static class FinishEmotionDialoguePerformanceScRspReflection
	{
		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x000AAD08 File Offset: 0x000A8F08
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishEmotionDialoguePerformanceScRspReflection.descriptor;
			}
		}

		// Token: 0x040018F0 RID: 6384
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitGaW5pc2hFbW90aW9uRGlhbG9ndWVQZXJmb3JtYW5jZVNjUnNwLnByb3Rv",
			"Gg5JdGVtTGlzdC5wcm90byKAAQolRmluaXNoRW1vdGlvbkRpYWxvZ3VlUGVy",
			"Zm9ybWFuY2VTY1JzcBIPCgdyZXRjb2RlGAEgASgNEhMKC2RpYWxvZ3VlX2lk",
			"GAsgASgNEhEKCXNjcmlwdF9pZBgMIAEoDRIeCgtyZXdhcmRfbGlzdBgGIAEo",
			"CzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishEmotionDialoguePerformanceScRsp), FinishEmotionDialoguePerformanceScRsp.Parser, new string[]
			{
				"Retcode",
				"DialogueId",
				"ScriptId",
				"RewardList"
			}, null, null, null, null)
		}));
	}
}
