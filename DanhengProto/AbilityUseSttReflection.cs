using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000006 RID: 6
	public static class AbilityUseSttReflection
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002427 File Offset: 0x00000627
		public static FileDescriptor Descriptor
		{
			get
			{
				return AbilityUseSttReflection.descriptor;
			}
		}

		// Token: 0x04000010 RID: 16
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNBYmlsaXR5VXNlU3R0LnByb3RvIkkKDUFiaWxpdHlVc2VTdHQSEwoLQU9N" + "R05BTExMR0EYASABKAkSDQoFY291bnQYAiABKA0SFAoMdG90YWxfZGFtYWdl" + "GAMgASgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AbilityUseStt), AbilityUseStt.Parser, new string[]
			{
				"AOMGNALLLGA",
				"Count",
				"TotalDamage"
			}, null, null, null, null)
		}));
	}
}
