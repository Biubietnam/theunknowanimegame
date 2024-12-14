using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000936 RID: 2358
	public static class InteractPropCsReqReflection
	{
		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x00118F9E File Offset: 0x0011719E
		public static FileDescriptor Descriptor
		{
			get
			{
				return InteractPropCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002857 RID: 10327
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdJbnRlcmFjdFByb3BDc1JlcS5wcm90byJAChFJbnRlcmFjdFByb3BDc1Jl" + "cRITCgtpbnRlcmFjdF9pZBgDIAEoDRIWCg5wcm9wX2VudGl0eV9pZBgCIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InteractPropCsReq), InteractPropCsReq.Parser, new string[]
			{
				"InteractId",
				"PropEntityId"
			}, null, null, null, null)
		}));
	}
}
