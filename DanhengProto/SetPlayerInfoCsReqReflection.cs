using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001120 RID: 4384
	public static class SetPlayerInfoCsReqReflection
	{
		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600C380 RID: 50048 RVA: 0x0020C9FC File Offset: 0x0020ABFC
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetPlayerInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004EF8 RID: 20216
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRQbGF5ZXJJbmZvQ3NSZXEucHJvdG8aDEdlbmRlci5wcm90byJSChJT" + "ZXRQbGF5ZXJJbmZvQ3NSZXESEQoJaXNfbW9kaWZ5GAQgASgIEhcKBmdlbmRl" + "chgDIAEoDjIHLkdlbmRlchIQCghuaWNrbmFtZRgIIAEoCUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			GenderReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetPlayerInfoCsReq), SetPlayerInfoCsReq.Parser, new string[]
			{
				"IsModify",
				"Gender",
				"Nickname"
			}, null, null, null, null)
		}));
	}
}
