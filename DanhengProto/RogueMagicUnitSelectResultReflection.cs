using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F36 RID: 3894
	public static class RogueMagicUnitSelectResultReflection
	{
		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x001D31E4 File Offset: 0x001D13E4
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitSelectResultReflection.descriptor;
			}
		}

		// Token: 0x040046B6 RID: 18102
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZU1hZ2ljVW5pdFNlbGVjdFJlc3VsdC5wcm90bxoYUm9ndWVNYWdp" + "Y0dhbWVVbml0LnByb3RvIkwKGlJvZ3VlTWFnaWNVbml0U2VsZWN0UmVzdWx0" + "Ei4KEXNlbGVjdF9tYWdpY191bml0GA0gASgLMhMuUm9ndWVNYWdpY0dhbWVV" + "bml0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueMagicGameUnitReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicUnitSelectResult), RogueMagicUnitSelectResult.Parser, new string[]
			{
				"SelectMagicUnit"
			}, null, null, null, null)
		}));
	}
}
