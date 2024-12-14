using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001102 RID: 4354
	public static class SetGroupCustomSaveDataScRspReflection
	{
		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600C22E RID: 49710 RVA: 0x00209BA0 File Offset: 0x00207DA0
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetGroupCustomSaveDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04004E94 RID: 20116
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRHcm91cEN1c3RvbVNhdmVEYXRhU2NSc3AucHJvdG8iUgobU2V0R3Jv" + "dXBDdXN0b21TYXZlRGF0YVNjUnNwEhAKCGdyb3VwX2lkGA8gASgNEg8KB3Jl" + "dGNvZGUYDiABKA0SEAoIZW50cnlfaWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetGroupCustomSaveDataScRsp), SetGroupCustomSaveDataScRsp.Parser, new string[]
			{
				"GroupId",
				"Retcode",
				"EntryId"
			}, null, null, null, null)
		}));
	}
}
