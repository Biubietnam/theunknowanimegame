using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E02 RID: 3586
	public static class RogueArcadeStartCsReqReflection
	{
		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0600A05F RID: 41055 RVA: 0x001AE4A8 File Offset: 0x001AC6A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueArcadeStartCsReqReflection.descriptor;
			}
		}

		// Token: 0x040041B1 RID: 16817
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZUFyY2FkZVN0YXJ0Q3NSZXEucHJvdG8iRQoVUm9ndWVBcmNhZGVT" + "dGFydENzUmVxEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYBCADKA0SDwoHcm9v" + "bV9pZBgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeStartCsReq), RogueArcadeStartCsReq.Parser, new string[]
			{
				"BaseAvatarIdList",
				"RoomId"
			}, null, null, null, null)
		}));
	}
}
