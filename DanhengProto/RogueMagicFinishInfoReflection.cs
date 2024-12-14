using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ECE RID: 3790
	public static class RogueMagicFinishInfoReflection
	{
		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0600A969 RID: 43369 RVA: 0x001C830E File Offset: 0x001C650E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicFinishInfoReflection.descriptor;
			}
		}

		// Token: 0x04004525 RID: 17701
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljRmluaXNoSW5mby5wcm90bxoRTE1QRUNKTU1CSFAucHJv",
			"dG8aF1JvZ3VlTWFnaWNDdXJJbmZvLnByb3RvGhFDT0ZPRkRGUExCRS5wcm90",
			"bxoQTGluZXVwSW5mby5wcm90byK2AQoUUm9ndWVNYWdpY0ZpbmlzaEluZm8S",
			"IQoLTEFJT0tMSk5QRk8YCSABKAsyDC5DT0ZPRkRGUExCRRIwChRyb2d1ZV90",
			"b3Vybl9jdXJfaW5mbxgNIAEoCzISLlJvZ3VlTWFnaWNDdXJJbmZvEiYKEXJv",
			"Z3VlX2xpbmV1cF9pbmZvGA8gASgLMgsuTGluZXVwSW5mbxIhCgtPR0lPTkVP",
			"T0ZJThgBIAEoCzIMLkxNUEVDSk1NQkhQQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			LMPECJMMBHPReflection.Descriptor,
			RogueMagicCurInfoReflection.Descriptor,
			COFOFDFPLBEReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicFinishInfo), RogueMagicFinishInfo.Parser, new string[]
			{
				"LAIOKLJNPFO",
				"RogueTournCurInfo",
				"RogueLineupInfo",
				"OGIONEOOFIN"
			}, null, null, null, null)
		}));
	}
}
