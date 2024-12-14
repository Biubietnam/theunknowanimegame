using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008BC RID: 2236
	public static class HeliobusEnterBattleScRspReflection
	{
		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x060063B7 RID: 25527 RVA: 0x0010B205 File Offset: 0x00109405
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusEnterBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x04002673 RID: 9843
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5IZWxpb2J1c0VudGVyQmF0dGxlU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxl",
			"SW5mby5wcm90byJkChhIZWxpb2J1c0VudGVyQmF0dGxlU2NSc3ASJQoLYmF0",
			"dGxlX2luZm8YBiABKAsyEC5TY2VuZUJhdHRsZUluZm8SDwoHcmV0Y29kZRgK",
			"IAEoDRIQCghldmVudF9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusEnterBattleScRsp), HeliobusEnterBattleScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode",
				"EventId"
			}, null, null, null, null)
		}));
	}
}
