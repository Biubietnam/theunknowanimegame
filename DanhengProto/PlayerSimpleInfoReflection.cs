using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CE6 RID: 3302
	public static class PlayerSimpleInfoReflection
	{
		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x06009362 RID: 37730 RVA: 0x00186C70 File Offset: 0x00184E70
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerSimpleInfoReflection.descriptor;
			}
		}

		// Token: 0x040038D9 RID: 14553
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvGhZBc3Npc3RTaW1wbGVJbmZvLnBy",
			"b3RvGhJQbGF0Zm9ybVR5cGUucHJvdG8aGEZyaWVuZE9ubGluZVN0YXR1cy5w",
			"cm90byLWAgoQUGxheWVyU2ltcGxlSW5mbxIyChdhc3Npc3Rfc2ltcGxlX2lu",
			"Zm9fbGlzdBgBIAMoCzIRLkFzc2lzdFNpbXBsZUluZm8SKgoNb25saW5lX3N0",
			"YXR1cxgDIAEoDjITLkZyaWVuZE9ubGluZVN0YXR1cxIRCgloZWFkX2ljb24Y",
			"AiABKA0SHwoIcGxhdGZvcm0YBCABKA4yDS5QbGF0Zm9ybVR5cGUSEQoJc2ln",
			"bmF0dXJlGAcgASgJEhEKCWlzX2Jhbm5lZBgNIAEoCBINCgVsZXZlbBgKIAEo",
			"DRIQCghuaWNrbmFtZRgGIAEoCRIYChBsYXN0X2FjdGl2ZV90aW1lGAwgASgD",
			"EgsKA3VpZBgOIAEoDRITCgtGTEZLQ0lIQ0VORhgFIAEoCRIWCg5jaGF0X2J1",
			"YmJsZV9pZBgIIAEoDRITCgtIRkhHUExNRUZHShgLIAEoCUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AssistSimpleInfoReflection.Descriptor,
			PlatformTypeReflection.Descriptor,
			FriendOnlineStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerSimpleInfo), PlayerSimpleInfo.Parser, new string[]
			{
				"AssistSimpleInfoList",
				"OnlineStatus",
				"HeadIcon",
				"Platform",
				"Signature",
				"IsBanned",
				"Level",
				"Nickname",
				"LastActiveTime",
				"Uid",
				"FLFKCIHCENF",
				"ChatBubbleId",
				"HFHGPLMEFGJ"
			}, null, null, null, null)
		}));
	}
}
