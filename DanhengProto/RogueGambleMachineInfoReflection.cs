using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E8A RID: 3722
	public static class RogueGambleMachineInfoReflection
	{
		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600A644 RID: 42564 RVA: 0x001BFA84 File Offset: 0x001BDC84
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGambleMachineInfoReflection.descriptor;
			}
		}

		// Token: 0x04004406 RID: 17414
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZUdhbWJsZU1hY2hpbmVJbmZvLnByb3RvGhVSb2d1ZUdhbWJsZUlu" + "Zm8ucHJvdG8iVAoWUm9ndWVHYW1ibGVNYWNoaW5lSW5mbxIlCgtnYW1ibGVf" + "aW5mbxgCIAEoCzIQLlJvZ3VlR2FtYmxlSW5mbxITCgtFS09MQlBKQUhDSxgG" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RogueGambleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGambleMachineInfo), RogueGambleMachineInfo.Parser, new string[]
			{
				"GambleInfo",
				"EKOLBPJAHCK"
			}, null, null, null, null)
		}));
	}
}
