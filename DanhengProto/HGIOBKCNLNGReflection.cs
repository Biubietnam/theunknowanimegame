using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E4 RID: 2276
	public static class HGIOBKCNLNGReflection
	{
		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x0010F712 File Offset: 0x0010D912
		public static FileDescriptor Descriptor
		{
			get
			{
				return HGIOBKCNLNGReflection.descriptor;
			}
		}

		// Token: 0x0400270B RID: 9995
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFIR0lPQktDTkxORy5wcm90byKMAQoLSEdJT0JLQ05MTkcSGQoRdW5sb2Nr",
			"ZWRfYWVvbl9udW0YCiABKA0SFAoMYWVvbl9pZF9saXN0GAMgAygNEhQKDGdh",
			"bWVfYWVvbl9pZBgNIAEoDRITCgtpc191bmxvY2tlZBgJIAEoCBIhChl1bmxv",
			"Y2tlZF9hZW9uX2VuaGFuY2VfbnVtGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HGIOBKCNLNG), HGIOBKCNLNG.Parser, new string[]
			{
				"UnlockedAeonNum",
				"AeonIdList",
				"GameAeonId",
				"IsUnlocked",
				"UnlockedAeonEnhanceNum"
			}, null, null, null, null)
		}));
	}
}
