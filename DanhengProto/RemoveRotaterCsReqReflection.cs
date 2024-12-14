using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB0 RID: 3504
	public static class RemoveRotaterCsReqReflection
	{
		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x06009CB5 RID: 40117 RVA: 0x001A1861 File Offset: 0x0019FA61
		public static FileDescriptor Descriptor
		{
			get
			{
				return RemoveRotaterCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003CF2 RID: 15602
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSZW1vdmVSb3RhdGVyQ3NSZXEucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv" + "IjgKElJlbW92ZVJvdGF0ZXJDc1JlcRIiCgxyb3RhdGVyX2RhdGEYAiABKAsy" + "DC5Sb3RhdGVyRGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[]
		{
			RotaterDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RemoveRotaterCsReq), RemoveRotaterCsReq.Parser, new string[]
			{
				"RotaterData"
			}, null, null, null, null)
		}));
	}
}
