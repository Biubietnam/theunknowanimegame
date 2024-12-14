using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000860 RID: 2144
	public static class GiveUpBoxingClubChallengeScRspReflection
	{
		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06005F65 RID: 24421 RVA: 0x000FC61D File Offset: 0x000FA81D
		public static FileDescriptor Descriptor
		{
			get
			{
				return GiveUpBoxingClubChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x040024B3 RID: 9395
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRHaXZlVXBCb3hpbmdDbHViQ2hhbGxlbmdlU2NSc3AucHJvdG8aEUxKTExI",
			"SUpLS09ILnByb3RvIlIKHkdpdmVVcEJveGluZ0NsdWJDaGFsbGVuZ2VTY1Jz",
			"cBIPCgdyZXRjb2RlGAUgASgNEh8KCWNoYWxsZW5nZRgMIAEoCzIMLkxKTExI",
			"SUpLS09IQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			LJLLHIJKKOHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GiveUpBoxingClubChallengeScRsp), GiveUpBoxingClubChallengeScRsp.Parser, new string[]
			{
				"Retcode",
				"Challenge"
			}, null, null, null, null)
		}));
	}
}
