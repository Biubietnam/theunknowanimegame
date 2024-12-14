using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F7 RID: 2551
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveMapRotationRegionScNotify : IMessage<LeaveMapRotationRegionScNotify>, IMessage, IEquatable<LeaveMapRotationRegionScNotify>, IDeepCloneable<LeaveMapRotationRegionScNotify>, IBufferMessage
	{
		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06007139 RID: 28985 RVA: 0x0012D7CB File Offset: 0x0012B9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveMapRotationRegionScNotify> Parser
		{
			get
			{
				return LeaveMapRotationRegionScNotify._parser;
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x0600713A RID: 28986 RVA: 0x0012D7D2 File Offset: 0x0012B9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveMapRotationRegionScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x0600713B RID: 28987 RVA: 0x0012D7E4 File Offset: 0x0012B9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMapRotationRegionScNotify.Descriptor;
			}
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x0012D7EB File Offset: 0x0012B9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionScNotify()
		{
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x0012D7F3 File Offset: 0x0012B9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionScNotify(LeaveMapRotationRegionScNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x0012D80C File Offset: 0x0012BA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionScNotify Clone()
		{
			return new LeaveMapRotationRegionScNotify(this);
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x0012D814 File Offset: 0x0012BA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMapRotationRegionScNotify);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x0012D822 File Offset: 0x0012BA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMapRotationRegionScNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x0012D840 File Offset: 0x0012BA40
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

		// Token: 0x06007142 RID: 28994 RVA: 0x0012D866 File Offset: 0x0012BA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x0012D86E File Offset: 0x0012BA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x0012D877 File Offset: 0x0012BA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x0012D890 File Offset: 0x0012BA90
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

		// Token: 0x06007146 RID: 28998 RVA: 0x0012D8B6 File Offset: 0x0012BAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMapRotationRegionScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x0012D8D3 File Offset: 0x0012BAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x0012D8DC File Offset: 0x0012BADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B94 RID: 11156
		private static readonly MessageParser<LeaveMapRotationRegionScNotify> _parser = new MessageParser<LeaveMapRotationRegionScNotify>(() => new LeaveMapRotationRegionScNotify());

		// Token: 0x04002B95 RID: 11157
		private UnknownFieldSet _unknownFields;
	}
}
