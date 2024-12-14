using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F4 RID: 4596
	public static class SubMissionRewardScNotifyReflection
	{
		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x00227709 File Offset: 0x00225909
		public static FileDescriptor Descriptor
		{
			get
			{
				return SubMissionRewardScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040052DB RID: 21211
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TdWJNaXNzaW9uUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIk0KGFN1Yk1pc3Npb25SZXdhcmRTY05vdGlmeRIZCgZyZXdhcmQYBSAB" + "KAsyCS5JdGVtTGlzdBIWCg5zdWJfbWlzc2lvbl9pZBgMIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SubMissionRewardScNotify), SubMissionRewardScNotify.Parser, new string[]
			{
				"Reward",
				"SubMissionId"
			}, null, null, null, null)
		}));
	}
}
