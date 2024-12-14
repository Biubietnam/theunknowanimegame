using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001026 RID: 4134
	public static class RogueTournWorkbenchInfoReflection
	{
		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x001ED5D5 File Offset: 0x001EB7D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournWorkbenchInfoReflection.descriptor;
			}
		}

		// Token: 0x04004A7B RID: 19067
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1Sb2d1ZVRvdXJuV29ya2JlbmNoSW5mby5wcm90bxoZV29ya2JlbmNoRnVu",
			"Y0lkSW5mby5wcm90byJiChdSb2d1ZVRvdXJuV29ya2JlbmNoSW5mbxIUCgx3",
			"b3JrYmVuY2hfaWQYDyABKA0SMQoTd29ya2JlbmNoX2Z1bmNfbGlzdBgGIAMo",
			"CzIULldvcmtiZW5jaEZ1bmNJZEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WorkbenchFuncIdInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournWorkbenchInfo), RogueTournWorkbenchInfo.Parser, new string[]
			{
				"WorkbenchId",
				"WorkbenchFuncList"
			}, null, null, null, null)
		}));
	}
}
