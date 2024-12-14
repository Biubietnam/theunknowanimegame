using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001196 RID: 4502
	public static class StartAetherDivideStageBattleScRspReflection
	{
		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600C901 RID: 51457 RVA: 0x0021B3C2 File Offset: 0x002195C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideStageBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x0400511E RID: 20766
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidTdGFydEFldGhlckRpdmlkZVN0YWdlQmF0dGxlU2NSc3AucHJvdG8aHEFl",
			"dGhlckRpdmlkZUJhdHRsZUluZm8ucHJvdG8iYgohU3RhcnRBZXRoZXJEaXZp",
			"ZGVTdGFnZUJhdHRsZVNjUnNwEiwKC2JhdHRsZV9pbmZvGAwgASgLMhcuQWV0",
			"aGVyRGl2aWRlQmF0dGxlSW5mbxIPCgdyZXRjb2RlGA4gASgNQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			AetherDivideBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideStageBattleScRsp), StartAetherDivideStageBattleScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
