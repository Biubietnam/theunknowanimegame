using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF8 RID: 3832
	public static class RogueMagicReviveAvatarScRspReflection
	{
		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0600AB30 RID: 43824 RVA: 0x001CD223 File Offset: 0x001CB423
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicReviveAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x040045DF RID: 17887
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSb2d1ZU1hZ2ljUmV2aXZlQXZhdGFyU2NSc3AucHJvdG8aEkl0ZW1Db3N0",
			"RGF0YS5wcm90byJYChtSb2d1ZU1hZ2ljUmV2aXZlQXZhdGFyU2NSc3ASDwoH",
			"cmV0Y29kZRgPIAEoDRIoChFyb2d1ZV9yZXZpdmVfY29zdBgOIAEoCzINLkl0",
			"ZW1Db3N0RGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicReviveAvatarScRsp), RogueMagicReviveAvatarScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueReviveCost"
			}, null, null, null, null)
		}));
	}
}
