using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008DF RID: 2271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusUpgradeLevelCsReq : IMessage<HeliobusUpgradeLevelCsReq>, IMessage, IEquatable<HeliobusUpgradeLevelCsReq>, IDeepCloneable<HeliobusUpgradeLevelCsReq>, IBufferMessage
	{
		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x0010EE8B File Offset: 0x0010D08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusUpgradeLevelCsReq> Parser
		{
			get
			{
				return HeliobusUpgradeLevelCsReq._parser;
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x0010EE92 File Offset: 0x0010D092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusUpgradeLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06006549 RID: 25929 RVA: 0x0010EEA4 File Offset: 0x0010D0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusUpgradeLevelCsReq.Descriptor;
			}
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x0010EEAB File Offset: 0x0010D0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUpgradeLevelCsReq()
		{
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x0010EEB3 File Offset: 0x0010D0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUpgradeLevelCsReq(HeliobusUpgradeLevelCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x0010EECC File Offset: 0x0010D0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUpgradeLevelCsReq Clone()
		{
			return new HeliobusUpgradeLevelCsReq(this);
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x0010EED4 File Offset: 0x0010D0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusUpgradeLevelCsReq);
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x0010EEE2 File Offset: 0x0010D0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusUpgradeLevelCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x0010EF00 File Offset: 0x0010D100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x0010EF26 File Offset: 0x0010D126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x0010EF2E File Offset: 0x0010D12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x0010EF37 File Offset: 0x0010D137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x0010EF50 File Offset: 0x0010D150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x0010EF76 File Offset: 0x0010D176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusUpgradeLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x0010EF93 File Offset: 0x0010D193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x0010EF9C File Offset: 0x0010D19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026F8 RID: 9976
		private static readonly MessageParser<HeliobusUpgradeLevelCsReq> _parser = new MessageParser<HeliobusUpgradeLevelCsReq>(() => new HeliobusUpgradeLevelCsReq());

		// Token: 0x040026F9 RID: 9977
		private UnknownFieldSet _unknownFields;
	}
}
