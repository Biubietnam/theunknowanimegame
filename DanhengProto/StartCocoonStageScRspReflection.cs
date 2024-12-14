using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011AA RID: 4522
	public static class StartCocoonStageScRspReflection
	{
		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600C9F0 RID: 51696 RVA: 0x0021DADA File Offset: 0x0021BCDA
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartCocoonStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04005173 RID: 20851
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtTdGFydENvY29vblN0YWdlU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxlSW5m",
			"by5wcm90byKEAQoVU3RhcnRDb2Nvb25TdGFnZVNjUnNwEgwKBFdhdmUYCSAB",
			"KA0SFAoMUHJvcEVudGl0eUlkGAQgASgNEiQKCkJhdHRsZUluZm8YByABKAsy",
			"EC5TY2VuZUJhdHRsZUluZm8SEAoIQ29jb29uSWQYDiABKA0SDwoHcmV0Y29k",
			"ZRgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartCocoonStageScRsp), StartCocoonStageScRsp.Parser, new string[]
			{
				"Wave",
				"PropEntityId",
				"BattleInfo",
				"CocoonId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
