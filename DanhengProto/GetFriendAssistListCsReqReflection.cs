using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B4 RID: 1716
	public static class GetFriendAssistListCsReqReflection
	{
		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06004CCF RID: 19663 RVA: 0x000D033B File Offset: 0x000CE53B
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendAssistListCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001E60 RID: 7776
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5HZXRGcmllbmRBc3Npc3RMaXN0Q3NSZXEucHJvdG8aFkFzc2lzdEF2YXRh",
			"clR5cGUucHJvdG8ilQEKGEdldEZyaWVuZEFzc2lzdExpc3RDc1JlcRImCgtP",
			"UENISkhHR0tKUBgFIAEoDjIRLkFzc2lzdEF2YXRhclR5cGUSEwoLS0tLTU1Q",
			"Qk5FQ00YCSADKA0SEgoKdGFyZ2V0X3VpZBgGIAEoDRITCgtHSkVDT0hDR05N",
			"UBgNIAMoDRITCgtDT0JESExNQUxLSRgLIAEoCEIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AssistAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendAssistListCsReq), GetFriendAssistListCsReq.Parser, new string[]
			{
				"OPCHJHGGKJP",
				"KKKMMPBNECM",
				"TargetUid",
				"GJECOHCGNMP",
				"COBDHLMALKI"
			}, null, null, null, null)
		}));
	}
}
