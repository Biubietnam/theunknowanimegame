using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200037F RID: 895
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteSummonUnitScRsp : IMessage<DeleteSummonUnitScRsp>, IMessage, IEquatable<DeleteSummonUnitScRsp>, IDeepCloneable<DeleteSummonUnitScRsp>, IBufferMessage
	{
		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x0006EEBC File Offset: 0x0006D0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteSummonUnitScRsp> Parser
		{
			get
			{
				return DeleteSummonUnitScRsp._parser;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x0006EEC3 File Offset: 0x0006D0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteSummonUnitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x0006EED5 File Offset: 0x0006D0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteSummonUnitScRsp.Descriptor;
			}
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0006EEDC File Offset: 0x0006D0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSummonUnitScRsp()
		{
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0006EEEF File Offset: 0x0006D0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSummonUnitScRsp(DeleteSummonUnitScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.entityIdList_ = other.entityIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0006EF25 File Offset: 0x0006D125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSummonUnitScRsp Clone()
		{
			return new DeleteSummonUnitScRsp(this);
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x0006EF2D File Offset: 0x0006D12D
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x0006EF35 File Offset: 0x0006D135
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

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x0006EF3E File Offset: 0x0006D13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EntityIdList
		{
			get
			{
				return this.entityIdList_;
			}
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0006EF46 File Offset: 0x0006D146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteSummonUnitScRsp);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0006EF54 File Offset: 0x0006D154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteSummonUnitScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.entityIdList_.Equals(other.entityIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.entityIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0006EFF1 File Offset: 0x0006D1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0006EFF9 File Offset: 0x0006D1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x0006F004 File Offset: 0x0006D204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.entityIdList_.WriteTo(ref output, DeleteSummonUnitScRsp._repeated_entityIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x0006F054 File Offset: 0x0006D254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.entityIdList_.CalculateSize(DeleteSummonUnitScRsp._repeated_entityIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x0006F0A8 File Offset: 0x0006D2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteSummonUnitScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.entityIdList_.Add(other.entityIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0006F0F5 File Offset: 0x0006D2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0006F100 File Offset: 0x0006D300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIdList_.AddEntriesFrom(ref input, DeleteSummonUnitScRsp._repeated_entityIdList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001007 RID: 4103
		private static readonly MessageParser<DeleteSummonUnitScRsp> _parser = new MessageParser<DeleteSummonUnitScRsp>(() => new DeleteSummonUnitScRsp());

		// Token: 0x04001008 RID: 4104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001009 RID: 4105
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400100A RID: 4106
		private uint retcode_;

		// Token: 0x0400100B RID: 4107
		public const int EntityIdListFieldNumber = 14;

		// Token: 0x0400100C RID: 4108
		private static readonly FieldCodec<uint> _repeated_entityIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x0400100D RID: 4109
		private readonly RepeatedField<uint> entityIdList_ = new RepeatedField<uint>();
	}
}
