using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C96 RID: 3222
	public static class PickRogueAvatarCsReqReflection
	{
		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x06008F4F RID: 36687 RVA: 0x0017AB96 File Offset: 0x00178D96
		public static FileDescriptor Descriptor
		{
			get
			{
				return PickRogueAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400370A RID: 14090
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQaWNrUm9ndWVBdmF0YXJDc1JlcS5wcm90byJpChRQaWNrUm9ndWVBdmF0" + "YXJDc1JlcRIWCg5wcm9wX2VudGl0eV9pZBgDIAEoDRIcChR0cmlhbF9hdmF0" + "YXJfaWRfbGlzdBgCIAMoDRIbChNiYXNlX2F2YXRhcl9pZF9saXN0GAggAygN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PickRogueAvatarCsReq), PickRogueAvatarCsReq.Parser, new string[]
			{
				"PropEntityId",
				"TrialAvatarIdList",
				"BaseAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
