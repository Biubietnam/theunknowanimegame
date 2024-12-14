using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000AC RID: 172
	public static class ArchiveDataReflection
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000150FD File Offset: 0x000132FD
		public static FileDescriptor Descriptor
		{
			get
			{
				return ArchiveDataReflection.descriptor;
			}
		}

		// Token: 0x040002C4 RID: 708
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFBcmNoaXZlRGF0YS5wcm90bxoRTW9uc3Rlckxpc3QucHJvdG8aD1JlbGlj",
			"TGlzdC5wcm90byLEAQoLQXJjaGl2ZURhdGESIQoZYXJjaGl2ZV9lcXVpcG1l",
			"bnRfaWRfbGlzdBgEIAMoDRIpCiFhcmNoaXZlX21pc3NpbmdfZXF1aXBtZW50",
			"X2lkX2xpc3QYASADKA0SHgoKcmVsaWNfbGlzdBgJIAMoCzIKLlJlbGljTGlz",
			"dBInChFraWxsX21vbnN0ZXJfbGlzdBgPIAMoCzIMLk1vbnN0ZXJMaXN0Eh4K",
			"FmFyY2hpdmVfYXZhdGFyX2lkX2xpc3QYByADKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MonsterListReflection.Descriptor,
			RelicListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ArchiveData), ArchiveData.Parser, new string[]
			{
				"ArchiveEquipmentIdList",
				"ArchiveMissingEquipmentIdList",
				"RelicList",
				"KillMonsterList",
				"ArchiveAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
