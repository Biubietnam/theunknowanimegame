using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B6 RID: 2230
	public static class HeliobusChallengeLineupReflection
	{
		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06006372 RID: 25458 RVA: 0x0010A736 File Offset: 0x00108936
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusChallengeLineupReflection.descriptor;
			}
		}

		// Token: 0x0400265A RID: 9818
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1IZWxpb2J1c0NoYWxsZW5nZUxpbmV1cC5wcm90byJRChdIZWxpb2J1c0No" + "YWxsZW5nZUxpbmV1cBIUCgxBdmF0YXJJZExpc3QYDyADKA0SDwoHU2tpbGxJ" + "ZBgDIAEoDRIPCgdHcm91cElkGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusChallengeLineup), HeliobusChallengeLineup.Parser, new string[]
			{
				"AvatarIdList",
				"SkillId",
				"GroupId"
			}, null, null, null, null)
		}));
	}
}
