using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CAC RID: 3244
	public static class PlayerAssistInfoReflection
	{
		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x06009032 RID: 36914 RVA: 0x0017CC44 File Offset: 0x0017AE44
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerAssistInfoReflection.descriptor;
			}
		}

		// Token: 0x0400376B RID: 14187
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZQbGF5ZXJBc3Npc3RJbmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZvLnBy",
			"b3RvGh1EaXNwbGF5QXZhdGFyRGV0YWlsSW5mby5wcm90byJrChBQbGF5ZXJB",
			"c3Npc3RJbmZvEi8KDWFzc2lzdF9hdmF0YXIYASABKAsyGC5EaXNwbGF5QXZh",
			"dGFyRGV0YWlsSW5mbxImCgtwbGF5ZXJfaW5mbxgFIAEoCzIRLlBsYXllclNp",
			"bXBsZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor,
			DisplayAvatarDetailInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerAssistInfo), PlayerAssistInfo.Parser, new string[]
			{
				"AssistAvatar",
				"PlayerInfo"
			}, null, null, null, null)
		}));
	}
}
