using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010CC RID: 4300
	public static class SetAssistCsReqReflection
	{
		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600BFC7 RID: 49095 RVA: 0x002044A5 File Offset: 0x002026A5
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAssistCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004DD5 RID: 19925
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRBc3Npc3RDc1JlcS5wcm90byIwCg5TZXRBc3Npc3RDc1JlcRIRCglh" + "dmF0YXJfaWQYCyABKA0SCwoDdWlkGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistCsReq), SetAssistCsReq.Parser, new string[]
			{
				"AvatarId",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
