using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C2 RID: 2242
	public static class HeliobusSelectSkillCsReqReflection
	{
		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x060063FF RID: 25599 RVA: 0x0010BE11 File Offset: 0x0010A011
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusSelectSkillCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400268D RID: 9869
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5IZWxpb2J1c1NlbGVjdFNraWxsQ3NSZXEucHJvdG8iLAoYSGVsaW9idXNT" + "ZWxlY3RTa2lsbENzUmVxEhAKCHNraWxsX2lkGAIgASgNQh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSelectSkillCsReq), HeliobusSelectSkillCsReq.Parser, new string[]
			{
				"SkillId"
			}, null, null, null, null)
		}));
	}
}
