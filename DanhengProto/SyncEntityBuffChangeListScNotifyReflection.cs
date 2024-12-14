using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001272 RID: 4722
	public static class SyncEntityBuffChangeListScNotifyReflection
	{
		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600D2CE RID: 53966 RVA: 0x002331B2 File Offset: 0x002313B2
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncEntityBuffChangeListScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400546E RID: 21614
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZTeW5jRW50aXR5QnVmZkNoYW5nZUxpc3RTY05vdGlmeS5wcm90bxoaRW50",
			"aXR5QnVmZkNoYW5nZUluZm8ucHJvdG8iWgogU3luY0VudGl0eUJ1ZmZDaGFu",
			"Z2VMaXN0U2NOb3RpZnkSNgoXZW50aXR5X2J1ZmZfY2hhbmdlX2xpc3QYByAD",
			"KAsyFS5FbnRpdHlCdWZmQ2hhbmdlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EntityBuffChangeInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncEntityBuffChangeListScNotify), SyncEntityBuffChangeListScNotify.Parser, new string[]
			{
				"EntityBuffChangeList"
			}, null, null, null, null)
		}));
	}
}
