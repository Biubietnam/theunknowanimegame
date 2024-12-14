using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A4 RID: 4772
	public static class SyncTaskCsReqReflection
	{
		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600D4E8 RID: 54504 RVA: 0x002385E2 File Offset: 0x002367E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncTaskCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005525 RID: 21797
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTeW5jVGFza0NzUmVxLnByb3RvIhwKDVN5bmNUYXNrQ3NSZXESCwoDa2V5" + "GAwgASgJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncTaskCsReq), SyncTaskCsReq.Parser, new string[]
			{
				"Key"
			}, null, null, null, null)
		}));
	}
}
