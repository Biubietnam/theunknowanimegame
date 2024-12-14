using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000342 RID: 834
	public static class CustomSaveDataReflection
	{
		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x00069558 File Offset: 0x00067758
		public static FileDescriptor Descriptor
		{
			get
			{
				return CustomSaveDataReflection.descriptor;
			}
		}

		// Token: 0x04000F33 RID: 3891
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDdXN0b21TYXZlRGF0YS5wcm90byI1Cg5DdXN0b21TYXZlRGF0YRIQCghn" + "cm91cF9pZBgDIAEoDRIRCglzYXZlX2RhdGEYDSABKAlCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CustomSaveData), CustomSaveData.Parser, new string[]
			{
				"GroupId",
				"SaveData"
			}, null, null, null, null)
		}));
	}
}
