using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200027C RID: 636
	public static class ChessRogueQueryScRspReflection
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00051650 File Offset: 0x0004F850
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryScRspReflection.descriptor;
			}
		}

		// Token: 0x04000BE1 RID: 3041
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlUXVlcnlTY1JzcC5wcm90bxoaQ2hlc3NSb2d1ZUZpbmlz",
			"aEluZm8ucHJvdG8aG0NoZXNzUm9ndWVDdXJyZW50SW5mby5wcm90bxoYQ2hl",
			"c3NSb2d1ZUdhbWVJbmZvLnByb3RvGhdDaGVzc1JvZ3VlR2V0SW5mby5wcm90",
			"bxoZQ2hlc3NSb2d1ZVF1ZXJ5SW5mby5wcm90byKAAgoUQ2hlc3NSb2d1ZVF1",
			"ZXJ5U2NSc3ASKgoOcm9ndWVfZ2V0X2luZm8YCyABKAsyEi5DaGVzc1JvZ3Vl",
			"R2V0SW5mbxIyChJyb2d1ZV9jdXJyZW50X2luZm8YCSABKAsyFi5DaGVzc1Jv",
			"Z3VlQ3VycmVudEluZm8SIQoEaW5mbxgMIAEoCzITLkNoZXNzUm9ndWVHYW1l",
			"SW5mbxIqCgtmaW5pc2hfaW5mbxgHIAEoCzIVLkNoZXNzUm9ndWVGaW5pc2hJ",
			"bmZvEigKCnF1ZXJ5X2luZm8YASABKAsyFC5DaGVzc1JvZ3VlUXVlcnlJbmZv",
			"Eg8KB3JldGNvZGUYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueFinishInfoReflection.Descriptor,
			ChessRogueCurrentInfoReflection.Descriptor,
			ChessRogueGameInfoReflection.Descriptor,
			ChessRogueGetInfoReflection.Descriptor,
			ChessRogueQueryInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryScRsp), ChessRogueQueryScRsp.Parser, new string[]
			{
				"RogueGetInfo",
				"RogueCurrentInfo",
				"Info",
				"FinishInfo",
				"QueryInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
