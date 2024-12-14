using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000276 RID: 630
	public static class ChessRogueQueryDiceInfoReflection
	{
		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0005062E File Offset: 0x0004E82E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryDiceInfoReflection.descriptor;
			}
		}

		// Token: 0x04000BBA RID: 3002
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1DaGVzc1JvZ3VlUXVlcnlEaWNlSW5mby5wcm90bxodQ2hlc3NSb2d1ZU5v",
			"dXNEaWNlUGhhc2UucHJvdG8aFENoZXNzUm9ndWVEaWNlLnByb3RvIuABChdD",
			"aGVzc1JvZ3VlUXVlcnlEaWNlSW5mbxIuCgNzdXMYDCADKAsyIS5DaGVzc1Jv",
			"Z3VlUXVlcnlEaWNlSW5mby5TdXNFbnRyeRIsCgpkaWNlX3BoYXNlGAogASgO",
			"MhguQ2hlc3NSb2d1ZU5vdXNEaWNlUGhhc2USIgoJZGljZV9saXN0GAEgAygL",
			"Mg8uQ2hlc3NSb2d1ZURpY2USFwoPc3VyZmFjZV9pZF9saXN0GAMgAygNGioK",
			"CFN1c0VudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoCDoCOAFCHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueNousDicePhaseReflection.Descriptor,
			ChessRogueDiceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryDiceInfo), ChessRogueQueryDiceInfo.Parser, new string[]
			{
				"Sus",
				"DicePhase",
				"DiceList",
				"SurfaceIdList"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
