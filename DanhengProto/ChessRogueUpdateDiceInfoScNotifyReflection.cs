using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002AE RID: 686
	public static class ChessRogueUpdateDiceInfoScNotifyReflection
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00057E11 File Offset: 0x00056011
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateDiceInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000CC9 RID: 3273
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZDaGVzc1JvZ3VlVXBkYXRlRGljZUluZm9TY05vdGlmeS5wcm90bxoYQ2hl",
			"c3NSb2d1ZURpY2VJbmZvLnByb3RvIlAKIENoZXNzUm9ndWVVcGRhdGVEaWNl",
			"SW5mb1NjTm90aWZ5EiwKD3JvZ3VlX2RpY2VfaW5mbxgIIAEoCzITLkNoZXNz",
			"Um9ndWVEaWNlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueDiceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueUpdateDiceInfoScNotify), ChessRogueUpdateDiceInfoScNotify.Parser, new string[]
			{
				"RogueDiceInfo"
			}, null, null, null, null)
		}));
	}
}
