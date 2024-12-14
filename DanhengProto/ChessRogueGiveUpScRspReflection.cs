using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000228 RID: 552
	public static class ChessRogueGiveUpScRspReflection
	{
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00048676 File Offset: 0x00046876
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueGiveUpScRspReflection.descriptor;
			}
		}

		// Token: 0x04000A9D RID: 2717
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtDaGVzc1JvZ3VlR2l2ZVVwU2NSc3AucHJvdG8aGENoZXNzUm9ndWVBZW9u",
			"SW5mby5wcm90bxoaQ2hlc3NSb2d1ZUZpbmlzaEluZm8ucHJvdG8aF0NoZXNz",
			"Um9ndWVHZXRJbmZvLnByb3RvGhlDaGVzc1JvZ3VlUXVlcnlJbmZvLnByb3Rv",
			"GhRDaGVzc1JvZ3VlSW5mby5wcm90byL9AQoVQ2hlc3NSb2d1ZUdpdmVVcFNj",
			"UnNwEioKDnJvZ3VlX2dldF9pbmZvGA8gASgLMhIuQ2hlc3NSb2d1ZUdldElu",
			"Zm8SDwoHcmV0Y29kZRgMIAEoDRIjCgpzdGFnZV9pbmZvGA4gASgLMg8uQ2hl",
			"c3NSb2d1ZUluZm8SLAoPcm9ndWVfYWVvbl9pbmZvGAogASgLMhMuQ2hlc3NS",
			"b2d1ZUFlb25JbmZvEigKCnF1ZXJ5X2luZm8YAyABKAsyFC5DaGVzc1JvZ3Vl",
			"UXVlcnlJbmZvEioKC2ZpbmlzaF9pbmZvGAsgASgLMhUuQ2hlc3NSb2d1ZUZp",
			"bmlzaEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			ChessRogueAeonInfoReflection.Descriptor,
			ChessRogueFinishInfoReflection.Descriptor,
			ChessRogueGetInfoReflection.Descriptor,
			ChessRogueQueryInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGiveUpScRsp), ChessRogueGiveUpScRsp.Parser, new string[]
			{
				"RogueGetInfo",
				"Retcode",
				"StageInfo",
				"RogueAeonInfo",
				"QueryInfo",
				"FinishInfo"
			}, null, null, null, null)
		}));
	}
}
