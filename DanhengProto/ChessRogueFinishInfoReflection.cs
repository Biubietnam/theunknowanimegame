using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200021A RID: 538
	public static class ChessRogueFinishInfoReflection
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00045055 File Offset: 0x00043255
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueFinishInfoReflection.descriptor;
			}
		}

		// Token: 0x04000A28 RID: 2600
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlRmluaXNoSW5mby5wcm90bxoQTGluZXVwSW5mby5wcm90",
			"bxoZQ2hlc3NSb2d1ZVN0b3J5SW5mby5wcm90bxoaQ2hlc3NSb2d1ZVF1aXRS",
			"ZWFzb24ucHJvdG8aDkl0ZW1MaXN0LnByb3RvGhRDaGVzc1JvZ3VlQnVmZi5w",
			"cm90bxoXQ2hlc3NSb2d1ZU1pcmFjbGUucHJvdG8itQQKFENoZXNzUm9ndWVG",
			"aW5pc2hJbmZvEioKC3F1aXRfcmVhc29uGAsgASgOMhUuQ2hlc3NSb2d1ZVF1",
			"aXRSZWFzb24SEQoJaXNfZmluaXNoGAEgASgIEhQKC0JOTU5GRUtNQ05NGMMJ",
			"IAEoDRIeCgtPRVBGR0hCQUpPTxgIIAEoCzIJLkl0ZW1MaXN0EiEKGWNoZXNz",
			"X3JvZ3VlX21haW5fc3RvcnlfaWQYAiABKA0SIQoMcm9ndWVfbGluZXVwGAUg",
			"ASgLMgsuTGluZXVwSW5mbxITCgtIQkxIUE9MRURHQRgKIAMoDRIYChBkaWZm",
			"aWN1bHR5X2xldmVsGAMgASgNEhMKC0hMQ0RPQURFSUpJGAQgASgNEigKD3Jv",
			"Z3VlX2J1ZmZfaW5mbxgNIAEoCzIPLkNoZXNzUm9ndWVCdWZmEhMKC0ZHR0pF",
			"R0ZNTUFPGAkgASgNEi4KEHJvZ3VlX3N0b3J5X2luZm8YLiABKAsyFC5DaGVz",
			"c1JvZ3VlU3RvcnlJbmZvEhMKC09BS0NIQkRORUlDGAcgASgNEhQKC0dFRlBK",
			"S0dKTEVPGIoMIAEoDRItChFnYW1lX21pcmFjbGVfaW5mbxgPIAEoCzISLkNo",
			"ZXNzUm9ndWVNaXJhY2xlEhEKCHNjb3JlX2lkGMABIAEoDRIUCgtITUdITUpM",
			"TEhLQxjxCiABKA0SEwoLR0FGQ09ET1BBTUYYDCABKA0SFwoOcm9ndWVfc3Vi",
			"X21vZGUYpwogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			ChessRogueStoryInfoReflection.Descriptor,
			ChessRogueQuitReasonReflection.Descriptor,
			ItemListReflection.Descriptor,
			ChessRogueBuffReflection.Descriptor,
			ChessRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueFinishInfo), ChessRogueFinishInfo.Parser, new string[]
			{
				"QuitReason",
				"IsFinish",
				"BNMNFEKMCNM",
				"OEPFGHBAJOO",
				"ChessRogueMainStoryId",
				"RogueLineup",
				"HBLHPOLEDGA",
				"DifficultyLevel",
				"HLCDOADEIJI",
				"RogueBuffInfo",
				"FGGJEGFMMAO",
				"RogueStoryInfo",
				"OAKCHBDNEIC",
				"GEFPJKGJLEO",
				"GameMiracleInfo",
				"ScoreId",
				"HMGHMJLLHKC",
				"GAFCODOPAMF",
				"RogueSubMode"
			}, null, null, null, null)
		}));
	}
}
