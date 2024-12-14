using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F6 RID: 5110
	public static class UpdateRotaterScNotifyReflection
	{
		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x0600E3E3 RID: 58339 RVA: 0x0025E12C File Offset: 0x0025C32C
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateRotaterScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005A90 RID: 23184
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtVcGRhdGVSb3RhdGVyU2NOb3RpZnkucHJvdG8aEVJvdGF0ZXJEYXRhLnBy" + "b3RvIkAKFVVwZGF0ZVJvdGF0ZXJTY05vdGlmeRInChFyb3RhdGVyX2RhdGFf" + "bGlzdBgHIAMoCzIMLlJvdGF0ZXJEYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RotaterDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateRotaterScNotify), UpdateRotaterScNotify.Parser, new string[]
			{
				"RotaterDataList"
			}, null, null, null, null)
		}));
	}
}
