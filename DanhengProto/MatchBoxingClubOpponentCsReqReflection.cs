using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A96 RID: 2710
	public static class MatchBoxingClubOpponentCsReqReflection
	{
		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x0600781E RID: 30750 RVA: 0x0013E6CF File Offset: 0x0013C8CF
		public static FileDescriptor Descriptor
		{
			get
			{
				return MatchBoxingClubOpponentCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002E20 RID: 11808
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJNYXRjaEJveGluZ0NsdWJPcHBvbmVudENzUmVxLnByb3RvGhFCRkpCTE9D",
			"RUhKRy5wcm90byJsChxNYXRjaEJveGluZ0NsdWJPcHBvbmVudENzUmVxEhQK",
			"DGNoYWxsZW5nZV9pZBgDIAEoDRITCgthdmF0YXJfbGlzdBgBIAMoDRIhCgtI",
			"SE1GTUZIQ01PSxgEIAMoCzIMLkJGSkJMT0NFSEpHQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BFJBLOCEHJGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MatchBoxingClubOpponentCsReq), MatchBoxingClubOpponentCsReq.Parser, new string[]
			{
				"ChallengeId",
				"AvatarList",
				"HHMFMFHCMOK"
			}, null, null, null, null)
		}));
	}
}
