using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000766 RID: 1894
	public static class GetPlayerBoardDataScRspReflection
	{
		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x000E3822 File Offset: 0x000E1A22
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPlayerBoardDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002137 RID: 8503
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRQbGF5ZXJCb2FyZERhdGFTY1JzcC5wcm90bxoWRGlzcGxheUF2YXRh",
			"clZlYy5wcm90bxoSSGVhZEljb25EYXRhLnByb3RvItkBChdHZXRQbGF5ZXJC",
			"b2FyZERhdGFTY1JzcBIdChVhc3Npc3RfYXZhdGFyX2lkX2xpc3QYDCADKA0S",
			"LQoSZGlzcGxheV9hdmF0YXJfdmVjGAcgASgLMhEuRGlzcGxheUF2YXRhclZl",
			"YxIPCgdyZXRjb2RlGA0gASgNEhwKFGN1cnJlbnRfaGVhZF9pY29uX2lkGAQg",
			"ASgNEhEKCXNpZ25hdHVyZRgOIAEoCRIuChd1bmxvY2tlZF9oZWFkX2ljb25f",
			"bGlzdBgPIAMoCzINLkhlYWRJY29uRGF0YUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			DisplayAvatarVecReflection.Descriptor,
			HeadIconDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerBoardDataScRsp), GetPlayerBoardDataScRsp.Parser, new string[]
			{
				"AssistAvatarIdList",
				"DisplayAvatarVec",
				"Retcode",
				"CurrentHeadIconId",
				"Signature",
				"UnlockedHeadIconList"
			}, null, null, null, null)
		}));
	}
}
