using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D14 RID: 3348
	public static class PropExtraInfoReflection
	{
		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06009589 RID: 38281 RVA: 0x0018D559 File Offset: 0x0018B759
		public static FileDescriptor Descriptor
		{
			get
			{
				return PropExtraInfoReflection.descriptor;
			}
		}

		// Token: 0x040039EF RID: 14831
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNQcm9wRXh0cmFJbmZvLnByb3RvGhJQcm9wQWVvbkluZm8ucHJvdG8aGFJv",
			"Z3VlVG91cm5Eb29ySW5mby5wcm90bxoYUm9ndWVNYWdpY0Rvb3JJbmZvLnBy",
			"b3RvGhNQcm9wUm9ndWVJbmZvLnByb3RvGhxSb2d1ZUdhbWJsZU1hY2hpbmVJ",
			"bmZvLnByb3RvGhlSb2d1ZUN1cnNlQ2hlc3RJbmZvLnByb3RvGh1Sb2d1ZVRv",
			"dXJuV29ya2JlbmNoSW5mby5wcm90bxoYUHJvcENoZXNzUm9ndWVJbmZvLnBy",
			"b3RvIokDCg1Qcm9wRXh0cmFJbmZvEiEKCVJvZ3VlSW5mbxgNIAEoCzIOLlBy",
			"b3BSb2d1ZUluZm8SHwoIQWVvbkluZm8YAiABKAsyDS5Qcm9wQWVvbkluZm8S",
			"KwoOQ2hlc3NSb2d1ZUluZm8YBiABKAsyEy5Qcm9wQ2hlc3NSb2d1ZUluZm8S",
			"LwoSUm9ndWVUb3VybkRvb3JJbmZvGAcgASgLMhMuUm9ndWVUb3VybkRvb3JJ",
			"bmZvEjkKF1JvZ3VlVG91cm5Xb3JrYmVuY2hJbmZvGAQgASgLMhguUm9ndWVU",
			"b3VybldvcmtiZW5jaEluZm8SNwoWUm9ndWVHYW1ibGVNYWNoaW5lSW5mbxgK",
			"IAEoCzIXLlJvZ3VlR2FtYmxlTWFjaGluZUluZm8SMQoTUm9ndWVDdXJzZUNo",
			"ZXN0SW5mbxgIIAEoCzIULlJvZ3VlQ3Vyc2VDaGVzdEluZm8SLwoSUm9ndWVN",
			"YWdpY0Rvb3JJbmZvGAMgASgLMhMuUm9ndWVNYWdpY0Rvb3JJbmZvQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PropAeonInfoReflection.Descriptor,
			RogueTournDoorInfoReflection.Descriptor,
			RogueMagicDoorInfoReflection.Descriptor,
			PropRogueInfoReflection.Descriptor,
			RogueGambleMachineInfoReflection.Descriptor,
			RogueCurseChestInfoReflection.Descriptor,
			RogueTournWorkbenchInfoReflection.Descriptor,
			PropChessRogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PropExtraInfo), PropExtraInfo.Parser, new string[]
			{
				"RogueInfo",
				"AeonInfo",
				"ChessRogueInfo",
				"RogueTournDoorInfo",
				"RogueTournWorkbenchInfo",
				"RogueGambleMachineInfo",
				"RogueCurseChestInfo",
				"RogueMagicDoorInfo"
			}, null, null, null, null)
		}));
	}
}
