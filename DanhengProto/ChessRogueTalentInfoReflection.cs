using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A4 RID: 676
	public static class ChessRogueTalentInfoReflection
	{
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00056E8A File Offset: 0x0005508A
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueTalentInfoReflection.descriptor;
			}
		}

		// Token: 0x04000CA9 RID: 3241
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlVGFsZW50SW5mby5wcm90bxoZUm9ndWVUYWxlbnRJbmZv",
			"TGlzdC5wcm90byJhChRDaGVzc1JvZ3VlVGFsZW50SW5mbxI0ChZyb2d1ZV90",
			"YWxlbnRfaW5mb19saXN0GAQgASgLMhQuUm9ndWVUYWxlbnRJbmZvTGlzdBIT",
			"CgtGQ0FBR0xLRkFJRBgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueTalentInfo), ChessRogueTalentInfo.Parser, new string[]
			{
				"RogueTalentInfoList",
				"FCAAGLKFAID"
			}, null, null, null, null)
		}));
	}
}
