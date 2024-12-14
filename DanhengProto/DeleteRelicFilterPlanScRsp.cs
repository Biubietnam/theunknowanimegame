using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000377 RID: 887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteRelicFilterPlanScRsp : IMessage<DeleteRelicFilterPlanScRsp>, IMessage, IEquatable<DeleteRelicFilterPlanScRsp>, IDeepCloneable<DeleteRelicFilterPlanScRsp>, IBufferMessage
	{
		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x0006E2A1 File Offset: 0x0006C4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteRelicFilterPlanScRsp> Parser
		{
			get
			{
				return DeleteRelicFilterPlanScRsp._parser;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x0006E2A8 File Offset: 0x0006C4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x0006E2BA File Offset: 0x0006C4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteRelicFilterPlanScRsp.Descriptor;
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0006E2C1 File Offset: 0x0006C4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteRelicFilterPlanScRsp()
		{
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x0006E2D4 File Offset: 0x0006C4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteRelicFilterPlanScRsp(DeleteRelicFilterPlanScRsp other) : this()
		{
			this.oKKJFIBNGCE_ = other.oKKJFIBNGCE_;
			this.retcode_ = other.retcode_;
			this.kDODMGGOLKL_ = other.kDODMGGOLKL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x0006E321 File Offset: 0x0006C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteRelicFilterPlanScRsp Clone()
		{
			return new DeleteRelicFilterPlanScRsp(this);
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x0006E329 File Offset: 0x0006C529
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x0006E331 File Offset: 0x0006C531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OKKJFIBNGCE
		{
			get
			{
				return this.oKKJFIBNGCE_;
			}
			set
			{
				this.oKKJFIBNGCE_ = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x0006E33A File Offset: 0x0006C53A
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x0006E342 File Offset: 0x0006C542
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

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x0006E34B File Offset: 0x0006C54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KDODMGGOLKL
		{
			get
			{
				return this.kDODMGGOLKL_;
			}
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0006E353 File Offset: 0x0006C553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteRelicFilterPlanScRsp);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0006E364 File Offset: 0x0006C564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteRelicFilterPlanScRsp other)
		{
			return other != null && (other == this || (this.OKKJFIBNGCE == other.OKKJFIBNGCE && this.Retcode == other.Retcode && this.kDODMGGOLKL_.Equals(other.kDODMGGOLKL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OKKJFIBNGCE)
			{
				num ^= this.OKKJFIBNGCE.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.kDODMGGOLKL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0006E42A File Offset: 0x0006C62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0006E432 File Offset: 0x0006C632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x0006E43C File Offset: 0x0006C63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKKJFIBNGCE)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.OKKJFIBNGCE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			this.kDODMGGOLKL_.WriteTo(ref output, DeleteRelicFilterPlanScRsp._repeated_kDODMGGOLKL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OKKJFIBNGCE)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.kDODMGGOLKL_.CalculateSize(DeleteRelicFilterPlanScRsp._repeated_kDODMGGOLKL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0006E508 File Offset: 0x0006C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteRelicFilterPlanScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OKKJFIBNGCE)
			{
				this.OKKJFIBNGCE = other.OKKJFIBNGCE;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.kDODMGGOLKL_.Add(other.kDODMGGOLKL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0006E569 File Offset: 0x0006C769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0006E574 File Offset: 0x0006C774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.OKKJFIBNGCE = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.kDODMGGOLKL_.AddEntriesFrom(ref input, DeleteRelicFilterPlanScRsp._repeated_kDODMGGOLKL_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000FE9 RID: 4073
		private static readonly MessageParser<DeleteRelicFilterPlanScRsp> _parser = new MessageParser<DeleteRelicFilterPlanScRsp>(() => new DeleteRelicFilterPlanScRsp());

		// Token: 0x04000FEA RID: 4074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FEB RID: 4075
		public const int OKKJFIBNGCEFieldNumber = 3;

		// Token: 0x04000FEC RID: 4076
		private bool oKKJFIBNGCE_;

		// Token: 0x04000FED RID: 4077
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04000FEE RID: 4078
		private uint retcode_;

		// Token: 0x04000FEF RID: 4079
		public const int KDODMGGOLKLFieldNumber = 14;

		// Token: 0x04000FF0 RID: 4080
		private static readonly FieldCodec<uint> _repeated_kDODMGGOLKL_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04000FF1 RID: 4081
		private readonly RepeatedField<uint> kDODMGGOLKL_ = new RepeatedField<uint>();
	}
}
