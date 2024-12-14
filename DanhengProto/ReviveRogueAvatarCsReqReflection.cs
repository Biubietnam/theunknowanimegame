using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DDE RID: 3550
	public static class ReviveRogueAvatarCsReqReflection
	{
		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x06009EB0 RID: 40624 RVA: 0x001A892B File Offset: 0x001A6B2B
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReviveRogueAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400411C RID: 16668
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSZXZpdmVSb2d1ZUF2YXRhckNzUmVxLnByb3RvIo4BChZSZXZpdmVSb2d1",
			"ZUF2YXRhckNzUmVxEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYAiADKA0SHAoU",
			"dHJpYWxfYXZhdGFyX2lkX2xpc3QYBSADKA0SIQoZaW50ZXJhY3RlZF9wcm9w",
			"X2VudGl0eV9pZBgIIAEoDRIWCg5iYXNlX2F2YXRhcl9pZBgGIAEoDUIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReviveRogueAvatarCsReq), ReviveRogueAvatarCsReq.Parser, new string[]
			{
				"BaseAvatarIdList",
				"TrialAvatarIdList",
				"InteractedPropEntityId",
				"BaseAvatarId"
			}, null, null, null, null)
		}));
	}
}
