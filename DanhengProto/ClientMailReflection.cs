using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D8 RID: 728
	public static class ClientMailReflection
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0005C3D9 File Offset: 0x0005A5D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientMailReflection.descriptor;
			}
		}

		// Token: 0x04000D66 RID: 3430
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBDbGllbnRNYWlsLnByb3RvGg5NYWlsVHlwZS5wcm90bxoOSXRlbUxpc3Qu",
			"cHJvdG8i3AEKCkNsaWVudE1haWwSDQoFVGl0bGUYDiABKAkSDwoHQ29udGVu",
			"dBgDIAEoCRIKCgJpZBgEIAEoDRIOCgZTZW5kZXIYBSABKAkSGwoITWFpbFR5",
			"cGUYASABKA4yCS5NYWlsVHlwZRISCgpFeHBpcmVUaW1lGAcgASgDEg4KBklz",
			"UmVhZBgIIAEoCBISCgpUZW1wbGF0ZUlkGAsgASgNEh0KCkF0dGFjaG1lbnQY",
			"AiABKAsyCS5JdGVtTGlzdBIQCghQYXJhTGlzdBgKIAMoCRIMCgRUaW1lGAYg",
			"ASgDQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MailTypeReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientMail), ClientMail.Parser, new string[]
			{
				"Title",
				"Content",
				"Id",
				"Sender",
				"MailType",
				"ExpireTime",
				"IsRead",
				"TemplateId",
				"Attachment",
				"ParaList",
				"Time"
			}, null, null, null, null)
		}));
	}
}
