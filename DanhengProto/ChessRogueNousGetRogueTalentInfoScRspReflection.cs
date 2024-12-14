using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200025A RID: 602
	public static class ChessRogueNousGetRogueTalentInfoScRspReflection
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0004DF2E File Offset: 0x0004C12E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04000B64 RID: 2916
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitDaGVzc1JvZ3VlTm91c0dldFJvZ3VlVGFsZW50SW5mb1NjUnNwLnByb3Rv",
			"GhlSb2d1ZVRhbGVudEluZm9MaXN0LnByb3RvIn0KJUNoZXNzUm9ndWVOb3Vz",
			"R2V0Um9ndWVUYWxlbnRJbmZvU2NSc3ASEwoLRkNBQUdMS0ZBSUQYCCABKA0S",
			"LgoQdGFsZW50X2luZm9fbGlzdBgGIAEoCzIULlJvZ3VlVGFsZW50SW5mb0xp",
			"c3QSDwoHcmV0Y29kZRgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousGetRogueTalentInfoScRsp), ChessRogueNousGetRogueTalentInfoScRsp.Parser, new string[]
			{
				"FCAAGLKFAID",
				"TalentInfoList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
