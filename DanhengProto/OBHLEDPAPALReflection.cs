using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C42 RID: 3138
	public static class OBHLEDPAPALReflection
	{
		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x0016FB73 File Offset: 0x0016DD73
		public static FileDescriptor Descriptor
		{
			get
			{
				return OBHLEDPAPALReflection.descriptor;
			}
		}

		// Token: 0x04003568 RID: 13672
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQkhMRURQQVBBTC5wcm90byJJCgtPQkhMRURQQVBBTBITCgtFTkVBR0RI" + "TkNHSRgNIAEoDRINCgVsZXZlbBgEIAEoDRIWCg5xdWV1ZV9wb3NpdGlvbhgD" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OBHLEDPAPAL), OBHLEDPAPAL.Parser, new string[]
			{
				"ENEAGDHNCGI",
				"Level",
				"QueuePosition"
			}, null, null, null, null)
		}));
	}
}
