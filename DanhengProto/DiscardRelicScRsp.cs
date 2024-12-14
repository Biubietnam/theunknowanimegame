using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A7 RID: 935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DiscardRelicScRsp : IMessage<DiscardRelicScRsp>, IMessage, IEquatable<DiscardRelicScRsp>, IDeepCloneable<DiscardRelicScRsp>, IBufferMessage
	{
		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x00073540 File Offset: 0x00071740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DiscardRelicScRsp> Parser
		{
			get
			{
				return DiscardRelicScRsp._parser;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x00073547 File Offset: 0x00071747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiscardRelicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x00073559 File Offset: 0x00071759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardRelicScRsp.Descriptor;
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00073560 File Offset: 0x00071760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardRelicScRsp()
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00073568 File Offset: 0x00071768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardRelicScRsp(DiscardRelicScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.isDiscard_ = other.isDiscard_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00073599 File Offset: 0x00071799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardRelicScRsp Clone()
		{
			return new DiscardRelicScRsp(this);
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x000735A1 File Offset: 0x000717A1
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x000735A9 File Offset: 0x000717A9
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000735B2 File Offset: 0x000717B2
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x000735BA File Offset: 0x000717BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDiscard
		{
			get
			{
				return this.isDiscard_;
			}
			set
			{
				this.isDiscard_ = value;
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000735C3 File Offset: 0x000717C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardRelicScRsp);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000735D1 File Offset: 0x000717D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardRelicScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.IsDiscard == other.IsDiscard && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00073610 File Offset: 0x00071810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsDiscard)
			{
				num ^= this.IsDiscard.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00073668 File Offset: 0x00071868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00073670 File Offset: 0x00071870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0007367C File Offset: 0x0007187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDiscard)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsDiscard);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000736D8 File Offset: 0x000718D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsDiscard)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00073724 File Offset: 0x00071924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscardRelicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsDiscard)
			{
				this.IsDiscard = other.IsDiscard;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00073774 File Offset: 0x00071974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00073780 File Offset: 0x00071980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.IsDiscard = input.ReadBool();
				}
			}
		}

		// Token: 0x040010BC RID: 4284
		private static readonly MessageParser<DiscardRelicScRsp> _parser = new MessageParser<DiscardRelicScRsp>(() => new DiscardRelicScRsp());

		// Token: 0x040010BD RID: 4285
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010BE RID: 4286
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040010BF RID: 4287
		private uint retcode_;

		// Token: 0x040010C0 RID: 4288
		public const int IsDiscardFieldNumber = 2;

		// Token: 0x040010C1 RID: 4289
		private bool isDiscard_;
	}
}
