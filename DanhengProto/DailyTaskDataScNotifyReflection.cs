using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000358 RID: 856
	public static class DailyTaskDataScNotifyReflection
	{
		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x0006B65D File Offset: 0x0006985D
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyTaskDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000F82 RID: 3970
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEYWlseVRhc2tEYXRhU2NOb3RpZnkucHJvdG8aD0RhaWx5VGFzay5wcm90" + "byJSChVEYWlseVRhc2tEYXRhU2NOb3RpZnkSFAoMZmluaXNoZWRfbnVtGAsg" + "ASgNEiMKD2RhaWx5X3Rhc2tfbGlzdBgDIAMoCzIKLkRhaWx5VGFza0IeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			DailyTaskReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyTaskDataScNotify), DailyTaskDataScNotify.Parser, new string[]
			{
				"FinishedNum",
				"DailyTaskList"
			}, null, null, null, null)
		}));
	}
}
