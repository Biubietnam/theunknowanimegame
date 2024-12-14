using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000386 RID: 902
	public static class DeployRotaterCsReqReflection
	{
		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0006FA6D File Offset: 0x0006DC6D
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeployRotaterCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001023 RID: 4131
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhEZXBsb3lSb3RhdGVyQ3NSZXEucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv" + "IjgKEkRlcGxveVJvdGF0ZXJDc1JlcRIiCgxyb3RhdGVyX2RhdGEYCSABKAsy" + "DC5Sb3RhdGVyRGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[]
		{
			RotaterDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeployRotaterCsReq), DeployRotaterCsReq.Parser, new string[]
			{
				"RotaterData"
			}, null, null, null, null)
		}));
	}
}
