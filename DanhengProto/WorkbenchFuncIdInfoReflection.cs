using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200143C RID: 5180
	public static class WorkbenchFuncIdInfoReflection
	{
		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x0600E720 RID: 59168 RVA: 0x00266302 File Offset: 0x00264502
		public static FileDescriptor Descriptor
		{
			get
			{
				return WorkbenchFuncIdInfoReflection.descriptor;
			}
		}

		// Token: 0x04005BB1 RID: 23473
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlXb3JrYmVuY2hGdW5jSWRJbmZvLnByb3RvIkIKE1dvcmtiZW5jaEZ1bmNJ" + "ZEluZm8SEAoIaXNfdmFsaWQYBSABKAgSGQoRd29ya2JlbmNoX2Z1bmNfaWQY" + "DyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WorkbenchFuncIdInfo), WorkbenchFuncIdInfo.Parser, new string[]
			{
				"IsValid",
				"WorkbenchFuncId"
			}, null, null, null, null)
		}));
	}
}
