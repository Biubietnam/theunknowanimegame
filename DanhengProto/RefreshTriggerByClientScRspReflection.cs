using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D94 RID: 3476
	public static class RefreshTriggerByClientScRspReflection
	{
		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x06009B3F RID: 39743 RVA: 0x0019D055 File Offset: 0x0019B255
		public static FileDescriptor Descriptor
		{
			get
			{
				return RefreshTriggerByClientScRspReflection.descriptor;
			}
		}

		// Token: 0x04003C3C RID: 15420
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50U2NSc3AucHJvdG8ieAobUmVmcmVz",
			"aFRyaWdnZXJCeUNsaWVudFNjUnNwEhcKD3JlZnJlc2hfdHJpZ2dlchgPIAEo",
			"CBIUCgx0cmlnZ2VyX25hbWUYASABKAkSGQoRdHJpZ2dlcl9lbnRpdHlfaWQY",
			"CSABKA0SDwoHcmV0Y29kZRgDIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientScRsp), RefreshTriggerByClientScRsp.Parser, new string[]
			{
				"RefreshTrigger",
				"TriggerName",
				"TriggerEntityId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
