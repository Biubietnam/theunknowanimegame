using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D1E RID: 3358
	public static class PunkLordBattleRecordListReflection
	{
		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06009604 RID: 38404 RVA: 0x0018F04A File Offset: 0x0018D24A
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleRecordListReflection.descriptor;
			}
		}

		// Token: 0x04003A30 RID: 14896
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5QdW5rTG9yZEJhdHRsZVJlY29yZExpc3QucHJvdG8aGlB1bmtMb3JkQmF0" + "dGxlUmVjb3JkLnByb3RvIk0KGFB1bmtMb3JkQmF0dGxlUmVjb3JkTGlzdBIx" + "ChJiYXR0bGVfcmVjb3JkX2xpc3QYASADKAsyFS5QdW5rTG9yZEJhdHRsZVJl" + "Y29yZEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			PunkLordBattleRecordReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordBattleRecordList), PunkLordBattleRecordList.Parser, new string[]
			{
				"BattleRecordList"
			}, null, null, null, null)
		}));
	}
}
