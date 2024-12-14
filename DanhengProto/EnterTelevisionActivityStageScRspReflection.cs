using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000478 RID: 1144
	public static class EnterTelevisionActivityStageScRspReflection
	{
		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x0008C3E7 File Offset: 0x0008A5E7
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterTelevisionActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x0400144C RID: 5196
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidFbnRlclRlbGV2aXNpb25BY3Rpdml0eVN0YWdlU2NSc3AucHJvdG8aFVNj",
			"ZW5lQmF0dGxlSW5mby5wcm90byJwCiFFbnRlclRlbGV2aXNpb25BY3Rpdml0",
			"eVN0YWdlU2NSc3ASEwoLRE5GSk9PQUpJS0cYASABKA0SDwoHcmV0Y29kZRgI",
			"IAEoDRIlCgtiYXR0bGVfaW5mbxgGIAEoCzIQLlNjZW5lQmF0dGxlSW5mb0Ie",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterTelevisionActivityStageScRsp), EnterTelevisionActivityStageScRsp.Parser, new string[]
			{
				"DNFJOOAJIKG",
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
