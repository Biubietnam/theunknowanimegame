using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200061C RID: 1564
	public static class GetAssistHistoryScRspReflection
	{
		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x000BFE82 File Offset: 0x000BE082
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAssistHistoryScRspReflection.descriptor;
			}
		}

		// Token: 0x04001C01 RID: 7169
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRBc3Npc3RIaXN0b3J5U2NSc3AucHJvdG8igwEKFUdldEFzc2lzdEhp",
			"c3RvcnlTY1JzcBIPCgdyZXRjb2RlGAUgASgNEhMKC0lFTUZJSkdOTUdGGAcg",
			"ASgNEhMKC0xMRktISENCREFGGAMgASgNEhoKEnRvZGF5X3VzZV91aWRfbGlz",
			"dBgOIAMoDRITCgtCRFBFQUJCSkVQTxgKIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAssistHistoryScRsp), GetAssistHistoryScRsp.Parser, new string[]
			{
				"Retcode",
				"IEMFIJGNMGF",
				"LLFKHHCBDAF",
				"TodayUseUidList",
				"BDPEABBJEPO"
			}, null, null, null, null)
		}));
	}
}
