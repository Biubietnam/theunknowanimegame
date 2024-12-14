using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001192 RID: 4498
	public static class StartAetherDivideSceneBattleScRspReflection
	{
		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x0021ACEB File Offset: 0x00218EEB
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideSceneBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x04005110 RID: 20752
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlU2NSc3AucHJvdG8aHEFl",
			"dGhlckRpdmlkZUJhdHRsZUluZm8ucHJvdG8iegohU3RhcnRBZXRoZXJEaXZp",
			"ZGVTY2VuZUJhdHRsZVNjUnNwEiwKC2JhdHRsZV9pbmZvGAEgASgLMhcuQWV0",
			"aGVyRGl2aWRlQmF0dGxlSW5mbxIWCg5jYXN0X2VudGl0eV9pZBgNIAEoDRIP",
			"CgdyZXRjb2RlGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			AetherDivideBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideSceneBattleScRsp), StartAetherDivideSceneBattleScRsp.Parser, new string[]
			{
				"BattleInfo",
				"CastEntityId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
