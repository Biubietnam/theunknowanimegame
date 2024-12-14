using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000888 RID: 2184
	public static class HandleFriendCsReqReflection
	{
		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x0600612A RID: 24874 RVA: 0x00100C65 File Offset: 0x000FEE65
		public static FileDescriptor Descriptor
		{
			get
			{
				return HandleFriendCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002553 RID: 9555
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdIYW5kbGVGcmllbmRDc1JlcS5wcm90byIzChFIYW5kbGVGcmllbmRDc1Jl" + "cRIRCglpc19hY2NlcHQYCCABKAgSCwoDdWlkGAwgASgNQh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HandleFriendCsReq), HandleFriendCsReq.Parser, new string[]
			{
				"IsAccept",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
