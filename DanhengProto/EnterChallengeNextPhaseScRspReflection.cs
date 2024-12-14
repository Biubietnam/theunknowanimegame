using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000438 RID: 1080
	public static class EnterChallengeNextPhaseScRspReflection
	{
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x00083FD2 File Offset: 0x000821D2
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterChallengeNextPhaseScRspReflection.descriptor;
			}
		}

		// Token: 0x04001321 RID: 4897
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlckNoYWxsZW5nZU5leHRQaGFzZVNjUnNwLnByb3RvGg9TY2VuZUlu" + "Zm8ucHJvdG8iSgocRW50ZXJDaGFsbGVuZ2VOZXh0UGhhc2VTY1JzcBIZCgVz" + "Y2VuZRgPIAEoCzIKLlNjZW5lSW5mbxIPCgdyZXRjb2RlGAggASgNQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterChallengeNextPhaseScRsp), EnterChallengeNextPhaseScRsp.Parser, new string[]
			{
				"Scene",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
