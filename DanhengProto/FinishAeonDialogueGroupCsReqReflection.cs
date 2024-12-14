using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200055E RID: 1374
	public static class FinishAeonDialogueGroupCsReqReflection
	{
		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x000A7DE4 File Offset: 0x000A5FE4
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishAeonDialogueGroupCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400188A RID: 6282
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGaW5pc2hBZW9uRGlhbG9ndWVHcm91cENzUmVxLnByb3RvIi8KHEZpbmlz" + "aEFlb25EaWFsb2d1ZUdyb3VwQ3NSZXESDwoHYWVvbl9pZBgMIAEoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishAeonDialogueGroupCsReq), FinishAeonDialogueGroupCsReq.Parser, new string[]
			{
				"AeonId"
			}, null, null, null, null)
		}));
	}
}
