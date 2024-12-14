using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E04 RID: 3588
	public static class RogueArcadeStartScRspReflection
	{
		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0600A075 RID: 41077 RVA: 0x001AE7F3 File Offset: 0x001AC9F3
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueArcadeStartScRspReflection.descriptor;
			}
		}

		// Token: 0x040041B9 RID: 16825
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZUFyY2FkZVN0YXJ0U2NSc3AucHJvdG8aEUlLRU5BQUpEQUZGLnBy",
			"b3RvImsKFVJvZ3VlQXJjYWRlU3RhcnRTY1JzcBIwChpyb2d1ZV90b3Vybl9j",
			"dXJfc2NlbmVfaW5mbxgIIAEoCzIMLklLRU5BQUpEQUZGEg8KB3JldGNvZGUY",
			"DyABKA0SDwoHcm9vbV9pZBgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			IKENAAJDAFFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeStartScRsp), RogueArcadeStartScRsp.Parser, new string[]
			{
				"RogueTournCurSceneInfo",
				"Retcode",
				"RoomId"
			}, null, null, null, null)
		}));
	}
}
