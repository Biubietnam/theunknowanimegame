using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D8B RID: 3467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RecoverAllLineupScRsp : IMessage<RecoverAllLineupScRsp>, IMessage, IEquatable<RecoverAllLineupScRsp>, IDeepCloneable<RecoverAllLineupScRsp>, IBufferMessage
	{
		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06009ACC RID: 39628 RVA: 0x0019BE04 File Offset: 0x0019A004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecoverAllLineupScRsp> Parser
		{
			get
			{
				return RecoverAllLineupScRsp._parser;
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06009ACD RID: 39629 RVA: 0x0019BE0B File Offset: 0x0019A00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecoverAllLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x06009ACE RID: 39630 RVA: 0x0019BE1D File Offset: 0x0019A01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecoverAllLineupScRsp.Descriptor;
			}
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x0019BE24 File Offset: 0x0019A024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAllLineupScRsp()
		{
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x0019BE2C File Offset: 0x0019A02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAllLineupScRsp(RecoverAllLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x0019BE51 File Offset: 0x0019A051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAllLineupScRsp Clone()
		{
			return new RecoverAllLineupScRsp(this);
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x06009AD2 RID: 39634 RVA: 0x0019BE59 File Offset: 0x0019A059
		// (set) Token: 0x06009AD3 RID: 39635 RVA: 0x0019BE61 File Offset: 0x0019A061
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

		// Token: 0x06009AD4 RID: 39636 RVA: 0x0019BE6A File Offset: 0x0019A06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecoverAllLineupScRsp);
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x0019BE78 File Offset: 0x0019A078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecoverAllLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x0019BEA8 File Offset: 0x0019A0A8
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

		// Token: 0x06009AD7 RID: 39639 RVA: 0x0019BEE7 File Offset: 0x0019A0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x0019BEEF File Offset: 0x0019A0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x0019BEF8 File Offset: 0x0019A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x0019BF2C File Offset: 0x0019A12C
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

		// Token: 0x06009ADB RID: 39643 RVA: 0x0019BF6A File Offset: 0x0019A16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecoverAllLineupScRsp other)
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

		// Token: 0x06009ADC RID: 39644 RVA: 0x0019BF9B File Offset: 0x0019A19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x0019BFA4 File Offset: 0x0019A1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003C14 RID: 15380
		private static readonly MessageParser<RecoverAllLineupScRsp> _parser = new MessageParser<RecoverAllLineupScRsp>(() => new RecoverAllLineupScRsp());

		// Token: 0x04003C15 RID: 15381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C16 RID: 15382
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04003C17 RID: 15383
		private uint retcode_;
	}
}
