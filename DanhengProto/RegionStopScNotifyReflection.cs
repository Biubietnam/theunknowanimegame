using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D98 RID: 3480
	public static class RegionStopScNotifyReflection
	{
		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x0019DC46 File Offset: 0x0019BE46
		public static FileDescriptor Descriptor
		{
			get
			{
				return RegionStopScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003C56 RID: 15446
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSZWdpb25TdG9wU2NOb3RpZnkucHJvdG8iSAoSUmVnaW9uU3RvcFNjTm90" + "aWZ5EhcKD3JlZ2lvbl9zdG9wX2VuZBgOIAEoAxIZChFyZWdpb25fc3RvcF9z" + "dGFydBgHIAEoA0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RegionStopScNotify), RegionStopScNotify.Parser, new string[]
			{
				"RegionStopEnd",
				"RegionStopStart"
			}, null, null, null, null)
		}));
	}
}
