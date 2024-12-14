using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001050 RID: 4176
	public static class SceneCastSkillCostMpCsReqReflection
	{
		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x001F3798 File Offset: 0x001F1998
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillCostMpCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004B5B RID: 19291
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TY2VuZUNhc3RTa2lsbENvc3RNcENzUmVxLnByb3RvImcKGVNjZW5lQ2Fz" + "dFNraWxsQ29zdE1wQ3NSZXESHQoVYXR0YWNrZWRfYnlfZW50aXR5X2lkGAog" + "ASgNEhMKC3NraWxsX2luZGV4GAMgASgNEhYKDmNhc3RfZW50aXR5X2lkGAsg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillCostMpCsReq), SceneCastSkillCostMpCsReq.Parser, new string[]
			{
				"AttackedByEntityId",
				"SkillIndex",
				"CastEntityId"
			}, null, null, null, null)
		}));
	}
}
