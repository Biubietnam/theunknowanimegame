using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000018 RID: 24
	public static class AcceptMainMissionCsReqReflection
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003E78 File Offset: 0x00002078
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptMainMissionCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400004A RID: 74
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBY2NlcHRNYWluTWlzc2lvbkNzUmVxLnByb3RvIjEKFkFjY2VwdE1haW5N" + "aXNzaW9uQ3NSZXESFwoPbWFpbl9taXNzaW9uX2lkGAEgASgNQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMainMissionCsReq), AcceptMainMissionCsReq.Parser, new string[]
			{
				"MainMissionId"
			}, null, null, null, null)
		}));
	}
}
