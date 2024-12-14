using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D6 RID: 2006
	public static class GetRogueTalentInfoScRspReflection
	{
		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x000EECB6 File Offset: 0x000ECEB6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueTalentInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x040022C5 RID: 8901
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRSb2d1ZVRhbGVudEluZm9TY1JzcC5wcm90bxoZUm9ndWVUYWxlbnRJ",
			"bmZvTGlzdC5wcm90byJaChdHZXRSb2d1ZVRhbGVudEluZm9TY1JzcBIuChB0",
			"YWxlbnRfaW5mb19saXN0GA8gASgLMhQuUm9ndWVUYWxlbnRJbmZvTGlzdBIP",
			"CgdyZXRjb2RlGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueTalentInfoScRsp), GetRogueTalentInfoScRsp.Parser, new string[]
			{
				"TalentInfoList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
