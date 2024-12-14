using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D59 RID: 3417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitTreasureDungeonScRsp : IMessage<QuitTreasureDungeonScRsp>, IMessage, IEquatable<QuitTreasureDungeonScRsp>, IDeepCloneable<QuitTreasureDungeonScRsp>, IBufferMessage
	{
		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x060098AF RID: 39087 RVA: 0x00196A98 File Offset: 0x00194C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitTreasureDungeonScRsp> Parser
		{
			get
			{
				return QuitTreasureDungeonScRsp._parser;
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x060098B0 RID: 39088 RVA: 0x00196A9F File Offset: 0x00194C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitTreasureDungeonScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x060098B1 RID: 39089 RVA: 0x00196AB1 File Offset: 0x00194CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitTreasureDungeonScRsp.Descriptor;
			}
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x00196AB8 File Offset: 0x00194CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTreasureDungeonScRsp()
		{
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x00196AC0 File Offset: 0x00194CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTreasureDungeonScRsp(QuitTreasureDungeonScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x00196AE5 File Offset: 0x00194CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTreasureDungeonScRsp Clone()
		{
			return new QuitTreasureDungeonScRsp(this);
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x00196AED File Offset: 0x00194CED
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x00196AF5 File Offset: 0x00194CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x00196AFE File Offset: 0x00194CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitTreasureDungeonScRsp);
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x00196B0C File Offset: 0x00194D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitTreasureDungeonScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x00196B3C File Offset: 0x00194D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x00196B7B File Offset: 0x00194D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x00196B83 File Offset: 0x00194D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x00196B8C File Offset: 0x00194D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x00196BC0 File Offset: 0x00194DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x00196BFE File Offset: 0x00194DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitTreasureDungeonScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x00196C2F File Offset: 0x00194E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x00196C38 File Offset: 0x00194E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B54 RID: 15188
		private static readonly MessageParser<QuitTreasureDungeonScRsp> _parser = new MessageParser<QuitTreasureDungeonScRsp>(() => new QuitTreasureDungeonScRsp());

		// Token: 0x04003B55 RID: 15189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B56 RID: 15190
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04003B57 RID: 15191
		private uint retcode_;
	}
}
